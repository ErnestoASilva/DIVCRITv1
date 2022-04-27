using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermisosVacacionales
{
    public partial class frmActualizarVacaciones : Form
    {
        public frmActualizarVacaciones()
        {
            InitializeComponent();
        }

        //static string cadena = "Server=tutuli;Database=SISTEMA_CRIT;User Id=sa;Password=Sistemas21;";
        public static string cadena = "Data Source = Ernesto-PC; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";

        public SqlConnection conexion = new SqlConnection(cadena);
        public string tipoUsuario; /*!< Es el tipo de usuario registrado con el colaborador. */
        public int diasTotales; /*!< Son los dias totales que tiene para el colaborado */
        public int diasPedidos; /*!< Los dias disponibles son los dias disponibles para usar por parte del colaborador */
        public int diasDisponibles; /*!< Los dias pedidos son los dias que quiere de ausencia el colaborados */
        public int diasPedidosActualizado; /*!< Los dias pedidos acutalizado son la nueva cantidad de dias disponibles para usar del colaborador */
        public int nomina; /*!< Es la nómina del colaborador, la cuál funciona como llave primaria de la tabla de colaboradores en la base de datos. */

        public DateTime fechaActual = DateTime.Now; 
        public DateTime fechaIngreso; 
        public void gpbActualizar_Enter(object sender, EventArgs e)
        {

        }

        public void frmActualizarVacaciones_Load(object sender, EventArgs e)
        {
            //CONSULTA PARA RELLENAR EL COMBOBOX CON LOS NOMBRES DE LOS COLABORADORES
            SqlCommand sqlCmd = new SqlCommand("SELECT nombre FROM COLABORADORES ORDER BY nombre ASC", conexion);
            conexion.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxNombreActualizar.Items.Add(sqlReader["nombre"].ToString());
            }

            conexion.Close();

            //PREGUNTA SI NO HAY NINGUN USUARIO SELECCIONADO PARA HABILITAR O DESHABILITAR LOS BOTONES
            if (cbxNombreActualizar.Text == "")
            {
                btnActualizar.Enabled = false;
                gbxDiasExtra.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
                gbxDiasExtra.Enabled = true;
            }

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

        public void frmActualizarVacaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /**
         * EVENTO QUE SE DISPARA CADA VEZ QUE CAMBIA EL ELEMENTO SELECCIONADO EN EL COMBOBOX
         */
        public void cbxNombreActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PREGUNTA SI NO HAY NINGUN USUARIO SELECCIONADO PARA HABILITAR O DESHABILITAR LOS BOTONES
            if (cbxNombreActualizar.Text == "")
            {
                btnActualizar.Enabled = false;
                gbxDiasExtra.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
                gbxDiasExtra.Enabled = true;
            }

            //CONSULTA PARA OBTENER INFORMACION DE COLABORADORES
            conexion.Open();
            string consulta = string.Format("SELECT C.nomina, nombre, puesto, area, correo, contrasena, tipo_usuario, dia_entrada, dias_pedidos, email_jefe " +
                "FROM COLABORADORES C INNER JOIN VACACIONES V ON C.nomina = V.nomina WHERE nombre = " + "'" + cbxNombreActualizar.Text.Trim() + "';");

            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nomina = (int)reader[0];
                dtpDiaEntrada.Value = (DateTime)reader["dia_entrada"];
                fechaIngreso = dtpDiaEntrada.Value;
                diasPedidos = (int)reader["dias_pedidos"];
                tbxCorreoJefe.Text = reader["email_jefe"].ToString();

            }

            //DESPLIEGUE DE INFORMACION CONSULTADA
            nudDiasVacacionesPedidos.Value = diasPedidos;
            nudDiasExtra.Value = 0;
            lblDiasDisponibles.Text = diasDisponibles.ToString();
            conexion.Close();

            //CALCULO DE AÑOS
            TimeSpan difFechas = fechaActual - fechaIngreso;
            int años = difFechas.Days / 365;
            diasTotales = años * 5;

            //SE CALCULA LOS DIAS DISPONIBLES
            diasDisponibles = diasTotales - diasPedidos;
            lblDiasDisponibles.Text = "Días disponibles: " + diasDisponibles.ToString();
        }


        public void btnAgregar_Click(object sender, EventArgs e)
        {
            //CALCULO PARA NUEVOS DIAS PEDIDOS(SE RESTA LA CANTIDAD DE DIAS PEDIDOS)
            diasPedidosActualizado = diasPedidos - (int)nudDiasExtra.Value;

            //EJECUCION DEL UPDATE A LA TABLA DE VACACIONES
            SqlCommand sqlCmd3 = new SqlCommand("UPDATE VACACIONES SET dias_pedidos = " + diasPedidosActualizado + " where nomina = " + nomina, conexion);
            conexion.Open();
            try
            {
                sqlCmd3.ExecuteNonQuery();
                MessageBox.Show("Se han añadido los dias extra exitosamente.", "Actulización Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexion.Close();

            //EVENTO PARA
            cbxNombreActualizar_SelectedIndexChanged((object)sender, (EventArgs)e);
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

        public void agregarColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == "vacaciones")
            {
                Form AltasyBajas = new frmActualizarVacaciones();
                AltasyBajas.Show();
                this.Dispose();

            }
            else if (tipoUsuario == "admin")
            {
                //PARA LOS ADMINISTRADORES, ESTE BOTON LLEVA AL FORMULARIO PARA ACTUALIZAR TODOS LOS DATOS DEL USUARIO, ASÍ COMO
                // AGREGAR NUEVOS O BORRAR EXISTENTES.
                Form AltasyBajas = new frmAgregarColaborador();
                AltasyBajas.Show();
                this.Dispose();
            }
        }

        public void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MenuInventario = new frmProveedores();
            MenuInventario.Show();
            this.Dispose();
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            //EJECUCION DEL UPDATE PARA LA TABLA COLABORADORES Y VACACIONES
            DateTime primer_reset = dtpDiaEntrada.Value.AddYears(3);
            SqlCommand sqlCmd = new SqlCommand("UPDATE COLABORADORES SET dia_entrada = '" + dtpDiaEntrada.Value.ToString("MM/dd/yyyy") + "', proximo_reset = '" + primer_reset.ToString("MM/dd/yyyy") + "', " +
                 "email_jefe = '" + tbxCorreoJefe.Text + "' where nomina = " + nomina, conexion);
            SqlCommand sqlCmd2 = new SqlCommand("UPDATE VACACIONES SET dias_pedidos = " + nudDiasVacacionesPedidos.Value + " where nomina = " + nomina, conexion);
            conexion.Open();

            try
            {
                if (nudDiasVacacionesPedidos.Value <= diasTotales)
                {
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd2.ExecuteNonQuery();
                    MessageBox.Show("El colaborador ha sido actualizado exitosamente.", "Actulización Exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El número de días pedidos sobrepasa la cantidad de dias disponibles.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio un error inesperado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
            conexion.Close();

            //LLAMADA AL EVENTO PARA ACTUALIZAR EL COMBOBOX
            cbxNombreActualizar_SelectedIndexChanged((object)sender, (EventArgs)e);
        }

        public void pbxRegresar_Click(object sender, EventArgs e)
        {
            //BOTON PARA REGRESAR AL MENU DE JEFES
            frmMenuPrincipal frmMenuSuper = new frmMenuPrincipal();
            frmMenuSuper.Show();
            this.Dispose();
        }
        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            //LLAMDA AL METODO DE LIMPIAR CAMPOS
            limpiarCampos();
        }

        /**
         *  METODO QUE LIMPIA TODOS LOS CAMPOS
         */
        public void limpiarCampos()
        {
            dtpDiaEntrada.Value = DateTime.Now;
            nudDiasVacacionesPedidos.Value = 0;
            tbxCorreoJefe.Clear();
        }
    }
}
