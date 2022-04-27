
namespace PermisosVacacionales
{
    partial class frmActualizarVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarVacaciones));
            this.nudDiasVacacionesPedidos = new System.Windows.Forms.NumericUpDown();
            this.dtpDiaEntrada = new System.Windows.Forms.DateTimePicker();
            this.tbxCorreoJefe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudDiasExtra = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNombreActualizar = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            this.lblDiasDisponibles = new System.Windows.Forms.Label();
            this.gbxDiasExtra = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aceptarDenegarSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasVacacionesPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.gbxDiasExtra.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDiasVacacionesPedidos
            // 
            this.nudDiasVacacionesPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudDiasVacacionesPedidos.Location = new System.Drawing.Point(336, 216);
            this.nudDiasVacacionesPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.nudDiasVacacionesPedidos.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudDiasVacacionesPedidos.Name = "nudDiasVacacionesPedidos";
            this.nudDiasVacacionesPedidos.Size = new System.Drawing.Size(420, 30);
            this.nudDiasVacacionesPedidos.TabIndex = 49;
            // 
            // dtpDiaEntrada
            // 
            this.dtpDiaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDiaEntrada.Location = new System.Drawing.Point(336, 170);
            this.dtpDiaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDiaEntrada.Name = "dtpDiaEntrada";
            this.dtpDiaEntrada.Size = new System.Drawing.Size(419, 30);
            this.dtpDiaEntrada.TabIndex = 48;
            // 
            // tbxCorreoJefe
            // 
            this.tbxCorreoJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxCorreoJefe.Location = new System.Drawing.Point(336, 261);
            this.tbxCorreoJefe.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCorreoJefe.Name = "tbxCorreoJefe";
            this.tbxCorreoJefe.Size = new System.Drawing.Size(419, 30);
            this.tbxCorreoJefe.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(75, 261);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 25);
            this.label14.TabIndex = 46;
            this.label14.Text = "Correo Jefe Inmediato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Día de Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Dias de Vacaciones Pedidos:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(336, 302);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(420, 43);
            this.btnLimpiar.TabIndex = 50;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nudDiasExtra
            // 
            this.nudDiasExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudDiasExtra.Location = new System.Drawing.Point(250, 35);
            this.nudDiasExtra.Margin = new System.Windows.Forms.Padding(4);
            this.nudDiasExtra.Name = "nudDiasExtra";
            this.nudDiasExtra.Size = new System.Drawing.Size(420, 30);
            this.nudDiasExtra.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Agregar Dias Extra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Seleccione Colaborador: ";
            // 
            // cbxNombreActualizar
            // 
            this.cbxNombreActualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNombreActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxNombreActualizar.FormattingEnabled = true;
            this.cbxNombreActualizar.Location = new System.Drawing.Point(336, 93);
            this.cbxNombreActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNombreActualizar.Name = "cbxNombreActualizar";
            this.cbxNombreActualizar.Size = new System.Drawing.Size(419, 33);
            this.cbxNombreActualizar.TabIndex = 39;
            this.cbxNombreActualizar.SelectedIndexChanged += new System.EventHandler(this.cbxNombreActualizar_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(455, 352);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(184, 63);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(12, 45);
            this.pbxRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(53, 49);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 52;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // lblDiasDisponibles
            // 
            this.lblDiasDisponibles.AutoSize = true;
            this.lblDiasDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiasDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblDiasDisponibles.Location = new System.Drawing.Point(12, 586);
            this.lblDiasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasDisponibles.Name = "lblDiasDisponibles";
            this.lblDiasDisponibles.Size = new System.Drawing.Size(0, 25);
            this.lblDiasDisponibles.TabIndex = 53;
            // 
            // gbxDiasExtra
            // 
            this.gbxDiasExtra.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiasExtra.Controls.Add(this.btnAgregar);
            this.gbxDiasExtra.Controls.Add(this.label2);
            this.gbxDiasExtra.Controls.Add(this.nudDiasExtra);
            this.gbxDiasExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxDiasExtra.ForeColor = System.Drawing.Color.White;
            this.gbxDiasExtra.Location = new System.Drawing.Point(25, 423);
            this.gbxDiasExtra.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDiasExtra.Name = "gbxDiasExtra";
            this.gbxDiasExtra.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDiasExtra.Size = new System.Drawing.Size(731, 156);
            this.gbxDiasExtra.TabIndex = 54;
            this.gbxDiasExtra.TabStop = false;
            this.gbxDiasExtra.Text = "Días Extra";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(275, 76);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 63);
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.vacacionesToolStripMenuItem,
            this.directorioToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 28);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menú Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // vacacionesToolStripMenuItem
            // 
            this.vacacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarVacacionesToolStripMenuItem,
            this.aceptarDenegarSolicitudesToolStripMenuItem});
            this.vacacionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.vacacionesToolStripMenuItem.Name = "vacacionesToolStripMenuItem";
            this.vacacionesToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.vacacionesToolStripMenuItem.Text = "Vacaciones";
            // 
            // solicitarVacacionesToolStripMenuItem
            // 
            this.solicitarVacacionesToolStripMenuItem.Name = "solicitarVacacionesToolStripMenuItem";
            this.solicitarVacacionesToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.solicitarVacacionesToolStripMenuItem.Text = "Solicitar Vacaciones";
            this.solicitarVacacionesToolStripMenuItem.Click += new System.EventHandler(this.solicitarVacacionesToolStripMenuItem_Click);
            // 
            // aceptarDenegarSolicitudesToolStripMenuItem
            // 
            this.aceptarDenegarSolicitudesToolStripMenuItem.Name = "aceptarDenegarSolicitudesToolStripMenuItem";
            this.aceptarDenegarSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.aceptarDenegarSolicitudesToolStripMenuItem.Text = "Aceptar/Denegar Solicitudes";
            this.aceptarDenegarSolicitudesToolStripMenuItem.Click += new System.EventHandler(this.aceptarDenegarSolicitudesToolStripMenuItem_Click);
            // 
            // directorioToolStripMenuItem
            // 
            this.directorioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.directorioToolStripMenuItem.Name = "directorioToolStripMenuItem";
            this.directorioToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.directorioToolStripMenuItem.Text = "Directorio";
            this.directorioToolStripMenuItem.Click += new System.EventHandler(this.directorioToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // frmActualizarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PermisosVacacionales.Properties.Resources.Fondo_Teleton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 596);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxDiasExtra);
            this.Controls.Add(this.lblDiasDisponibles);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.nudDiasVacacionesPedidos);
            this.Controls.Add(this.cbxNombreActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDiaEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tbxCorreoJefe);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(813, 630);
            this.Name = "frmActualizarVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActualizarVacaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmActualizarVacaciones_FormClosed);
            this.Load += new System.EventHandler(this.frmActualizarVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasVacacionesPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.gbxDiasExtra.ResumeLayout(false);
            this.gbxDiasExtra.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiasVacacionesPedidos;
        private System.Windows.Forms.DateTimePicker dtpDiaEntrada;
        private System.Windows.Forms.TextBox tbxCorreoJefe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown nudDiasExtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNombreActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pbxRegresar;
        private System.Windows.Forms.Label lblDiasDisponibles;
        private System.Windows.Forms.GroupBox gbxDiasExtra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarVacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aceptarDenegarSolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
    }
}