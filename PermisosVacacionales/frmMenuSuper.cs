using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermisosVacacionales
{
    public partial class frmMenuSuper : Form
    {
        public frmMenuSuper()
        {
            InitializeComponent();
        }
        public void frmMenuSuper_Load(object sender, EventArgs e)
        {
           
        }

        public void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta frmConsulta = new frmConsulta();
            frmConsulta.Show();
            this.Dispose();
        }

        public void btnListaPedidos_Click(object sender, EventArgs e)
        {
            frmAceptarDenegar frmAceptarDenegar = new frmAceptarDenegar();
            frmAceptarDenegar.Show();
            this.Dispose();
        }

        public void frmMenuSuper_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void pbxRegresar_Click(object sender, EventArgs e)
        {
            Form MenuPrincipal = new frmMenuPrincipal();
            MenuPrincipal.Show();
            this.Dispose();
        }
    }
}
