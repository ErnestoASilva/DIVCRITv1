using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PermisosVacacionales
{
    public partial class frmAgregarColaborador : Form
    {
        public frmAgregarColaborador()
        {
            InitializeComponent();
        }

        //static string cadena = "Server=tutuli;Database=SISTEMA_CRIT;User Id=sa;Password=Sistemas21;";
        public static string cadena = "Data Source = Ernesto-PC; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = sa; Password = admin";

        public SqlConnection conexion = new SqlConnection(cadena);

        public int diasTotales; /*!< Son los dias totales que tiene para el colaborador. */
        public int diasDisponibles; /*!< Los dias disponibles son los dias disponibles para usar por parte del colaborador. */
        public int diasPedidos; /*!< Los dias pedidos son los dias que quiere de ausencia el colaborados. */
        public int diasPedidosActualizado; /*!< Los dias pedidos acutalizado son la nueva cantidad de dias disponibles para usar del colaborador. */

        public DateTime fechaActual = DateTime.Now;
        public DateTime fechaIngreso;

        public string direccionArchivo = string.Empty; /*!< Se especifica la ruta de acceso para acceder a las fotos que se les asignaran a los colaboradores */
        public string direccionMostrarpbx = string.Empty; /*!< Es la direccion de las fotos en el servidor donde estan alojadas. */
        public string tipoUsuario; /*!< Es el tipo de usuario registrado con el colaborador. */

        public void frmAgregarColaborador_Load(object sender, EventArgs e)
        {
            //CONSULTA PARA LLENAR EL COMBOBOX CON COLABORADORES
            cbxTipoUsuario.SelectedIndex = 0;
            cbxPuesto.SelectedIndex = 0;
            cbxArea.SelectedIndex = 0;
            SqlCommand sqlCmd = new SqlCommand("SELECT nombre FROM COLABORADORES ORDER BY nombre ASC", conexion);
            conexion.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            pbxImagen.Enabled = true;

            while (sqlReader.Read())
            {
                cbxNombreActualizar.Items.Add(sqlReader["nombre"].ToString());
            }

            conexion.Close();

            //PREGUNTA SI NO HAY NINGUN USUARIO SELECCIONADO PARA HABILITAR O DESHABILITAR LOS BOTONES
            if (cbxNombreActualizar.Text == "")
            {
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAgregarDias.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAgregarDias.Enabled = true;
            }
            
            //LLAMADA AL METODO PARA ACTIVAR O DESACTIVAR EL BOTON AGREGAR
            VerificarAgregar();

            tipoUsuario = VariablesGlobales.tipoUsuario;
            switch (tipoUsuario)
            {
                //ADMIN PUEDE ACCESAR TODOS LOS BOTONES
                case "admin":
                    break;

                //JEFE SOLO VA A PODER ACCESAR A LAS SOLICITUDES VACACIONALES, POR LO QUE SE DESHABILITA CAUS Y CHECADOR
                case "jefe":
                    inventarioToolStripMenuItem.Enabled = false;
                    break;

                case "jefe_almacen":
                    inventarioToolStripMenuItem.Enabled = false;
                    break;

                //LOS USUARIOS CON EL DERECHO DE VACACIONES SON LOS QUE PUEDEN ACCESAR A LA ACTUALIZACIÓN DE PERMISOS VACACIONALES
                // Y QUE PROCESAN LAS SOLICITUDES DE TODOS LOS COLABORADORES.
                case "vacaciones":
                    inventarioToolStripMenuItem.Enabled = false;
                    break;

                //ORIGINALMENTE ALMACEN SON LOS USUARIOS QUE PUEDEN ACCESAR A LA SECCIÓN DE 'ALMACEN', PERO YA NO EXISTE ESA SECCIÓN
                case "almacen":
                    inventarioToolStripMenuItem.Enabled = false;
                    break;

                default:
                    //CUALQUIER OTRO USUARIO DETECTADO NO PUEDE ACCESAR A LAS SECCIONES MENCIONADAS ANTERIORMENTE
                    inventarioToolStripMenuItem.Enabled = false;
                    aceptarDenegarSolicitudesToolStripMenuItem.Enabled = false;
                    //btnCaus.Enabled = false;
                    break;
            }
        }

        public void frmAgregarColaborador_FormClosed(object sender, FormClosedEventArgs e)
        {
            //EVENTO QUE CIERRA LA APLICACION CUANDO SE CIERRA LA VENTANA
            Application.Exit();
        }
        
        /**
        * EVENTO QUE SE DISPARA CADA VEZ QUE CAMBIA EL ELEMENTO SELECCIONADO EN EL COMBOBOX
        */
        public void cbxNombreActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PREGUNTA QUE ACTIVA O DESACTIVA LOS BOTONES SI EL ELEMENTO SELECCIONADO ES VACIO
            if (cbxNombreActualizar.Text == "")
            {
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                tbxNomina.Enabled = true;
                btnAgregarDias.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                tbxNomina.Enabled = false;
                btnAgregarDias.Enabled = true;
            }

            //CONSULTA PARA OBTENER Y RELLENAR LA INFORMACION DE UN COLABORADOR
            conexion.Open();
            string consulta = string.Format("SELECT C.nomina, nombre, puesto, area, correo, contrasena, tipo_usuario, dia_entrada, dias_pedidos, " +
                "email_jefe, extension, oficina FROM COLABORADORES C INNER JOIN VACACIONES V ON C.nomina = V.nomina WHERE nombre = " + "'" 
                + cbxNombreActualizar.Text.Trim() + "';");
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    tbxNomina.Text = reader["nomina"].ToString();
                    tbxNombre.Text = reader["nombre"].ToString();
                    cbxPuesto.Text = reader["puesto"].ToString();
                    cbxArea.Text = reader["area"].ToString();
                    tbxCorreo.Text = reader["correo"].ToString();
                    tbxContraseña.Text = reader["contrasena"].ToString();
                    cbxTipoUsuario.Text = reader["tipo_usuario"].ToString();
                    dtpDiaEntrada.Value = (DateTime)reader["dia_entrada"];
                    fechaIngreso = dtpDiaEntrada.Value;
                    diasPedidos = (int)reader["dias_pedidos"];
                    tbxCorreoJefe.Text = reader["email_jefe"].ToString();
                    tbxExtension.Text = reader["extension"].ToString();
                    tbxOficina.Text = reader["oficina"].ToString();
                }
            }
            catch (Exception)
            {

            }

            //CALCULO PARA OBTENER DIAS DISPONIBLES
            TimeSpan difFechas = fechaActual - fechaIngreso;
            int años = difFechas.Days / 365;
            diasTotales = años * 5;
            diasDisponibles = diasTotales - diasPedidos;
            nudDiasVacacionesPedidos.Value = diasPedidos;

            conexion.Close();

            //CONSULTA PARA DESPLEGAR LA IMAGEN DEL COLABORADOR
            conexion.Open();
            try
            {
                SqlCommand comandoFoto = new SqlCommand("SELECT imagen FROM COLABORADORES WHERE nombre = '" + cbxNombreActualizar.Text + "'", conexion);
                byte[] img = (byte[])comandoFoto.ExecuteScalar();
                MemoryStream ms = new MemoryStream(img);
                pbxImagen.Image = Image.FromStream(ms);

            }
            catch (System.Exception)
            {
                pbxImagen.Image = PermisosVacacionales.Properties.Resources.imagen;
            }
            conexion.Close();

            btnAgregar.Enabled = false;
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            //EJECUCION DEL UPDATE PARA LA TABLA DE COLABORADORES Y VACACIONES
            DateTime tres_anios_mas;
            tres_anios_mas = dtpDiaEntrada.Value.AddYears(3);

            SqlCommand sqlCmd = new SqlCommand("UPDATE COLABORADORES SET nombre = '" + tbxNombre.Text.Trim() + "', puesto = '" + cbxPuesto.Text.Trim() + "', area = '" 
                + cbxArea.Text.Trim() + "', correo = '" + tbxCorreo.Text.Trim() + "', contrasena = '" + tbxContraseña.Text.Trim() + "', tipo_usuario = '" 
                + cbxTipoUsuario.Text.Trim() + "', dia_entrada = '" + dtpDiaEntrada.Value.ToString("MM/dd/yyyy") + "', " + "proximo_reset = '" + 
                tres_anios_mas.ToString("MM/dd/yyyy") + "', email_jefe = '" + tbxCorreoJefe.Text.Trim() + "', extension = '" + tbxExtension.Text.Trim() + "', oficina = '" 
                + tbxOficina.Text.Trim() + "' where nomina = " + tbxNomina.Text.Trim(), conexion);

            SqlCommand sqlCmd2 = new SqlCommand("UPDATE VACACIONES SET dias_pedidos = '" + nudDiasVacacionesPedidos.Value + "' where nomina = " + tbxNomina.Text, conexion);

            SqlCommand sqlCmd3 = new SqlCommand("UPDATE COLABORADORES SET [imagen] = (SELECT BulkColumn FROM Openrowset (Bulk '" + direccionMostrarpbx 
                + "', Single_Blob) imagen) WHERE nomina = " + tbxNomina.Text, conexion);

            conexion.Open();
            try
            {
                //PREGUNTA PARA VERIFICAR SI LOS DIAS PEDIDOS INSERTADOS SON MENORES QUE LOS DISPONIBLES
                if (nudDiasVacacionesPedidos.Value <= diasTotales)
                {
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd2.ExecuteNonQuery();
                    sqlCmd3.ExecuteNonQuery();
                    MessageBox.Show("El colaborador ha sido actualizado exitosamente.", "Actulización Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El número de días pedidos sobrepasa la cantidad de dias disponibles.", "Actulización Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conexion.Close();
            }
            catch (SqlException ex)
            {
               //MANEJO DE ERRORES
                switch (ex.Number)
                {
                    case 207:
                        MessageBox.Show("El campo 'Nómina' debe ser un valor numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case 2627:
                        MessageBox.Show("Un colaborador con este número de nómina y/o correo ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case 4861:
                        MessageBox.Show("El colaborador ha sido actualizado exitosamente.", "Actulización Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case 4860:
                        MessageBox.Show("Porfavor seleccione una imagen de la carpeta compartida 'FOTOS SISTEMACRIT' que se encuentra en el servidor.", "Error al seleccionar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        break;
                }
                conexion.Close();
            }
            
            //LLAMADA A LOS METODOS PARA ACTUALIZAR EL COMBOBOX Y LIMPIAR LOS CAMPOS
            ResetearNombresActualizar();
            limpiarCampos();
            tbxNomina.Enabled = true;
            VerificarDias();
        }

        public void VerificarDias() 
        {
            if (cbxNombreActualizar.Text == "")

                gpbActualizar.Enabled = false;

            else 

                gpbActualizar.Enabled = true;
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            //EJECUCION DE LAS INSERCIONES PARA AGREGAR NUEVO COLABORADOR
            DateTime tres_anios_mas;
            tres_anios_mas = dtpDiaEntrada.Value.AddYears(3);
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO COLABORADORES (nomina, nombre, puesto, area, correo, contrasena, tipo_usuario, dia_entrada, email_jefe, extension, oficina, proximo_reset) " +
                "VALUES ("+tbxNomina.Text.Trim() + ", '"+tbxNombre.Text.Trim() + "', '"+cbxPuesto.Text.Trim() + "', '"+cbxArea.Text.Trim() + "', '"+tbxCorreo.Text.Trim() + "', '"+tbxContraseña.Text.Trim() + "" +
                "', '"+cbxTipoUsuario.Text.Trim() + "', '"+dtpDiaEntrada.Value.ToString("MM/dd/yyyy") +"' ,'"+tbxCorreoJefe.Text.Trim() + "', '"+tbxExtension.Text.Trim() + "', '" + tbxOficina.Text.Trim() + "', '"
                + tres_anios_mas.ToString("MM/dd/yyyy") + "')", conexion);

            SqlCommand sqlCmd2 = new SqlCommand("INSERT INTO VACACIONES (nomina, " +
                "dias_pedidos, permisos_dias_pedidos, permisos_dias_sinsueldo_pedidos, permisos_horas_pedidos) " +
                "VALUES (" + tbxNomina.Text.Trim() + ", " + nudDiasVacacionesPedidos.Value + ", " + 0 + ", " + 0 + ", " + 0 + ")", conexion);

            SqlCommand sqlCmd3 = new SqlCommand("UPDATE COLABORADORES SET [imagen] = (SELECT BulkColumn FROM Openrowset (Bulk '" + direccionMostrarpbx 
                + "', Single_Blob) imagen) WHERE nomina = " + tbxNomina.Text, conexion);

            conexion.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                sqlCmd2.ExecuteNonQuery();

                try
                {
                    //INTENTAR INSERTAR IMAGEN
                    sqlCmd3.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    //EN CASO DE NO ESPECIFICAR IMAGEN, SE INSERTA UNA GENÉRICA
                    MessageBox.Show("El colaborador ha sido registrado exitosamente.", "Registro Exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    tbxNomina.Enabled = true;

                    SqlCommand sqlCmd4 = new SqlCommand("UPDATE COLABORADORES SET [imagen] = (SELECT BulkColumn FROM Openrowset" +
                        " (Bulk '/home/ticrit/Pictures/FOTOSSISTEMACRIT/usuario.png', Single_Blob) imagen) WHERE nomina = " + tbxNomina.Text, conexion);

                    sqlCmd4.ExecuteNonQuery();
                    conexion.Close();
                    ResetearNombresActualizar();
                }
                conexion.Close();

                MessageBox.Show("El colaborador ha sido registrado exitosamente.", "Registro Exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //LLAMADA A LOS METODOS PARA ACTUALIZAR EL COMBOBOX Y LIMPIAR LOS CAMPOS
                ResetearNombresActualizar();
                limpiarCampos();
                tbxNomina.Enabled = true;

            }
            catch (SqlException ex)
            {
                //MANEJO DE ERRORES
                if (ex.Number == 207)
                {
                    MessageBox.Show("El campo 'Nómina' debe ser un valor numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (ex.Number == 2627)
                {
                    //throw;
                    MessageBox.Show("Un colaborador con este número de nómina y/o correo ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Close();

            }

            VerificarDias();

            cbxNombreActualizar.Items.Clear();

            cbxTipoUsuario.SelectedIndex = 0;
            cbxPuesto.SelectedIndex = 0;
            cbxArea.SelectedIndex = 0;
            SqlCommand sqlCmd5 = new SqlCommand("SELECT nombre FROM COLABORADORES ORDER BY nombre ASC", conexion);
            conexion.Open();
            SqlDataReader sqlReader = sqlCmd5.ExecuteReader();
            pbxImagen.Enabled = true;

            while (sqlReader.Read())
            {
                cbxNombreActualizar.Items.Add(sqlReader["nombre"].ToString());
            }

            conexion.Close();

        }

        /**
        *  METODO PARA VERIFICAR QUE TODOS LOS CAMPOS HAYAN SIDO LLENADOS ANTES DE AGREGAR
        */
        public void VerificarAgregar()
        {
            if (tbxNomina.Text == "" || tbxNombre.Text == "" || cbxPuesto.Text == "" || cbxArea.Text == "" || tbxCorreo.Text == ""
             || tbxContraseña.Text == "" || cbxTipoUsuario.Text == "" || tbxCorreoJefe.Text == "" || tbxExtension.Text == "" || tbxOficina.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        /**
        * EVENTO QUE VERIFICA SI EL CAMPO DE NOMINA YA FUE LLENADO , DE LO CONTRARIO DESACTIVA LOS BOTONES
        */
        public void tbxNomina_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNomina.Text == "")
            {
                lblAsteriscoNomina.Visible = true;
            }
            else
            {
                lblAsteriscoNomina.Visible = false;
            }
        }

        /**
        * EVENTOS PARA VERIFICAR SI TODOS LOS CAMPOS HAN SIDO LLLENADOS
        */
        public void tbxNombre_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNombre.Text=="")
            {
                lblAsteriscoNombre.Visible = true;
            }
            else
            {
                lblAsteriscoNombre.Visible = false;
            }
        }
        
        public void cbxArea_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();

        }
        public void tbxCorreo_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxCorreo.Text == "")
            {
                lblAsteriscoCorreo.Visible = true;
            }
            else
            {
                lblAsteriscoCorreo.Visible = false;
            }
        }
        public void tbxContraseña_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxContraseña.Text == "")
            {
                lblAsteriscoContra.Visible = true;
            }
            else
            {
                lblAsteriscoContra.Visible = false;

            }
        }
        public void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }
        public void tbxDiasPedidosVacaciones_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }
        public void tbxCorreoJefe_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }
        public void tbxExtension_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }
        public void tbxOficina_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }
        public void tbxNomina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            //LLAMADA A LOS METODOS PARA ACTUALIZAR EL COMBOBOX Y LIMPIAR LOS CAMPOS
            ResetearNombresActualizar();
            limpiarCampos();
            tbxNomina.Enabled = true;
        }

        public void btnAgregarDias_Click(object sender, EventArgs e)
        {
            //CALCULO PARA NUEVOS DIAS PEDIDOS(SE RESTA LA CANTIDAD DE DIAS PEDIDOS)
            diasPedidosActualizado = diasPedidos - (int)nudDiasExtra.Value;

            //EJECUCION DEL UPDATE A LA TABLA DE VACACIONES
            SqlCommand sqlCmd2 = new SqlCommand("UPDATE VACACIONES SET dias_pedidos = '" + diasPedidosActualizado + "' where nomina = " + tbxNomina.Text, conexion);
            conexion.Open();
            try
            {
                    sqlCmd2.ExecuteNonQuery();
                    MessageBox.Show("Días Extra agregados correctamente", "Actulización Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un error inesperado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conexion.Close();

            //LLAMADA A LOS METODOS PARA ACTUALIZAR EL COMBOBOX Y LIMPIAR LOS CAMPOS
            ResetearNombresActualizar();
            limpiarCampos();
            tbxNomina.Enabled = true;
            
        }

        public void pbxImagen_Click(object sender, EventArgs e)
        {
            //USANDO EL EXPLORADOR DE ARCHIVOS...
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Fotos (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                //PREGUNTA SI EL USUARIO YA ESCOGIO LA IMAGEN Y PRESIONO ACEPTAR
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //OBTENER LA RUTA DEL ARCHIVO SELECCIONADO(RUTA DEÑ SERVIDOR)
                    direccionArchivo = "/Users/TEMP/Pictures/DIVCRIT/" + openFileDialog.SafeFileName;
                    direccionMostrarpbx = openFileDialog.FileName;

                    //LEER EL CONTENIDO DEL ARCHIVO
                    var fileStream = openFileDialog.OpenFile();

                    //DEPLIEGA LA FORO EN EL PICTUREBOX
                    pbxImagen.Image = Image.FromFile(Path.Combine(Application.StartupPath, direccionMostrarpbx));
                }
            }

        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            //EJECUCION DE COMANDOS PARA ELIMNAR COLABORADOR DE TODAS LAS TABLAS
            SqlCommand sqlCmd = new SqlCommand("DELETE SOLICITUD_VACACIONES WHERE nomina = " + tbxNomina.Text, conexion);
            SqlCommand sqlCmd2 = new SqlCommand("DELETE VACACIONES WHERE nomina = " + tbxNomina.Text, conexion);
            SqlCommand sqlCmd3 = new SqlCommand("DELETE COLABORADORES WHERE nomina = " + tbxNomina.Text, conexion);

            conexion.Open();
            var resultado = MessageBox.Show("¿Estás seguro que deseas borrar a " + tbxNombre.Text + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //PREGUNTA PARA CONFIRMAR LA ELIMINACION
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd2.ExecuteNonQuery();
                    sqlCmd3.ExecuteNonQuery();
                    MessageBox.Show("Colaborador Eliminado Exitosamente", "Actulización Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocurrio un error inesperado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            conexion.Close();

            //LLAMADA A LOS METODOS PARA ACTUALIZAR EL COMBOBOX Y LIMPIAR LOS CAMPOS
            ResetearNombresActualizar();
            limpiarCampos();
            tbxNomina.Enabled = true;
            VerificarDias();
        }

        public void cbxPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }

        public void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }

        public void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new frmMenuPrincipal();
            MenuPrincipal.Show();
            this.Dispose();
        }

        public void solicitarVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MenuSolicitarVacaciones = new frmConsulta();
            MenuSolicitarVacaciones.Show();
            this.Dispose();
        }

        public void aceptarDenegarSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MenuAceptarDenegar = new frmAceptarDenegar();
            MenuAceptarDenegar.Show();
            this.Dispose();
        }

        public void directorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MenuDirectorio = new frmDirectorio();
            MenuDirectorio.Show();
            this.Dispose();
        }

        public void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MenuInventario = new frmProveedores();
            MenuInventario.Show();
            this.Dispose();
        }

        /**
        * METODO PARA RESETEAR EL COMBOBOX DE LOS NOMBRES UNA VEZ QUE SE ACTUALIZÓ LA LISTA DE COLABORADORES
        */
        public void ResetearNombresActualizar() {
            cbxNombreActualizar.Items.Clear();

            SqlCommand sqlCmd = new SqlCommand("SELECT nombre FROM COLABORADORES order by nombre", conexion);
            conexion.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxNombreActualizar.Items.Add(sqlReader["nombre"].ToString());
            }

            conexion.Close();
        }

        public void pbxRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuSuper = new frmMenuPrincipal();
            frmMenuSuper.Show();
            this.Dispose();
        }

        /**
        * MÉTODO PARA LIMPIAR TODOS LOS CAMPOS DEL FORMULARIO
        */
        public void limpiarCampos()
        {
            tbxNomina.Clear();
            tbxNombre.Clear();
            cbxPuesto.SelectedIndex = 0;
            cbxArea.SelectedIndex = 0;
            tbxCorreo.Clear();
            tbxContraseña.Clear();
            cbxTipoUsuario.SelectedIndex = 0;
            dtpDiaEntrada.Value = DateTime.Now;
            nudDiasVacacionesPedidos.Value = 0;
            tbxCorreoJefe.Clear();
            tbxExtension.Clear();
            tbxOficina.Clear();
            pbxImagen.Image = PermisosVacacionales.Properties.Resources.imagen;
            nudDiasExtra.Value = 0;
        }
    }
}
