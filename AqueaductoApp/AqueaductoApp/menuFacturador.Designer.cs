
namespace AqueaductoApp
{
    partial class menuFacturador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuFacturador));
            this.panelItem = new System.Windows.Forms.Panel();
            this.panelSubmenuReportes = new System.Windows.Forms.Panel();
            this.btnImpresas = new FontAwesome.Sharp.IconButton();
            this.btnReportePendi = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelSubmenuFactura = new System.Windows.Forms.Panel();
            this.btnImprimirFactura = new FontAwesome.Sharp.IconButton();
            this.btnNuevaFactura = new FontAwesome.Sharp.IconButton();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.pictureRound1 = new AqueaductoApp.CapaModelos.PictureRound();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.fACTURASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AqueaductoApp.CapaDatos.DataSet1();
            this.fACTURASTableAdapter = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
            this.tableAdapterManager = new AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager();
            this.panelItem.SuspendLayout();
            this.panelSubmenuReportes.SuspendLayout();
            this.panelSubmenuFactura.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.panelItem.Controls.Add(this.panelSubmenuReportes);
            this.panelItem.Controls.Add(this.btnReportes);
            this.panelItem.Controls.Add(this.panelSubmenuFactura);
            this.panelItem.Controls.Add(this.btnFactura);
            this.panelItem.Controls.Add(this.panelUsuario);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(195, 690);
            this.panelItem.TabIndex = 1;
            // 
            // panelSubmenuReportes
            // 
            this.panelSubmenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelSubmenuReportes.Controls.Add(this.btnImpresas);
            this.panelSubmenuReportes.Controls.Add(this.btnReportePendi);
            this.panelSubmenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuReportes.Location = new System.Drawing.Point(0, 314);
            this.panelSubmenuReportes.Name = "panelSubmenuReportes";
            this.panelSubmenuReportes.Size = new System.Drawing.Size(195, 81);
            this.panelSubmenuReportes.TabIndex = 25;
            this.panelSubmenuReportes.Visible = false;
            // 
            // btnImpresas
            // 
            this.btnImpresas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImpresas.FlatAppearance.BorderSize = 0;
            this.btnImpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnImpresas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImpresas.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnImpresas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnImpresas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImpresas.IconSize = 30;
            this.btnImpresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresas.Location = new System.Drawing.Point(0, 39);
            this.btnImpresas.Name = "btnImpresas";
            this.btnImpresas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnImpresas.Size = new System.Drawing.Size(195, 39);
            this.btnImpresas.TabIndex = 5;
            this.btnImpresas.Text = "Generadas";
            this.btnImpresas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpresas.UseVisualStyleBackColor = true;
            this.btnImpresas.Click += new System.EventHandler(this.btnImpresas_Click_1);
            // 
            // btnReportePendi
            // 
            this.btnReportePendi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportePendi.FlatAppearance.BorderSize = 0;
            this.btnReportePendi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReportePendi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportePendi.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.btnReportePendi.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReportePendi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportePendi.IconSize = 30;
            this.btnReportePendi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePendi.Location = new System.Drawing.Point(0, 0);
            this.btnReportePendi.Name = "btnReportePendi";
            this.btnReportePendi.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportePendi.Size = new System.Drawing.Size(195, 39);
            this.btnReportePendi.TabIndex = 4;
            this.btnReportePendi.Text = "Pendientes";
            this.btnReportePendi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePendi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePendi.UseVisualStyleBackColor = true;
            this.btnReportePendi.Click += new System.EventHandler(this.btnReportePendi_Click);
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
            this.btnReportes.Location = new System.Drawing.Point(0, 275);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnReportes.Size = new System.Drawing.Size(195, 39);
            this.btnReportes.TabIndex = 24;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSubmenuFactura
            // 
            this.panelSubmenuFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelSubmenuFactura.Controls.Add(this.btnImprimirFactura);
            this.panelSubmenuFactura.Controls.Add(this.btnNuevaFactura);
            this.panelSubmenuFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuFactura.Location = new System.Drawing.Point(0, 194);
            this.panelSubmenuFactura.Name = "panelSubmenuFactura";
            this.panelSubmenuFactura.Size = new System.Drawing.Size(195, 81);
            this.panelSubmenuFactura.TabIndex = 0;
            this.panelSubmenuFactura.Visible = false;
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImprimirFactura.FlatAppearance.BorderSize = 0;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnImprimirFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImprimirFactura.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnImprimirFactura.IconColor = System.Drawing.Color.Gainsboro;
            this.btnImprimirFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirFactura.IconSize = 30;
            this.btnImprimirFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFactura.Location = new System.Drawing.Point(0, 39);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnImprimirFactura.Size = new System.Drawing.Size(195, 39);
            this.btnImprimirFactura.TabIndex = 5;
            this.btnImprimirFactura.Text = "Imprimir Factura";
            this.btnImprimirFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirFactura.UseVisualStyleBackColor = true;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnModificarFactura_Click);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaFactura.FlatAppearance.BorderSize = 0;
            this.btnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaFactura.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnNuevaFactura.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaFactura.IconSize = 30;
            this.btnNuevaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFactura.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevaFactura.Size = new System.Drawing.Size(195, 39);
            this.btnNuevaFactura.TabIndex = 4;
            this.btnNuevaFactura.Text = "Nueva Factura";
            this.btnNuevaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFactura.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnFactura.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFactura.IconSize = 25;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(0, 155);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnFactura.Size = new System.Drawing.Size(195, 39);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.Text = "Factura";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.labelRol);
            this.panelUsuario.Controls.Add(this.labelNombre);
            this.panelUsuario.Controls.Add(this.pictureRound1);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(195, 155);
            this.panelUsuario.TabIndex = 1;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRol.Location = new System.Drawing.Point(47, 124);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(72, 16);
            this.labelRol.TabIndex = 4;
            this.labelRol.Text = "Facturador";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNombre.Location = new System.Drawing.Point(57, 111);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 15);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
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
            this.pictureRound1.TabIndex = 3;
            this.pictureRound1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.panelTop.Controls.Add(this.pictureClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(195, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(573, 43);
            this.panelTop.TabIndex = 2;
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(527, 11);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(24, 22);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(195, 43);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(573, 647);
            this.panelDerecho.TabIndex = 3;
            // 
            // fACTURASBindingSource
            // 
            this.fACTURASBindingSource.DataMember = "FACTURAS";
            this.fACTURASBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTURASTableAdapter
            // 
            this.fACTURASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONSUMOSTableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = this.fACTURASTableAdapter;
            this.tableAdapterManager.PREDIOSTableAdapter = null;
            this.tableAdapterManager.PROPIETARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AqueaductoApp.CapaDatos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // menuFacturador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 690);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuFacturador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturador";
            this.panelItem.ResumeLayout(false);
            this.panelSubmenuReportes.ResumeLayout(false);
            this.panelSubmenuFactura.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Panel panelSubmenuFactura;
        private FontAwesome.Sharp.IconButton btnImprimirFactura;
        private FontAwesome.Sharp.IconButton btnNuevaFactura;
        private FontAwesome.Sharp.IconButton btnFactura;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDerecho;
        private FontAwesome.Sharp.IconButton btnReportes;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelNombre;
        private CapaModelos.PictureRound pictureRound1;
        private System.Windows.Forms.Panel panelSubmenuReportes;
        private FontAwesome.Sharp.IconButton btnImpresas;
        private FontAwesome.Sharp.IconButton btnReportePendi;
        private CapaDatos.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource fACTURASBindingSource;
        private CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter fACTURASTableAdapter;
        private CapaDatos.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}