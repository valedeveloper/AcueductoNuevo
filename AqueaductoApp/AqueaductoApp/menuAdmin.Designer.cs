
namespace AqueaductoApp
{
    partial class menuAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.panelsubMenuReportes = new System.Windows.Forms.Panel();
            this.btnReportePredio = new FontAwesome.Sharp.IconButton();
            this.btnReportePropi = new FontAwesome.Sharp.IconButton();
            this.btnReportUser = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelSubmenuPredio = new System.Windows.Forms.Panel();
            this.btnModificarPredio = new FontAwesome.Sharp.IconButton();
            this.btnCrearPredio = new FontAwesome.Sharp.IconButton();
            this.btnPredio = new FontAwesome.Sharp.IconButton();
            this.panelSubmenuCliente = new System.Windows.Forms.Panel();
            this.btnModificarPropietario = new FontAwesome.Sharp.IconButton();
            this.btnCrearPropietario = new FontAwesome.Sharp.IconButton();
            this.btnPropietario = new FontAwesome.Sharp.IconButton();
            this.panelSubmenuUsuario = new System.Windows.Forms.Panel();
            this.btnModificarUsuario = new FontAwesome.Sharp.IconButton();
            this.btnCrearUsuario = new FontAwesome.Sharp.IconButton();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.acueductoDataSet = new AqueaductoApp.AcueductoDataSet();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new AqueaductoApp.AcueductoDataSetTableAdapters.USUARIOSTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.AcueductoDataSetTableAdapters.TableAdapterManager();
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.pROPIETARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROPIETARIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
            this.tableAdapterManager1 = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager();
            this.pREDIOSTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            this.pREDIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pREDIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pREDIOSTableAdapter1 = new AqueaductoApp.AcueductoDataSetTableAdapters.PREDIOSTableAdapter();
            this.pROPIETARIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROPIETARIOSTableAdapter1 = new AqueaductoApp.AcueductoDataSetTableAdapters.PROPIETARIOSTableAdapter();
            this.labelRol = new System.Windows.Forms.Label();
            this.pictureRound1 = new AqueaductoApp.CapaModelos.PictureRound();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelsubMenuReportes.SuspendLayout();
            this.panelSubmenuPredio.SuspendLayout();
            this.panelSubmenuCliente.SuspendLayout();
            this.panelSubmenuUsuario.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acueductoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.btnPropietario);
            this.panel1.Controls.Add(this.panelSubmenuUsuario);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.panelUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 773);
            this.panel1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.panel.Controls.Add(this.panelsubMenuReportes);
            this.panel.Controls.Add(this.btnReportes);
            this.panel.Controls.Add(this.panelSubmenuPredio);
            this.panel.Controls.Add(this.btnPredio);
            this.panel.Controls.Add(this.panelSubmenuCliente);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.Color.LightGray;
            this.panel.Location = new System.Drawing.Point(0, 313);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(171, 460);
            this.panel.TabIndex = 3;
            // 
            // panelsubMenuReportes
            // 
            this.panelsubMenuReportes.AutoSize = true;
            this.panelsubMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelsubMenuReportes.Controls.Add(this.btnReportePredio);
            this.panelsubMenuReportes.Controls.Add(this.btnReportePropi);
            this.panelsubMenuReportes.Controls.Add(this.btnReportUser);
            this.panelsubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubMenuReportes.ForeColor = System.Drawing.Color.LightGray;
            this.panelsubMenuReportes.Location = new System.Drawing.Point(0, 237);
            this.panelsubMenuReportes.Name = "panelsubMenuReportes";
            this.panelsubMenuReportes.Size = new System.Drawing.Size(171, 117);
            this.panelsubMenuReportes.TabIndex = 24;
            this.panelsubMenuReportes.Visible = false;
            // 
            // btnReportePredio
            // 
            this.btnReportePredio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnReportePredio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportePredio.FlatAppearance.BorderSize = 0;
            this.btnReportePredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePredio.ForeColor = System.Drawing.Color.LightGray;
            this.btnReportePredio.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.btnReportePredio.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportePredio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportePredio.IconSize = 30;
            this.btnReportePredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePredio.Location = new System.Drawing.Point(0, 78);
            this.btnReportePredio.Name = "btnReportePredio";
            this.btnReportePredio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportePredio.Size = new System.Drawing.Size(171, 39);
            this.btnReportePredio.TabIndex = 20;
            this.btnReportePredio.Text = "Predios";
            this.btnReportePredio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePredio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePredio.UseVisualStyleBackColor = false;
            this.btnReportePredio.Click += new System.EventHandler(this.btnReportePredio_Click);
            // 
            // btnReportePropi
            // 
            this.btnReportePropi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnReportePropi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportePropi.FlatAppearance.BorderSize = 0;
            this.btnReportePropi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePropi.ForeColor = System.Drawing.Color.LightGray;
            this.btnReportePropi.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnReportePropi.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportePropi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportePropi.IconSize = 30;
            this.btnReportePropi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePropi.Location = new System.Drawing.Point(0, 39);
            this.btnReportePropi.Name = "btnReportePropi";
            this.btnReportePropi.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportePropi.Size = new System.Drawing.Size(171, 39);
            this.btnReportePropi.TabIndex = 19;
            this.btnReportePropi.Text = "Propietarios";
            this.btnReportePropi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePropi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePropi.UseVisualStyleBackColor = false;
            this.btnReportePropi.Click += new System.EventHandler(this.btnReportePropi_Click);
            // 
            // btnReportUser
            // 
            this.btnReportUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnReportUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportUser.FlatAppearance.BorderSize = 0;
            this.btnReportUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportUser.ForeColor = System.Drawing.Color.LightGray;
            this.btnReportUser.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnReportUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportUser.IconSize = 30;
            this.btnReportUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportUser.Location = new System.Drawing.Point(0, 0);
            this.btnReportUser.Name = "btnReportUser";
            this.btnReportUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportUser.Size = new System.Drawing.Size(171, 39);
            this.btnReportUser.TabIndex = 18;
            this.btnReportUser.Text = "Usuarios";
            this.btnReportUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportUser.UseVisualStyleBackColor = false;
            this.btnReportUser.Click += new System.EventHandler(this.btnReportUser_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.Registered;
            this.btnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 32;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 198);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnReportes.Size = new System.Drawing.Size(171, 39);
            this.btnReportes.TabIndex = 23;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSubmenuPredio
            // 
            this.panelSubmenuPredio.AutoSize = true;
            this.panelSubmenuPredio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelSubmenuPredio.Controls.Add(this.btnModificarPredio);
            this.panelSubmenuPredio.Controls.Add(this.btnCrearPredio);
            this.panelSubmenuPredio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuPredio.ForeColor = System.Drawing.Color.LightGray;
            this.panelSubmenuPredio.Location = new System.Drawing.Point(0, 120);
            this.panelSubmenuPredio.Name = "panelSubmenuPredio";
            this.panelSubmenuPredio.Size = new System.Drawing.Size(171, 78);
            this.panelSubmenuPredio.TabIndex = 22;
            this.panelSubmenuPredio.Visible = false;
            // 
            // btnModificarPredio
            // 
            this.btnModificarPredio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnModificarPredio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarPredio.FlatAppearance.BorderSize = 0;
            this.btnModificarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPredio.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificarPredio.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyCrack;
            this.btnModificarPredio.IconColor = System.Drawing.Color.Gainsboro;
            this.btnModificarPredio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarPredio.IconSize = 30;
            this.btnModificarPredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPredio.Location = new System.Drawing.Point(0, 39);
            this.btnModificarPredio.Name = "btnModificarPredio";
            this.btnModificarPredio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnModificarPredio.Size = new System.Drawing.Size(171, 39);
            this.btnModificarPredio.TabIndex = 19;
            this.btnModificarPredio.Text = "Modificar Predio";
            this.btnModificarPredio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPredio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarPredio.UseVisualStyleBackColor = false;
            this.btnModificarPredio.Click += new System.EventHandler(this.btnModificarPredio_Click_1);
            // 
            // btnCrearPredio
            // 
            this.btnCrearPredio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnCrearPredio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearPredio.FlatAppearance.BorderSize = 0;
            this.btnCrearPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPredio.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrearPredio.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck;
            this.btnCrearPredio.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCrearPredio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearPredio.IconSize = 30;
            this.btnCrearPredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPredio.Location = new System.Drawing.Point(0, 0);
            this.btnCrearPredio.Name = "btnCrearPredio";
            this.btnCrearPredio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCrearPredio.Size = new System.Drawing.Size(171, 39);
            this.btnCrearPredio.TabIndex = 18;
            this.btnCrearPredio.Text = "Crear Predio";
            this.btnCrearPredio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPredio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearPredio.UseVisualStyleBackColor = false;
            this.btnCrearPredio.Click += new System.EventHandler(this.btnCrearPredio_Click);
            // 
            // btnPredio
            // 
            this.btnPredio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPredio.FlatAppearance.BorderSize = 0;
            this.btnPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPredio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPredio.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.btnPredio.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPredio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPredio.IconSize = 30;
            this.btnPredio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredio.Location = new System.Drawing.Point(0, 81);
            this.btnPredio.Name = "btnPredio";
            this.btnPredio.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnPredio.Size = new System.Drawing.Size(171, 39);
            this.btnPredio.TabIndex = 21;
            this.btnPredio.Text = "Predio";
            this.btnPredio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPredio.UseVisualStyleBackColor = true;
            this.btnPredio.Click += new System.EventHandler(this.btnPredio_Click);
            // 
            // panelSubmenuCliente
            // 
            this.panelSubmenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelSubmenuCliente.Controls.Add(this.btnModificarPropietario);
            this.panelSubmenuCliente.Controls.Add(this.btnCrearPropietario);
            this.panelSubmenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuCliente.ForeColor = System.Drawing.Color.LightGray;
            this.panelSubmenuCliente.Location = new System.Drawing.Point(0, 0);
            this.panelSubmenuCliente.Name = "panelSubmenuCliente";
            this.panelSubmenuCliente.Size = new System.Drawing.Size(171, 81);
            this.panelSubmenuCliente.TabIndex = 1;
            // 
            // btnModificarPropietario
            // 
            this.btnModificarPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnModificarPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarPropietario.FlatAppearance.BorderSize = 0;
            this.btnModificarPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPropietario.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificarPropietario.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.btnModificarPropietario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnModificarPropietario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarPropietario.IconSize = 30;
            this.btnModificarPropietario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPropietario.Location = new System.Drawing.Point(0, 39);
            this.btnModificarPropietario.Name = "btnModificarPropietario";
            this.btnModificarPropietario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnModificarPropietario.Size = new System.Drawing.Size(171, 39);
            this.btnModificarPropietario.TabIndex = 3;
            this.btnModificarPropietario.Text = "Modificar Propietario";
            this.btnModificarPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPropietario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarPropietario.UseVisualStyleBackColor = false;
            this.btnModificarPropietario.Click += new System.EventHandler(this.btnModificarPropietario_Click);
            // 
            // btnCrearPropietario
            // 
            this.btnCrearPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnCrearPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearPropietario.FlatAppearance.BorderSize = 0;
            this.btnCrearPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPropietario.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrearPropietario.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnCrearPropietario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCrearPropietario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearPropietario.IconSize = 30;
            this.btnCrearPropietario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPropietario.Location = new System.Drawing.Point(0, 0);
            this.btnCrearPropietario.Name = "btnCrearPropietario";
            this.btnCrearPropietario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCrearPropietario.Size = new System.Drawing.Size(171, 39);
            this.btnCrearPropietario.TabIndex = 2;
            this.btnCrearPropietario.Text = "Crear Propietario";
            this.btnCrearPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPropietario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearPropietario.UseVisualStyleBackColor = false;
            this.btnCrearPropietario.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // btnPropietario
            // 
            this.btnPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPropietario.FlatAppearance.BorderSize = 0;
            this.btnPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropietario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPropietario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPropietario.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnPropietario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPropietario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPropietario.IconSize = 30;
            this.btnPropietario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPropietario.Location = new System.Drawing.Point(0, 274);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnPropietario.Size = new System.Drawing.Size(171, 39);
            this.btnPropietario.TabIndex = 2;
            this.btnPropietario.Text = "Propietario";
            this.btnPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPropietario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPropietario.UseVisualStyleBackColor = true;
            this.btnPropietario.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelSubmenuUsuario
            // 
            this.panelSubmenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelSubmenuUsuario.Controls.Add(this.btnModificarUsuario);
            this.panelSubmenuUsuario.Controls.Add(this.btnCrearUsuario);
            this.panelSubmenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.panelSubmenuUsuario.Location = new System.Drawing.Point(0, 194);
            this.panelSubmenuUsuario.Name = "panelSubmenuUsuario";
            this.panelSubmenuUsuario.Size = new System.Drawing.Size(171, 80);
            this.panelSubmenuUsuario.TabIndex = 1;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnModificarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.btnModificarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.btnModificarUsuario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnModificarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarUsuario.IconSize = 30;
            this.btnModificarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.Location = new System.Drawing.Point(0, 39);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnModificarUsuario.Size = new System.Drawing.Size(171, 39);
            this.btnModificarUsuario.TabIndex = 3;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.btnCrearUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnCrearUsuario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCrearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearUsuario.IconSize = 30;
            this.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCrearUsuario.Size = new System.Drawing.Size(171, 39);
            this.btnCrearUsuario.TabIndex = 2;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuario.IconSize = 30;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 155);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnUsuario.Size = new System.Drawing.Size(171, 39);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.AutoScroll = true;
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.panelUsuario.Controls.Add(this.labelRol);
            this.panelUsuario.Controls.Add(this.labelNombre);
            this.panelUsuario.Controls.Add(this.pictureRound1);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(171, 155);
            this.panelUsuario.TabIndex = 0;
            this.panelUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsuario_Paint);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNombre.Location = new System.Drawing.Point(56, 114);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.panelTop.Controls.Add(this.pictureClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(171, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(649, 43);
            this.panelTop.TabIndex = 2;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(613, 10);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(24, 22);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 0;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(171, 43);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(649, 730);
            this.panelDerecho.TabIndex = 3;
            // 
            // acueductoDataSet
            // 
            this.acueductoDataSet.DataSetName = "AcueductoDataSet";
            this.acueductoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.acueductoDataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONSUMOSTableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.PREDIOSTableAdapter = null;
            this.tableAdapterManager.PROPIETARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AqueaductoApp.AcueductoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = this.uSUARIOSTableAdapter;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROPIETARIOSBindingSource
            // 
            this.pROPIETARIOSBindingSource.DataMember = "PROPIETARIOS";
            this.pROPIETARIOSBindingSource.DataSource = this.dataSet1;
            // 
            // pROPIETARIOSTableAdapter
            // 
            this.pROPIETARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CONSUMOSTableAdapter = null;
            this.tableAdapterManager1.FACTURASTableAdapter = null;
            this.tableAdapterManager1.PREDIOSTableAdapter = this.pREDIOSTableAdapter;
            this.tableAdapterManager1.PROPIETARIOSTableAdapter = this.pROPIETARIOSTableAdapter;
            this.tableAdapterManager1.UpdateOrder = AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.USUARIOSTableAdapter = null;
            // 
            // pREDIOSTableAdapter
            // 
            this.pREDIOSTableAdapter.ClearBeforeFill = true;
            // 
            // pREDIOSBindingSource
            // 
            this.pREDIOSBindingSource.DataMember = "PREDIOS";
            this.pREDIOSBindingSource.DataSource = this.dataSet1;
            // 
            // pREDIOSBindingSource1
            // 
            this.pREDIOSBindingSource1.DataMember = "PREDIOS";
            this.pREDIOSBindingSource1.DataSource = this.acueductoDataSet;
            // 
            // pREDIOSTableAdapter1
            // 
            this.pREDIOSTableAdapter1.ClearBeforeFill = true;
            // 
            // pROPIETARIOSBindingSource1
            // 
            this.pROPIETARIOSBindingSource1.DataMember = "PROPIETARIOS";
            this.pROPIETARIOSBindingSource1.DataSource = this.acueductoDataSet;
            // 
            // pROPIETARIOSTableAdapter1
            // 
            this.pROPIETARIOSTableAdapter1.ClearBeforeFill = true;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRol.Location = new System.Drawing.Point(41, 128);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(81, 16);
            this.labelRol.TabIndex = 26;
            this.labelRol.Text = "Administrador";
            // 
            // pictureRound1
            // 
            this.pictureRound1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureRound1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureRound1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureRound1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureRound1.BorderSize = 2;
            this.pictureRound1.GradientAngle = 50F;
            this.pictureRound1.Location = new System.Drawing.Point(29, 10);
            this.pictureRound1.Name = "pictureRound1";
            this.pictureRound1.Size = new System.Drawing.Size(101, 101);
            this.pictureRound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRound1.TabIndex = 0;
            this.pictureRound1.TabStop = false;
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 773);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelsubMenuReportes.ResumeLayout(false);
            this.panelSubmenuPredio.ResumeLayout(false);
            this.panelSubmenuCliente.ResumeLayout(false);
            this.panelSubmenuUsuario.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acueductoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREDIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPIETARIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSubmenuUsuario;
        private FontAwesome.Sharp.IconButton btnModificarUsuario;
        private FontAwesome.Sharp.IconButton btnCrearUsuario;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btnPropietario;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelSubmenuCliente;
        private FontAwesome.Sharp.IconButton btnModificarPropietario;
        private FontAwesome.Sharp.IconButton btnCrearPropietario;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelSubmenuPredio;
        private FontAwesome.Sharp.IconButton btnModificarPredio;
        private FontAwesome.Sharp.IconButton btnCrearPredio;
        private FontAwesome.Sharp.IconButton btnPredio;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Panel panelTop;
        private CapaModelos.PictureRound pictureRound1;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panelsubMenuReportes;
        private FontAwesome.Sharp.IconButton btnReportePredio;
        private FontAwesome.Sharp.IconButton btnReportePropi;
        private FontAwesome.Sharp.IconButton btnReportUser;
        private FontAwesome.Sharp.IconButton btnReportes;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private AcueductoDataSet acueductoDataSet;
        private AcueductoDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private AcueductoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pROPIETARIOSBindingSource;
        private CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter pROPIETARIOSTableAdapter;
        private CapaDatos.DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter pREDIOSTableAdapter;
        private System.Windows.Forms.BindingSource pREDIOSBindingSource;
        private System.Windows.Forms.BindingSource pREDIOSBindingSource1;
        private AcueductoDataSetTableAdapters.PREDIOSTableAdapter pREDIOSTableAdapter1;
        private System.Windows.Forms.BindingSource pROPIETARIOSBindingSource1;
        private AcueductoDataSetTableAdapters.PROPIETARIOSTableAdapter pROPIETARIOSTableAdapter1;
        private System.Windows.Forms.Label labelRol;
    }
}

