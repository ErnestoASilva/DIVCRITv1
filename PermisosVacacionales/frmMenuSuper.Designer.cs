
namespace PermisosVacacionales
{
    partial class frmMenuSuper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuSuper));
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnListaPedidos = new System.Windows.Forms.Button();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Purple;
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(53, 15);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(200, 200);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "SOLICITAR VACACIONES";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnListaPedidos
            // 
            this.btnListaPedidos.BackColor = System.Drawing.Color.Purple;
            this.btnListaPedidos.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnListaPedidos.ForeColor = System.Drawing.Color.White;
            this.btnListaPedidos.Location = new System.Drawing.Point(263, 15);
            this.btnListaPedidos.Margin = new System.Windows.Forms.Padding(5);
            this.btnListaPedidos.Name = "btnListaPedidos";
            this.btnListaPedidos.Size = new System.Drawing.Size(200, 200);
            this.btnListaPedidos.TabIndex = 1;
            this.btnListaPedidos.Text = "ACEPTAR O RECHAZAR SOLICITUDES";
            this.btnListaPedidos.UseVisualStyleBackColor = false;
            this.btnListaPedidos.Click += new System.EventHandler(this.btnListaPedidos_Click);
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(5, 5);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(40, 40);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 3;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // frmMenuSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 231);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.btnListaPedidos);
            this.Controls.Add(this.btnConsulta);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 270);
            this.MinimumSize = new System.Drawing.Size(497, 270);
            this.Name = "frmMenuSuper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos y Vacaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuSuper_FormClosed);
            this.Load += new System.EventHandler(this.frmMenuSuper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnListaPedidos;
        private System.Windows.Forms.PictureBox pbxRegresar;
    }
}