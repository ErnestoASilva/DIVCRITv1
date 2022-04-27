
namespace PermisosVacacionales
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.tbxBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cbxBuscarColumna = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAsteriscoMarProd = new System.Windows.Forms.Label();
            this.lblAsteriscoNomProd = new System.Windows.Forms.Label();
            this.lblAsteriscoNoSerie = new System.Windows.Forms.Label();
            this.lblAsteriscoTipoProd = new System.Windows.Forms.Label();
            this.lblAsteriscoColaborador = new System.Windows.Forms.Label();
            this.lblAsteriscoAreaOficina = new System.Windows.Forms.Label();
            this.lblAsteriscoNoOficina = new System.Windows.Forms.Label();
            this.cbxColaborador = new System.Windows.Forms.ComboBox();
            this.cbxAreaOficina = new System.Windows.Forms.ComboBox();
            this.cbxTipoProducto = new System.Windows.Forms.ComboBox();
            this.tbxMarcaProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxNombreProducto = new System.Windows.Forms.TextBox();
            this.tbxNoSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxNoOficina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxRegresar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aceptarDenegarSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProveedores.Location = new System.Drawing.Point(13, 123);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.Size = new System.Drawing.Size(1098, 289);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // tbxBuscar
            // 
            this.tbxBuscar.Location = new System.Drawing.Point(370, 89);
            this.tbxBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBuscar.Name = "tbxBuscar";
            this.tbxBuscar.Size = new System.Drawing.Size(336, 22);
            this.tbxBuscar.TabIndex = 1;
            this.tbxBuscar.TextChanged += new System.EventHandler(this.tbxBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(13, 89);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(176, 25);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar por campo:";
            // 
            // cbxBuscarColumna
            // 
            this.cbxBuscarColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscarColumna.FormattingEnabled = true;
            this.cbxBuscarColumna.Items.AddRange(new object[] {
            "Número Oficina",
            "Área Oficina",
            "Colaborador",
            "Tipo Producto",
            "Número Serie",
            "Nombre Producto",
            "Marca Producto"});
            this.cbxBuscarColumna.Location = new System.Drawing.Point(201, 89);
            this.cbxBuscarColumna.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBuscarColumna.Name = "cbxBuscarColumna";
            this.cbxBuscarColumna.Size = new System.Drawing.Size(160, 24);
            this.cbxBuscarColumna.TabIndex = 3;
            this.cbxBuscarColumna.SelectedIndexChanged += new System.EventHandler(this.cbxBuscarColumna_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAsteriscoMarProd);
            this.groupBox1.Controls.Add(this.lblAsteriscoNomProd);
            this.groupBox1.Controls.Add(this.lblAsteriscoNoSerie);
            this.groupBox1.Controls.Add(this.lblAsteriscoTipoProd);
            this.groupBox1.Controls.Add(this.lblAsteriscoColaborador);
            this.groupBox1.Controls.Add(this.lblAsteriscoAreaOficina);
            this.groupBox1.Controls.Add(this.lblAsteriscoNoOficina);
            this.groupBox1.Controls.Add(this.cbxColaborador);
            this.groupBox1.Controls.Add(this.cbxAreaOficina);
            this.groupBox1.Controls.Add(this.cbxTipoProducto);
            this.groupBox1.Controls.Add(this.tbxMarcaProducto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxNombreProducto);
            this.groupBox1.Controls.Add(this.tbxNoSerie);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.tbxNoOficina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 420);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1093, 360);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAsteriscoMarProd
            // 
            this.lblAsteriscoMarProd.AutoSize = true;
            this.lblAsteriscoMarProd.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoMarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoMarProd.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoMarProd.Location = new System.Drawing.Point(485, 199);
            this.lblAsteriscoMarProd.Name = "lblAsteriscoMarProd";
            this.lblAsteriscoMarProd.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoMarProd.TabIndex = 60;
            this.lblAsteriscoMarProd.Text = "*";
            // 
            // lblAsteriscoNomProd
            // 
            this.lblAsteriscoNomProd.AutoSize = true;
            this.lblAsteriscoNomProd.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNomProd.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoNomProd.Location = new System.Drawing.Point(499, 122);
            this.lblAsteriscoNomProd.Name = "lblAsteriscoNomProd";
            this.lblAsteriscoNomProd.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoNomProd.TabIndex = 59;
            this.lblAsteriscoNomProd.Text = "*";
            // 
            // lblAsteriscoNoSerie
            // 
            this.lblAsteriscoNoSerie.AutoSize = true;
            this.lblAsteriscoNoSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoNoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNoSerie.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoNoSerie.Location = new System.Drawing.Point(428, 40);
            this.lblAsteriscoNoSerie.Name = "lblAsteriscoNoSerie";
            this.lblAsteriscoNoSerie.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoNoSerie.TabIndex = 58;
            this.lblAsteriscoNoSerie.Text = "*";
            // 
            // lblAsteriscoTipoProd
            // 
            this.lblAsteriscoTipoProd.AutoSize = true;
            this.lblAsteriscoTipoProd.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoTipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoTipoProd.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoTipoProd.Location = new System.Drawing.Point(156, 199);
            this.lblAsteriscoTipoProd.Name = "lblAsteriscoTipoProd";
            this.lblAsteriscoTipoProd.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoTipoProd.TabIndex = 57;
            this.lblAsteriscoTipoProd.Text = "*";
            // 
            // lblAsteriscoColaborador
            // 
            this.lblAsteriscoColaborador.AutoSize = true;
            this.lblAsteriscoColaborador.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoColaborador.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoColaborador.Location = new System.Drawing.Point(145, 283);
            this.lblAsteriscoColaborador.Name = "lblAsteriscoColaborador";
            this.lblAsteriscoColaborador.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoColaborador.TabIndex = 55;
            this.lblAsteriscoColaborador.Text = "*";
            // 
            // lblAsteriscoAreaOficina
            // 
            this.lblAsteriscoAreaOficina.AutoSize = true;
            this.lblAsteriscoAreaOficina.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoAreaOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoAreaOficina.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoAreaOficina.Location = new System.Drawing.Point(145, 122);
            this.lblAsteriscoAreaOficina.Name = "lblAsteriscoAreaOficina";
            this.lblAsteriscoAreaOficina.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoAreaOficina.TabIndex = 56;
            this.lblAsteriscoAreaOficina.Text = "*";
            // 
            // lblAsteriscoNoOficina
            // 
            this.lblAsteriscoNoOficina.AutoSize = true;
            this.lblAsteriscoNoOficina.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoNoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNoOficina.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoNoOficina.Location = new System.Drawing.Point(130, 40);
            this.lblAsteriscoNoOficina.Name = "lblAsteriscoNoOficina";
            this.lblAsteriscoNoOficina.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoNoOficina.TabIndex = 55;
            this.lblAsteriscoNoOficina.Text = "*";
            // 
            // cbxColaborador
            // 
            this.cbxColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColaborador.FormattingEnabled = true;
            this.cbxColaborador.Location = new System.Drawing.Point(20, 311);
            this.cbxColaborador.Name = "cbxColaborador";
            this.cbxColaborador.Size = new System.Drawing.Size(580, 33);
            this.cbxColaborador.TabIndex = 27;
            this.cbxColaborador.SelectedIndexChanged += new System.EventHandler(this.cbxColaborador_SelectedIndexChanged);
            // 
            // cbxAreaOficina
            // 
            this.cbxAreaOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAreaOficina.FormattingEnabled = true;
            this.cbxAreaOficina.Location = new System.Drawing.Point(20, 150);
            this.cbxAreaOficina.Name = "cbxAreaOficina";
            this.cbxAreaOficina.Size = new System.Drawing.Size(267, 33);
            this.cbxAreaOficina.TabIndex = 26;
            this.cbxAreaOficina.SelectedIndexChanged += new System.EventHandler(this.cbxAreaOficina_SelectedIndexChanged);
            // 
            // cbxTipoProducto
            // 
            this.cbxTipoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoProducto.FormattingEnabled = true;
            this.cbxTipoProducto.Items.AddRange(new object[] {
            "CPU",
            "MONITOR",
            "MOUSE",
            "IMPRESORA",
            "TECLADO",
            "MODEM"});
            this.cbxTipoProducto.Location = new System.Drawing.Point(20, 228);
            this.cbxTipoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoProducto.Name = "cbxTipoProducto";
            this.cbxTipoProducto.Size = new System.Drawing.Size(267, 33);
            this.cbxTipoProducto.TabIndex = 25;
            this.cbxTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cbxTipoProducto_SelectedIndexChanged);
            // 
            // tbxMarcaProducto
            // 
            this.tbxMarcaProducto.Location = new System.Drawing.Point(333, 228);
            this.tbxMarcaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMarcaProducto.MaxLength = 15;
            this.tbxMarcaProducto.Name = "tbxMarcaProducto";
            this.tbxMarcaProducto.Size = new System.Drawing.Size(267, 30);
            this.tbxMarcaProducto.TabIndex = 10;
            this.tbxMarcaProducto.TextChanged += new System.EventHandler(this.tbxMarcaProducto_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Marca Producto";
            // 
            // tbxNombreProducto
            // 
            this.tbxNombreProducto.Location = new System.Drawing.Point(333, 150);
            this.tbxNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombreProducto.MaxLength = 50;
            this.tbxNombreProducto.Name = "tbxNombreProducto";
            this.tbxNombreProducto.Size = new System.Drawing.Size(267, 30);
            this.tbxNombreProducto.TabIndex = 9;
            this.tbxNombreProducto.TextChanged += new System.EventHandler(this.tbxNombreProducto_TextChanged);
            // 
            // tbxNoSerie
            // 
            this.tbxNoSerie.Location = new System.Drawing.Point(333, 69);
            this.tbxNoSerie.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNoSerie.MaxLength = 9;
            this.tbxNoSerie.Name = "tbxNoSerie";
            this.tbxNoSerie.Size = new System.Drawing.Size(267, 30);
            this.tbxNoSerie.TabIndex = 8;
            this.tbxNoSerie.TextChanged += new System.EventHandler(this.tbxNoSerie_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nombre Producto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "No. Serie";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(873, 298);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 46);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(873, 233);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(200, 46);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(873, 166);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 46);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxNoOficina
            // 
            this.tbxNoOficina.Location = new System.Drawing.Point(20, 69);
            this.tbxNoOficina.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNoOficina.MaxLength = 10;
            this.tbxNoOficina.Name = "tbxNoOficina";
            this.tbxNoOficina.Size = new System.Drawing.Size(267, 30);
            this.tbxNoOficina.TabIndex = 0;
            this.tbxNoOficina.TextChanged += new System.EventHandler(this.tbxNoOficina_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "No. Oficina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Colaborador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Área Oficina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Producto";
            // 
            // pbxRegresar
            // 
            this.pbxRegresar.BackColor = System.Drawing.Color.Transparent;
            this.pbxRegresar.Image = global::PermisosVacacionales.Properties.Resources.punta_de_flecha_izquierda_en_un_circulo;
            this.pbxRegresar.Location = new System.Drawing.Point(13, 36);
            this.pbxRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.pbxRegresar.Name = "pbxRegresar";
            this.pbxRegresar.Size = new System.Drawing.Size(53, 49);
            this.pbxRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRegresar.TabIndex = 53;
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
            this.agregarColaboradoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 28);
            this.menuStrip1.TabIndex = 54;
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
            // agregarColaboradoresToolStripMenuItem
            // 
            this.agregarColaboradoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarColaboradoresToolStripMenuItem.Name = "agregarColaboradoresToolStripMenuItem";
            this.agregarColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.agregarColaboradoresToolStripMenuItem.Text = "Agregar Colaboradores";
            this.agregarColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.agregarColaboradoresToolStripMenuItem_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 793);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbxRegresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxBuscarColumna);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbxBuscar);
            this.Controls.Add(this.dgvProveedores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProveedores_FormClosed);
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRegresar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox tbxBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cbxBuscarColumna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxNoOficina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox tbxMarcaProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxNombreProducto;
        private System.Windows.Forms.TextBox tbxNoSerie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxTipoProducto;
        private System.Windows.Forms.PictureBox pbxRegresar;
        private System.Windows.Forms.ComboBox cbxColaborador;
        private System.Windows.Forms.ComboBox cbxAreaOficina;
        private System.Windows.Forms.Label lblAsteriscoMarProd;
        private System.Windows.Forms.Label lblAsteriscoNomProd;
        private System.Windows.Forms.Label lblAsteriscoNoSerie;
        private System.Windows.Forms.Label lblAsteriscoTipoProd;
        private System.Windows.Forms.Label lblAsteriscoColaborador;
        private System.Windows.Forms.Label lblAsteriscoAreaOficina;
        private System.Windows.Forms.Label lblAsteriscoNoOficina;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarVacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aceptarDenegarSolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarColaboradoresToolStripMenuItem;
    }
}