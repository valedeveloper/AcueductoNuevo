
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuFacturador));
            this.panelItem = new System.Windows.Forms.Panel();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panelSubmenuFactura = new System.Windows.Forms.Panel();
            this.btnModificarFactura = new FontAwesome.Sharp.IconButton();
            this.btnNuevaFactura = new FontAwesome.Sharp.IconButton();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.pictureRound1 = new AqueaductoApp.CapaModelos.PictureRound();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panelItem.SuspendLayout();
            this.panelSubmenuFactura.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.panelItem.Controls.Add(this.btnReportes);
            this.panelItem.Controls.Add(this.panelSubmenuFactura);
            this.panelItem.Controls.Add(this.btnFactura);
            this.panelItem.Controls.Add(this.panelUsuario);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(195, 624);
            this.panelItem.TabIndex = 1;
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
            this.btnReportes.IconSize = 30;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 207);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnReportes.Size = new System.Drawing.Size(195, 39);
            this.btnReportes.TabIndex = 24;
            this.btnReportes.Text = "Imprimir";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // panelSubmenuFactura
            // 
            this.panelSubmenuFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panelSubmenuFactura.Controls.Add(this.btnModificarFactura);
            this.panelSubmenuFactura.Controls.Add(this.btnNuevaFactura);
            this.panelSubmenuFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuFactura.Location = new System.Drawing.Point(0, 126);
            this.panelSubmenuFactura.Name = "panelSubmenuFactura";
            this.panelSubmenuFactura.Size = new System.Drawing.Size(195, 81);
            this.panelSubmenuFactura.TabIndex = 0;
            this.panelSubmenuFactura.Visible = false;
            // 
            // btnModificarFactura
            // 
            this.btnModificarFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarFactura.FlatAppearance.BorderSize = 0;
            this.btnModificarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFactura.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModificarFactura.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnModificarFactura.IconColor = System.Drawing.Color.Gainsboro;
            this.btnModificarFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarFactura.IconSize = 30;
            this.btnModificarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFactura.Location = new System.Drawing.Point(0, 39);
            this.btnModificarFactura.Name = "btnModificarFactura";
            this.btnModificarFactura.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnModificarFactura.Size = new System.Drawing.Size(195, 39);
            this.btnModificarFactura.TabIndex = 5;
            this.btnModificarFactura.Text = "Modificar Factura";
            this.btnModificarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarFactura.UseVisualStyleBackColor = true;
            this.btnModificarFactura.Click += new System.EventHandler(this.btnModificarFactura_Click);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaFactura.FlatAppearance.BorderSize = 0;
            this.btnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaFactura.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnNuevaFactura.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaFactura.IconSize = 30;
            this.btnNuevaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFactura.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
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
            this.btnFactura.Location = new System.Drawing.Point(0, 87);
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
            this.panelUsuario.Size = new System.Drawing.Size(195, 87);
            this.panelUsuario.TabIndex = 1;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRol.Location = new System.Drawing.Point(87, 56);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(58, 13);
            this.labelRol.TabIndex = 4;
            this.labelRol.Text = "Facturador";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNombre.Location = new System.Drawing.Point(93, 43);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
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
            this.pictureRound1.Location = new System.Drawing.Point(15, 11);
            this.pictureRound1.Name = "pictureRound1";
            this.pictureRound1.Size = new System.Drawing.Size(64, 64);
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
            this.panelTop.Size = new System.Drawing.Size(563, 43);
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
            this.panelDerecho.Size = new System.Drawing.Size(563, 581);
            this.panelDerecho.TabIndex = 3;
            // 
            // menuFacturador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 624);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuFacturador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturador";
            this.panelItem.ResumeLayout(false);
            this.panelSubmenuFactura.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRound1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Panel panelSubmenuFactura;
        private FontAwesome.Sharp.IconButton btnModificarFactura;
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
    }
}