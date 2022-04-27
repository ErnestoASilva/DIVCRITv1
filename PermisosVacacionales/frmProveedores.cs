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
    public partial class frmProveedores : Form
    {
        //static string cadena = "Server=iturbide;Database=INVENTARIO_CRIT;User Id=super;Password=super;";
        public static string cadena = "Data Source = Ernesto-PC; Initial Catalog =INVENTARIO_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";
        public string BuscarColumna; /*!< Especificación de la variable para la columna de la base de datos. */

        //Cadena 2
        public static string cadena2 = "Data Source = Ernesto-PC; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = sa; Password = admin";

        public SqlConnection conexion = new SqlConnection(cadena);
        public string tipoUsuario; /*!< Tipo de usuario registrado(admin, usuario normal, etc.) */

        //Conexion 2
        public SqlConnection conexion2 = new SqlConnection(cadena2);
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        public void frmProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void frmProveedores_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT DISTINCT nombre FROM COLABORADORES ORDER BY nombre ASC", conexion2);
            conexion2.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxColaborador.Items.Add(sqlReader["nombre"].ToString());
            }

            conexion2.Close();

            conexion2.Open();

            SqlCommand sqlCmd2 = new SqlCommand("SELECT DISTINCT area FROM COLABORADORES ORDER BY area ASC", conexion2);
            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                cbxAreaOficina.Items.Add(sqlReader2["area"].ToString());
            }

            conexion2.Close();

            cbxBuscarColumna.SelectedIndex = 0;
            try
            {
                conexion.Open();

                string consulta = "SELECT id as 'ID', no_oficina as 'Número Oficina', area as 'Área ', colaborador as 'Colaborador', tipo_producto as 'Tipo Producto', " +
                    "no_serie as 'Número Serie', nombre_producto as 'Nombre Producto', marca_producto as 'Marca Producto' FROM PRODUCTO";
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvProveedores.ReadOnly = true;
                dgvProveedores.DataSource = ds.Tables[0];

                //dgvProveedores.RowHeadersVisible = false;
                dgvProveedores.BackgroundColor = Color.White;
            }
            catch ( SqlException sqlEx)
            {
                if (sqlEx.Number == 53)
                {
                    MessageBox.Show("No se pudo conectar con el servidor. Favor de contactar al administrador de sistemas.", "Error de conexión", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show(sqlEx.Number.ToString());
            }

            VerificarAgregar();
            conexion.Close();

            tipoUsuario = VariablesGlobales.tipoUsuario;
            switch (tipoUsuario)
            {
                //ADMIN PUEDE ACCESAR TODOS LOS BOTONES
                case "admin":
                    break;

                //JEFE SOLO VA A PODER ACCESAR A LAS SOLICITUDES VACACIONALES, POR LO QUE SE DESHABILITA CAUS Y CHECADOR
                case "jefe":
                    agregarColaboradoresToolStripMenuItem.Enabled = false;
                    break;

                case "jefe_almacen":
                    agregarColaboradoresToolStripMenuItem.Enabled = false;
                    break;

                //LOS USUARIOS CON EL DERECHO DE VACACIONES SON LOS QUE PUEDEN ACCESAR A LA ACTUALIZACIÓN DE PERMISOS VACACIONALES
                // Y QUE PROCESAN LAS SOLICITUDES DE TODOS LOS COLABORADORES.
                case "vacaciones":
                    agregarColaboradoresToolStripMenuItem.Enabled = true;
                    agregarColaboradoresToolStripMenuItem.Text = "Administrar Vacaciones Colaboradores";
                    break;

                //ORIGINALMENTE ALMACEN SON LOS USUARIOS QUE PUEDEN ACCESAR A LA SECCIÓN DE 'ALMACEN', PERO YA NO EXISTE ESA SECCIÓN
                case "almacen":
                    agregarColaboradoresToolStripMenuItem.Enabled = false;
                    break;

                default:
                    //CUALQUIER OTRO USUARIO DETECTADO NO PUEDE ACCESAR A LAS SECCIONES MENCIONADAS ANTERIORMENTE
                    agregarColaboradoresToolStripMenuItem.Enabled = false;
                    aceptarDenegarSolicitudesToolStripMenuItem.Enabled = false;
                    break;
            }
        }
        public void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.Open();
                string consulta = "INSERT INTO PRODUCTO values ('" + tbxNoOficina.Text.Trim() + "', '" + cbxAreaOficina.Text.Trim() + "', '" + cbxColaborador.Text.Trim() 
                    + "', '" + cbxTipoProducto.Text.Trim() + "', '" + tbxNoSerie.Text.Trim() + "', '" + tbxNombreProducto.Text.Trim() + "', '" 
                    + tbxMarcaProducto.Text.Trim() + "')";
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvProveedores.ReadOnly = true;
                actualizarTabla();
                //dgvProveedores.RowHeadersVisible = false;
                dgvProveedores.BackgroundColor = Color.White;

                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Una entrada con este número de serie ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conexion.Close();
        }

        /**
         * Método para despejar los textBox del formulario. 
         */
        public void LimpiarCampos() 
        {
            tbxNoSerie.Clear();
            tbxNoOficina.Clear();
            tbxMarcaProducto.Clear();
            tbxNombreProducto.Clear();
            cbxAreaOficina.SelectedIndex = 0;
            cbxTipoProducto.SelectedIndex = 0;
            cbxColaborador.SelectedIndex = 0;
        }

        /**
         * Actualiza el DataGridView para mostrar los nuevos datos modificados de la tabla en la base de datos.
         */
        public void actualizarTabla()
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT id as 'ID', no_oficina as 'Número Oficina', area as 'Área ', colaborador as 'Colaborador', tipo_producto as 'Tipo Producto', " +
                "no_serie as 'Número Serie', nombre_producto as 'Nombre Producto', marca_producto as 'Marca Producto' FROM PRODUCTO"; 
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dgvProveedores.DataSource = dtRecord;
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProducto = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            string nombreProducto = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
         
            conexion.Open();
            var resultado = MessageBox.Show("¿Estás seguro que deseas actualizar a " + nombreProducto + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string consulta = "UPDATE PRODUCTO SET no_oficina = '" + tbxNoOficina.Text + "', area = '" + cbxAreaOficina.Text + "', colaborador = '" 
                    + cbxColaborador.Text + "', tipo_producto = '"+ cbxTipoProducto.Text + "', no_serie = '"+ tbxNoSerie.Text + "', nombre_producto = '"
                    + tbxNombreProducto.Text + "', marca_producto = '"+ tbxMarcaProducto.Text + "' where id = "+ idProducto;
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                actualizarTabla();
            }

            conexion.Close();

            actualizarTabla();
            LimpiarCampos();
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            string idProducto = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
            string nombreProducto = dgvProveedores.CurrentRow.Cells[6].Value.ToString();

            conexion.Open();
            var resultado = MessageBox.Show("¿Estás seguro que deseas borrar a " + nombreProducto + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string consulta = "DELETE PRODUCTO WHERE id = " + idProducto;
                var dataAdapter = new SqlDataAdapter(consulta, conexion);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);

                var ds = new DataSet();
                dataAdapter.Fill(ds);
                actualizarTabla(); 
            }
            conexion.Close();
            LimpiarCampos();
        }

        public void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNoOficina.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
            cbxAreaOficina.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
            cbxColaborador.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
            cbxTipoProducto.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
            tbxNoSerie.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();
            tbxNombreProducto.Text = dgvProveedores.CurrentRow.Cells[6].Value.ToString();
            tbxMarcaProducto.Text = dgvProveedores.CurrentRow.Cells[7].Value.ToString();

            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnAgregar.Enabled = false;
        }
        public void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT id as 'ID', no_oficina as 'Número Oficina', area as 'Área ', colaborador as 'Colaborador', tipo_producto as 'Tipo Producto', no_serie as 'Número Serie', nombre_producto as 'Nombre Producto', marca_producto as 'Marca Producto' FROM PRODUCTO WHERE " + BuscarColumna +" LIKE '%" + tbxBuscar.Text.Trim() + "%' ORDER BY id";
            var dataAdapter = new SqlDataAdapter(consulta, conexion);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvProveedores.ReadOnly = true;
            dgvProveedores.DataSource = ds.Tables[0];
            conexion.Close();
        }

        public void cbxBuscarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxBuscarColumna.Text)
            {
                case "Número Oficina":
                    BuscarColumna = "no_oficina";
                    break;

                case "Área Oficina":
                    BuscarColumna = "area";
                    break;

                case "Colaborador":
                    BuscarColumna = "colaborador";
                    break;

                case "Tipo Producto":
                    BuscarColumna = "tipo_producto";
                    break;

                case "Número Serie":
                    BuscarColumna = "no_serie";
                    break;

                case "Nombre Producto":
                    BuscarColumna = "nombre_producto";
                    break;

                case "Marca Producto":
                    BuscarColumna = "marca_producto";
                    break;

                default:
                    BuscarColumna = "nombre_producto";
                    break;
            }
        }

        /**
         * METODO PARA VERIFICAR QUE TODOS LOS CAMPOS HAYAN SIDO LLENADOS ANTES DE AGREGAR
         */
        public void VerificarAgregar()
        {
            if (tbxNoOficina.Text == "" || cbxAreaOficina.Text == "" || cbxColaborador.Text == "" || cbxTipoProducto.Text == "" || tbxNoSerie.Text == ""
             || tbxNombreProducto.Text == "" || tbxMarcaProducto.Text == "")
            {
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        public void pbxRegresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal inv = new frmMenuPrincipal();
            this.Hide();
            inv.Show();
        }

        public void cbxAreaOficina_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }

        public void cbxColaborador_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
        }

        public void cbxAreaOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (cbxAreaOficina.Text=="")
            {
                lblAsteriscoAreaOficina.Visible = true;
            }
            else
            {
                lblAsteriscoAreaOficina.Visible = false;
            }
        }

        public void tbxNoOficina_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNoOficina.Text == "")
            {
                lblAsteriscoNoOficina.Visible = true;
            }
            else
            {
                lblAsteriscoNoOficina.Visible = false;
            }
        }

        public void cbxColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (cbxColaborador.Text == "")
            {
                lblAsteriscoColaborador.Visible = true;
            }
            else
            {
                lblAsteriscoColaborador.Visible = false;
            }
        }

        public void cbxTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (cbxTipoProducto.Text == "")
            {
                lblAsteriscoTipoProd.Visible = true;
            }
            else
            {
                lblAsteriscoTipoProd.Visible = false;
            }
        }

        public void tbxNoSerie_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNoSerie.Text == "")
            {
                lblAsteriscoNoSerie.Visible = true;
            }
            else
            {
                lblAsteriscoNoSerie.Visible = false;
            }
        }

        public void tbxNombreProducto_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxNombreProducto.Text == "")
            {
                lblAsteriscoNomProd.Visible = true;
            }
            else
            {
                lblAsteriscoNomProd.Visible = false;
            }
        }

        public void tbxMarcaProducto_TextChanged(object sender, EventArgs e)
        {
            VerificarAgregar();
            if (tbxMarcaProducto.Text == "")
            {
                lblAsteriscoMarProd.Visible = true;
            }
            else
            {
               lblAsteriscoMarProd.Visible = false;
            }
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
    }
}
