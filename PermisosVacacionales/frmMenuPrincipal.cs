using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermisosVacacionales
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        //static string cadena = "Server=tutuli;Database=SISTEMA_CRIT;User Id=sa;Password=Sistemas21;";
        public static string cadena = "Data Source = Ernesto-PC; Initial Catalog =SISTEMA_CRIT;Persist Security Info=True;User ID = Admin; Password = admin1";
        public SqlConnection conexion = new SqlConnection(cadena);
        public string tipoUsuario; /*!< Tipo de permiso solicitado. */ 
        public int nomina; /*!<  Es la nómina del colaborador, la cuál funciona como llave primaria de la tabla de colaboradores en la base de datos. */

        public void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //CREACIÓN Y EJECUCIÓN DE LA CONSULTA PARA OBTENER LOS DATOS DE LA PERSONA QUE ACANA DE INICIAR SESIÓN
            conexion.Open();
            string consulta = ("SELECT nomina, nombre, correo, puesto, area FROM COLABORADORES WHERE correo = " + "'" + VariablesGlobales.emailUsuario + "';");
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nomina = (int)reader["nomina"];
                lblNomina.Text = nomina.ToString();
                lblNombre.Text = reader["nombre"] as string;
                lblCorreo.Text = reader["correo"] as string;
                lblPuesto.Text = reader["puesto"] as string;
                lblArea.Text = reader["area"] as string;
            }

            conexion.Close();

            conexion.Open();

            try
            {
                SqlCommand comandoFoto = new SqlCommand("SELECT imagen FROM COLABORADORES WHERE nomina = " + nomina , conexion);
                byte[] img = (byte[])comandoFoto.ExecuteScalar();
                MemoryStream ms = new MemoryStream(img);
                pbxImagen.Image = Image.FromStream(ms);

            }
            catch (Exception)
            {
                
            }

            conexion.Close();

            //DEPENDIENDO DEL TIPO DE USUARIO DETECTADO ALGUNOS BOTONES SERÁN DESACTIVADOS
            tipoUsuario = VariablesGlobales.tipoUsuario;
            switch (tipoUsuario)
            {
                //ADMIN PUEDE ACCESAR TODOS LOS BOTONES
                case "admin":
                    btnCaus.Enabled = true;
                    btnCheckIn.Enabled = true;
                    btnCaus.Enabled = true;
                    break;

                //JEFE SOLO VA A PODER ACCESAR A LAS SOLICITUDES VACACIONALES, POR LO QUE SE DESHABILITA CAUS Y CHECADOR
                case "jefe":
                    btnCaus.Enabled = false;
                    btnCheckIn.Enabled = false;
                    break;

                case "jefe_almacen":
                    btnCaus.Enabled = false;
                    btnCheckIn.Enabled = false;
                    break;

                //LOS USUARIOS CON EL DERECHO DE VACACIONES SON LOS QUE PUEDEN ACCESAR A LA ACTUALIZACIÓN DE PERMISOS VACACIONALES
                // Y QUE PROCESAN LAS SOLICITUDES DE TODOS LOS COLABORADORES.
                case "vacaciones":
                    btnCaus.Enabled = false;
                    btnCheckIn.Enabled = true;
                    btnCheckIn.Text = "ADMINISTRAR VACACIONES COLABORADORES";
                    break;

                //ORIGINALMENTE ALMACEN SON LOS USUARIOS QUE PUEDEN ACCESAR A LA SECCIÓN DE 'ALMACEN', PERO YA NO EXISTE ESA SECCIÓN
                case "almacen":
                    btnCaus.Enabled = false;
                    btnCheckIn.Enabled = false;
                    break;

                default:
                    //CUALQUIER OTRO USUARIO DETECTADO NO PUEDE ACCESAR A LAS SECCIONES MENCIONADAS ANTERIORMENTE
                    btnCaus.Enabled = false;
                    btnCheckIn.Enabled = false;
                    btnCaus.Enabled = false;
                    break;
            }
        }

        public void btnVacaciones_Click(object sender, EventArgs e)
        {
            //DEPENDIENDO DEL TIPO DE USUARIO ACTUAL, EL FORMULARIO DE VACACIONES TENDRÁ FUNCIONALIDAD DIFERENTE

            //LOS JEFES DE ÁREA, ADMINISTRADORES, Y USUARIOS CON EL TIPO DE USUARIO DE VACACIONES (RECURSOS HUMANOS) ENTRAN AL MENÚ SUPER
            // (MENÚ CON LA OPCIÓN DE ACEPTAR Y DENEGAR SOLICITUDES)
            if (tipoUsuario == "admin" || tipoUsuario == "jefe" || tipoUsuario == "jefe_almacen" || tipoUsuario == "vacaciones")
            {
                frmMenuSuper frmMenuSuper = new frmMenuSuper();
                frmMenuSuper.Show();
                this.Dispose();
            }
            else
            {
                //LOS DEMÁS USUARIOS ENTRAN DIRECTAMENTE AL PEDIDO DE SOLICITUDES
                Form frmConsulta = new frmConsulta();
                frmConsulta.Show();
                this.Dispose();
            }
        }
        public void btnDirectorio_Click(object sender, EventArgs e)
        {
            Form Directorio = new frmDirectorio();
            Directorio.Show();
            this.Dispose();
        }

        public void btnCheckIn_Click(object sender, EventArgs e)
        {
            //SI EL TIPO DE USUARIO ES VACACIONES, EL BOTON DE CHECKIN LOS LLEVARÁ AL FORMULARIO PARA ACTUALIZAR SUS DATOS
            // DE PERMISOS VACACIONALES.
            if (tipoUsuario == "vacaciones")
            {
                Form AltasyBajas = new frmActualizarVacaciones ();
                AltasyBajas.Show();
                this.Dispose();
            }
            else if(tipoUsuario == "admin")
            {
                //PARA LOS ADMINISTRADORES, ESTE BOTON LLEVA AL FORMULARIO PARA ACTUALIZAR TODOS LOS DATOS DEL USUARIO, ASÍ COMO
                // AGREGAR NUEVOS O BORRAR EXISTENTES.
                Form AltasyBajas = new frmAgregarColaborador();
                AltasyBajas.Show();
                this.Dispose();
            }
        }

        public void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        public void pbxCerrarSesion_Click(object sender, EventArgs e)
        {
            //CERRAR LA SESIÓN PARA ABRIR UNA NUEVA
            Form frmInicioSesion = new frmInicioSesion();
            frmInicioSesion.Show();
            this.Dispose();
        }

        public void btnCaus_Click(object sender, EventArgs e)
        {
            Form inv = new frmProveedores();
            inv.Show();
            this.Dispose();
        }

        private void btnVacaciones_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.Show("Acceder a la seccion de solicitud de vacaciones.", btnVacaciones);
        }
    }
}
