
namespace PermisosVacacionales
{
    partial class frmAceptarDenegar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAceptarDenegar));
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.cbxEstadoLista = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDenegar = new System.Windows.Forms.Button();
            this.lblNomina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoPermiso = new System.Windows.Forms.Label();
            this.lblDiasPedidos = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblEstadoRH = new System.Windows.Forms.Label();
            this.lblEstadoJefe = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxSolicitud = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMotivo = new System.Windows.Forms.RichTextBox();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.gbxSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(13, 127);
            this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.RowHeadersWidth = 51;
            this.dgvSolicitudes.Size = new System.Drawing.Size(579, 610);
            this.dgvSolicitudes.TabIndex = 0;
            this.dgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellClick);
            this.dgvSolicitudes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_RowEnter);
            // 
            // cbxEstadoLista
            // 
            this.cbxEstadoLista.FormattingEnabled = true;
            this.cbxEstadoLista.Items.AddRange(new object[] {
            "PENDIENTE",
            "APROBADA",
            "RECHAZADA",
            "TODOS"});
            this.cbxEstadoLista.Location = new System.Drawing.Point(106, 96);
            this.cbxEstadoLista.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstadoLista.Name = "cbxEstadoLista";
            this.cbxEstadoLista.Size = new System.Drawing.Size(187, 24);
            this.cbxEstadoLista.TabIndex = 2;
            this.cbxEstadoLista.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoLista_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(292, 556);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 52);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnDenegar
            // 
            this.btnDenegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDenegar.ForeColor = System.Drawing.Color.Black;
            this.btnDenegar.Location = new System.Drawing.Point(124, 556);
            this.btnDenegar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.Size = new System.Drawing.Size(160, 52);
            this.btnDenegar.TabIndex = 4;
            this.btnDenegar.Text = "DENEGAR";
            this.btnDenegar.UseVisualStyleBackColor = true;
            this.btnDenegar.Click += new System.EventHandler(this.btnDenegar_Click);
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.BackColor = System.Drawing.Color.Transparent;
            this.lblNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomina.ForeColor = System.Drawing.Color.White;
            this.lblNomina.Location = new System.Drawing.Point(8, 42);
            this.lblNomina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(85, 25);
            this.lblNomina.TabIndex = 5;
            this.lblNomina.Text = "Nómina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estado:";
            // 
            // lblTipoPermiso
            // 
            this.lblTipoPermiso.AutoSize = true;
            this.lblTipoPermiso.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoPermiso.ForeColor = System.Drawing.Color.White;
            this.lblTipoPermiso.Location = new System.Drawing.Point(8, 113);
            this.lblTipoPermiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPermiso.Name = "lblTipoPermiso";
            this.lblTipoPermiso.Size = new System.Drawing.Size(160, 25);
            this.lblTipoPermiso.TabIndex = 7;
            this.lblTipoPermiso.Text = "Tipo de Permiso:";
            // 
            // lblDiasPedidos
            // 
            this.lblDiasPedidos.AutoSize = true;
            this.lblDiasPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiasPedidos.ForeColor = System.Drawing.Color.White;
            this.lblDiasPedidos.Location = new System.Drawing.Point(8, 149);
            this.lblDiasPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasPedidos.Name = "lblDiasPedidos";
            this.lblDiasPedidos.Size = new System.Drawing.Size(133, 25);
            this.lblDiasPedidos.TabIndex = 8;
            this.lblDiasPedidos.Text = "Días Pedidos:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(8, 185);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(127, 25);
            this.lblFechaInicio.TabIndex = 9;
            this.lblFechaInicio.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.White;
            this.lblFechaFinal.Location = new System.Drawing.Point(8, 220);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(120, 25);
            this.lblFechaFinal.TabIndex = 10;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.BackColor = System.Drawing.Color.Transparent;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMotivo.ForeColor = System.Drawing.Color.White;
            this.lblMotivo.Location = new System.Drawing.Point(8, 256);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(76, 25);
            this.lblMotivo.TabIndex = 11;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblEstadoRH
            // 
            this.lblEstadoRH.AutoSize = true;
            this.lblEstadoRH.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEstadoRH.ForeColor = System.Drawing.Color.White;
            this.lblEstadoRH.Location = new System.Drawing.Point(8, 410);
            this.lblEstadoRH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoRH.Name = "lblEstadoRH";
            this.lblEstadoRH.Size = new System.Drawing.Size(83, 25);
            this.lblEstadoRH.TabIndex = 12;
            this.lblEstadoRH.Text = "[estado]";
            // 
            // lblEstadoJefe
            // 
            this.lblEstadoJefe.AutoSize = true;
            this.lblEstadoJefe.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEstadoJefe.ForeColor = System.Drawing.Color.White;
            this.lblEstadoJefe.Location = new System.Drawing.Point(8, 479);
            this.lblEstadoJefe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoJefe.Name = "lblEstadoJefe";
            this.lblEstadoJefe.Size = new System.Drawing.Size(83, 25);
            this.lblEstadoJefe.TabIndex = 13;
            this.lblEstadoJefe.Text = "[estado]";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(8, 78);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbxSolicitud
            // 
            this.gbxSolicitud.BackColor = System.Drawing.Color.Transparent;
            this.gbxSolicitud.Controls.Add(this.label2);
            this.gbxSolicitud.Controls.Add(this.label3);
            this.gbxSolicitud.Controls.Add(this.rtbMotivo);
            this.gbxSolicitud.Controls.Add(this.btnDenegar);
            this.gbxSolicitud.Controls.Add(this.btnAceptar);
            this.gbxSolicitud.Controls.Add(this.lblEstadoJefe);
            this.gbxSolicitud.Controls.Add(this.lblNombre);
            this.gbxSolicitud.Controls.Add(this.lblNomina);
            this.gbxSolicitud.Controls.Add(this.lblTipoPermiso);
            this.gbxSolicitud.Controls.Add(this.lblEstadoRH);
            this.gbxSolicitud.Controls.Add(this.lblDiasPedidos);
            this.gbxSolicitud.Controls.Add(this.lblMotivo);
            this.gbxSolicitud.Controls.Add(this.lblFechaInicio);
            this.gbxSolicitud.Controls.Add(this.lblFechaFinal);
            this.gbxSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxSolicitud.ForeColor = System.Drawing.Color.White;
            this.gbxSolicitud.Location = new System.Drawing.Point(600, 116);
            this.gbxSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSolicitud.Name = "gbxSolicitud";
            this.gbxSolicitud.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSolicitud.Size = new System.Drawing.Size(577, 621);
            this.gbxSolicitud.TabIndex = 15;
            this.gbxSolicitud.TabStop = false;
            this.gbxSolicitud.Text = "Solicitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estado de Solicitud a Jefe Directo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado de Solicitud a Recursos Humanos:";
            // 
            // rtbMotivo
            // 
            this.rtbMotivo.Enabled = false;
            this.rtbMotivo.Location = new System.Drawing.Point(13, 286);
            this.rtbMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMotivo.Name = "rtbMotivo";
            this.rtbMotivo.Size = new System.Drawing.Size(547, 77);
            this.rtbMotivo.TabIndex = 15;
            this.rtbMotivo.Text = "";
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(18, 42);
            this.pbxRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(53, 49);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 18;
            this.pbxRegresar.TabStop = false;
            this.pbxRegresar.Click += new System.EventHandler(this.pbxRegresar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.vacacionesToolStripMenuItem,
            this.directorioToolStripMenuItem,
            this.agregarColaboradoresToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 28);
            this.menuStrip1.TabIndex = 19;
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
            this.solicitarVacacionesToolStripMenuItem});
            this.vacacionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.vacacionesToolStripMenuItem.Name = "vacacionesToolStripMenuItem";
            this.vacacionesToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.vacacionesToolStripMenuItem.Text = "Vacaciones";
            // 
            // solicitarVacacionesToolStripMenuItem
            // 
            this.solicitarVacacionesToolStripMenuItem.Name = "solicitarVacacionesToolStripMenuItem";
            this.solicitarVacacionesToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.solicitarVacacionesToolStripMenuItem.Text = "Solicitar Vacaciones";
            this.solicitarVacacionesToolStripMenuItem.Click += new System.EventHandler(this.solicitarVacacionesToolStripMenuItem_Click);
            // 
            // directorioToolStripMenuItem
            // 
            this.directorioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.directorioToolStripMenuItem.Name = "directorioToolStripMenuItem";
            this.directorioToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.directorioToolStripMenuItem.Text = "Directorio";
            this.directorioToolStripMenuItem.Click += new System.EventHandler(this.directorioToolStripMenuItem_Click);
            // 
            // agregarColaboradoresToolStripMenuItem
            // 
            this.agregarColaboradoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarColaboradoresToolStripMenuItem.Name = "agregarColaboradoresToolStripMenuItem";
            this.agregarColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.agregarColaboradoresToolStripMenuItem.Text = "Agregar Colaboradores";
            this.agregarColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.agregarColaboradoresToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmAceptarDenegar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 766);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.gbxSolicitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoLista);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAceptarDenegar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes Pendientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAceptarDenegar_FormClosed);
            this.Load += new System.EventHandler(this.frmAceptarDenegar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.gbxSolicitud.ResumeLayout(false);
            this.gbxSolicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.ComboBox cbxEstadoLista;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnDenegar;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoPermiso;
        private System.Windows.Forms.Label lblDiasPedidos;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblEstadoRH;
        private System.Windows.Forms.Label lblEstadoJefe;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbxSolicitud;
        private System.Windows.Forms.RichTextBox rtbMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxRegresar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarVacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarColaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}