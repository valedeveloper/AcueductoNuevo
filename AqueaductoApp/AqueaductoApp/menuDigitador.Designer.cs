
namespace AqueaductoApp
{
    partial class menuDigitador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuDigitador));
            this.panelItem = new System.Windows.Forms.Panel();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelSubmenuConsumo = new System.Windows.Forms.Panel();
            this.btnModificarLectura = new FontAwesome.Sharp.IconButton();
            this.btnNuevaLectura = new FontAwesome.Sharp.IconButton();
            this.btnConsumo = new FontAwesome.Sharp.IconButton();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.labelRol = new System.Windows.Forms.Label();
            this.pictureRound1 = new AqueaductoApp.CapaModelos.PictureRound();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.acueductoDataSet = new AqueaductoApp.AcueductoDataSet();
            this.cONSUMOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONSUMOSTableAdapter = new AqueaductoApp.AcueductoDataSetTableAdapters.CONSUMOSTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.AcueductoDataSetTableAdapters.TableAdapterManager();
            this.panelItem.SuspendLayout();
            this.panelSubmenuConsumo.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acueductoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(133)))), ((int)(((byte)(183)))));
            this.panelItem.Controls.Add(this.btnReportes);
            this.panelItem.Controls.Add(this.panelSubmenuConsumo);
            this.panelItem.Controls.Add(this.btnConsumo);
            this.panelItem.Controls.Add(this.panelUsuario);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(215, 690);
            this.panelItem.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.Registered;
            this.btnReportes.IconColor = System.Drawing.SystemColors.Window;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 32;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 310);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnReportes.Size = new System.Drawing.Size(215, 45);
            this.btnReportes.TabIndex = 24;
            this.btnReportes.Text = "Reporte\r\n";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSubmenuConsumo
            // 
            this.panelSubmenuConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelSubmenuConsumo.Controls.Add(this.btnModificarLectura);
            this.panelSubmenuConsumo.Controls.Add(this.btnNuevaLectura);
            this.panelSubmenuConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuConsumo.Location = new System.Drawing.Point(0, 220);
            this.panelSubmenuConsumo.Name = "panelSubmenuConsumo";
            this.panelSubmenuConsumo.Size = new System.Drawing.Size(215, 90);
            this.panelSubmenuConsumo.TabIndex = 0;
            this.panelSubmenuConsumo.Visible = false;
            // 
            // btnModificarLectura
            // 
            this.btnModificarLectura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(223)))));
            this.btnModificarLectura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarLectura.FlatAppearance.BorderSize = 0;
            this.btnModificarLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarLectura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLectura.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificarLectura.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnModificarLectura.IconColor = System.Drawing.SystemColors.Window;
            this.btnModificarLectura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarLectura.IconSize = 30;
            this.btnModificarLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarLectura.Location = new System.Drawing.Point(0, 45);
            this.btnModificarLectura.Name = "btnModificarLectura";
            this.btnModificarLectura.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnModificarLectura.Size = new System.Drawing.Size(215, 45);
            this.btnModificarLectura.TabIndex = 5;
            this.btnModificarLectura.Text = "Modificar Lectura";
            this.btnModificarLectura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarLectura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarLectura.UseVisualStyleBackColor = false;
            this.btnModificarLectura.Click += new System.EventHandler(this.btnModificarLectura_Click);
            // 
            // btnNuevaLectura
            // 
            this.btnNuevaLectura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(223)))));
            this.btnNuevaLectura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaLectura.FlatAppearance.BorderSize = 0;
            this.btnNuevaLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaLectura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaLectura.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNuevaLectura.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnNuevaLectura.IconColor = System.Drawing.SystemColors.Window;
            this.btnNuevaLectura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaLectura.IconSize = 30;
            this.btnNuevaLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaLectura.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaLectura.Name = "btnNuevaLectura";
            this.btnNuevaLectura.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevaLectura.Size = new System.Drawing.Size(215, 45);
            this.btnNuevaLectura.TabIndex = 4;
            this.btnNuevaLectura.Text = "Nueva Lectura";
            this.btnNuevaLectura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaLectura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaLectura.UseVisualStyleBackColor = false;
            this.btnNuevaLectura.Click += new System.EventHandler(this.btnNuevaLectura_Click);
            // 
            // btnConsumo
            // 
            this.btnConsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumo.FlatAppearance.BorderSize = 0;
            this.btnConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConsumo.IconChar = FontAwesome.Sharp.IconChar.FaucetDrip;
            this.btnConsumo.IconColor = System.Drawing.SystemColors.Window;
            this.btnConsumo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsumo.IconSize = 30;
            this.btnConsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumo.Location = new System.Drawing.Point(0, 175);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnConsumo.Size = new System.Drawing.Size(215, 45);
            this.btnConsumo.TabIndex = 2;
            this.btnConsumo.Text = "Consumo";
            this.btnConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsumo.UseVisualStyleBackColor = true;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(133)))), ((int)(((byte)(183)))));
            this.panelUsuario.Controls.Add(this.labelRol);
            this.panelUsuario.Controls.Add(this.pictureRound1);
            this.panelUsuario.Controls.Add(this.labelNombre);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.panelUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(215, 175);
            this.panelUsuario.TabIndex = 1;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(62, 147);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(74, 16);
            this.labelRol.TabIndex = 5;
            this.labelRol.Text = "Digitador";
            // 
            // pictureRound1
            // 
            this.pictureRound1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureRound1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(172)))));
            this.pictureRound1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureRound1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureRound1.BorderSize = 2;
            this.pictureRound1.GradientAngle = 50F;
            this.pictureRound1.Location = new System.Drawing.Point(37, 6);
            this.pictureRound1.Name = "pictureRound1";
            this.pictureRound1.Size = new System.Drawing.Size(120, 120);
            this.pictureRound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRound1.TabIndex = 4;
            this.pictureRound1.TabStop = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(70, 128);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 16);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(133)))), ((int)(((byte)(183)))));
            this.panelTop.Controls.Add(this.pictureMinimize);
            this.panelTop.Controls.Add(this.pictureClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(215, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(553, 43);
            this.panelTop.TabIndex = 1;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(436, 6);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(30, 28);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimize.TabIndex = 10;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(511, 6);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(30, 30);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 2;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(215, 43);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(553, 647);
            this.panelDerecho.TabIndex = 2;
            // 
            // acueductoDataSet
            // 
            this.acueductoDataSet.DataSetName = "AcueductoDataSet";
            this.acueductoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONSUMOSBindingSource
            // 
            this.cONSUMOSBindingSource.DataMember = "CONSUMOS";
            this.cONSUMOSBindingSource.DataSource = this.acueductoDataSet;
            // 
            // cONSUMOSTableAdapter
            // 
            this.cONSUMOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONSUMOSTableAdapter = this.cONSUMOSTableAdapter;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.PREDIOSTableAdapter = null;
            this.tableAdapterManager.PROPIETARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AqueaductoApp.AcueductoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // menuDigitador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 690);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuDigitador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitador";
            this.Load += new System.EventHandler(this.menuDigitador_Load_1);
            this.panelItem.ResumeLayout(false);
            this.panelSubmenuConsumo.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acueductoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSUMOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDerecho;
        private FontAwesome.Sharp.IconButton btnConsumo;
        private System.Windows.Forms.Panel panelSubmenuConsumo;
        private FontAwesome.Sharp.IconButton btnNuevaLectura;
        private FontAwesome.Sharp.IconButton btnModificarLectura;
        private System.Windows.Forms.PictureBox pictureClose;
        private FontAwesome.Sharp.IconButton btnReportes;
        private AcueductoDataSet acueductoDataSet;
        private System.Windows.Forms.BindingSource cONSUMOSBindingSource;
        private AcueductoDataSetTableAdapters.CONSUMOSTableAdapter cONSUMOSTableAdapter;
        private AcueductoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label labelRol;
        private CapaModelos.PictureRound pictureRound1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}