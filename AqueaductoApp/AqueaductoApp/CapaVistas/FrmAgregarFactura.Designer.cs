
namespace AqueaductoApp.CapaVistas
{
    partial class FrmAgregarFactura
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
            this.labelFactura = new System.Windows.Forms.Label();
            this.GridConsumo = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.labelIdCatratral = new System.Windows.Forms.Label();
            this.GridPredio = new System.Windows.Forms.DataGridView();
            this.btnAgregarFact = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularFac = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.txtEstrato = new System.Windows.Forms.TextBox();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalFactura = new System.Windows.Forms.TextBox();
            this.labelConsecutivo = new System.Windows.Forms.Label();
            this.FechaConsumo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.CodigoDeBarras = new System.Windows.Forms.PictureBox();
            this.pictureQr = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoDeBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQr)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.labelFactura.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFactura.Location = new System.Drawing.Point(48, 35);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(246, 29);
            this.labelFactura.TabIndex = 22;
            this.labelFactura.Text = "Agregar Facturas";
            // 
            // GridConsumo
            // 
            this.GridConsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridConsumo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridConsumo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.GridConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsumo.Location = new System.Drawing.Point(48, 371);
            this.GridConsumo.Name = "GridConsumo";
            this.GridConsumo.RowTemplate.Height = 25;
            this.GridConsumo.Size = new System.Drawing.Size(398, 113);
            this.GridConsumo.TabIndex = 41;
            this.GridConsumo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsumo_CellContentClick);
            this.GridConsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridConsumo_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.HotPink;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(479, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 21);
            this.btnBuscar.TabIndex = 65;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtCatastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCatastro.Location = new System.Drawing.Point(211, 101);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.Size = new System.Drawing.Size(121, 20);
            this.txtCatastro.TabIndex = 64;
            this.txtCatastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatastro_KeyPress);
            // 
            // labelIdCatratral
            // 
            this.labelIdCatratral.AutoSize = true;
            this.labelIdCatratral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelIdCatratral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIdCatratral.Location = new System.Drawing.Point(86, 104);
            this.labelIdCatratral.Name = "labelIdCatratral";
            this.labelIdCatratral.Size = new System.Drawing.Size(101, 13);
            this.labelIdCatratral.TabIndex = 63;
            this.labelIdCatratral.Text = "Número de Catastro";
            // 
            // GridPredio
            // 
            this.GridPredio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPredio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridPredio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.GridPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPredio.Location = new System.Drawing.Point(48, 127);
            this.GridPredio.Name = "GridPredio";
            this.GridPredio.RowTemplate.Height = 25;
            this.GridPredio.Size = new System.Drawing.Size(590, 141);
            this.GridPredio.TabIndex = 71;
            this.GridPredio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPredio_CellContentClick);
            this.GridPredio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridPredio_KeyPress);
            // 
            // btnAgregarFact
            // 
            this.btnAgregarFact.BackColor = System.Drawing.Color.DeepPink;
            this.btnAgregarFact.FlatAppearance.BorderSize = 0;
            this.btnAgregarFact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregarFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregarFact.ForeColor = System.Drawing.Color.MintCream;
            this.btnAgregarFact.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarFact.IconColor = System.Drawing.Color.Black;
            this.btnAgregarFact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarFact.Location = new System.Drawing.Point(223, 552);
            this.btnAgregarFact.Name = "btnAgregarFact";
            this.btnAgregarFact.Size = new System.Drawing.Size(134, 32);
            this.btnAgregarFact.TabIndex = 72;
            this.btnAgregarFact.Text = "Agregar Factura";
            this.btnAgregarFact.UseVisualStyleBackColor = false;
            this.btnAgregarFact.Click += new System.EventHandler(this.btnAgregarFact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(402, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Total";
            // 
            // btnCalcularFac
            // 
            this.btnCalcularFac.BackColor = System.Drawing.Color.Orange;
            this.btnCalcularFac.FlatAppearance.BorderSize = 0;
            this.btnCalcularFac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalcularFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularFac.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalcularFac.ForeColor = System.Drawing.Color.MintCream;
            this.btnCalcularFac.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCalcularFac.IconColor = System.Drawing.Color.Black;
            this.btnCalcularFac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcularFac.Location = new System.Drawing.Point(48, 552);
            this.btnCalcularFac.Name = "btnCalcularFac";
            this.btnCalcularFac.Size = new System.Drawing.Size(134, 32);
            this.btnCalcularFac.TabIndex = 76;
            this.btnCalcularFac.Text = "Calcular Factura";
            this.btnCalcularFac.UseVisualStyleBackColor = false;
            this.btnCalcularFac.Click += new System.EventHandler(this.btnCalcularFac_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.HotPink;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(281, 311);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(75, 23);
            this.iconButton3.TabIndex = 77;
            this.iconButton3.Text = "Buscar";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // txtEstrato
            // 
            this.txtEstrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtEstrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEstrato.Location = new System.Drawing.Point(406, 101);
            this.txtEstrato.Name = "txtEstrato";
            this.txtEstrato.ReadOnly = true;
            this.txtEstrato.Size = new System.Drawing.Size(41, 20);
            this.txtEstrato.TabIndex = 78;
            // 
            // txtMetros
            // 
            this.txtMetros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMetros.Location = new System.Drawing.Point(168, 311);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.ReadOnly = true;
            this.txtMetros.Size = new System.Drawing.Size(85, 20);
            this.txtMetros.TabIndex = 79;
            this.txtMetros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetros_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(349, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Estrato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(50, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Consumo en Metros";
            // 
            // totalFactura
            // 
            this.totalFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.totalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.totalFactura.Location = new System.Drawing.Point(474, 558);
            this.totalFactura.Name = "totalFactura";
            this.totalFactura.ReadOnly = true;
            this.totalFactura.Size = new System.Drawing.Size(165, 26);
            this.totalFactura.TabIndex = 82;
            // 
            // labelConsecutivo
            // 
            this.labelConsecutivo.AutoSize = true;
            this.labelConsecutivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelConsecutivo.Location = new System.Drawing.Point(557, 46);
            this.labelConsecutivo.Name = "labelConsecutivo";
            this.labelConsecutivo.Size = new System.Drawing.Size(16, 15);
            this.labelConsecutivo.TabIndex = 84;
            this.labelConsecutivo.Text = "...";
            this.labelConsecutivo.Visible = false;
            // 
            // FechaConsumo
            // 
            this.FechaConsumo.AutoSize = true;
            this.FechaConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FechaConsumo.ForeColor = System.Drawing.Color.Gainsboro;
            this.FechaConsumo.Location = new System.Drawing.Point(173, 340);
            this.FechaConsumo.Name = "FechaConsumo";
            this.FechaConsumo.Size = new System.Drawing.Size(19, 13);
            this.FechaConsumo.TabIndex = 85;
            this.FechaConsumo.Text = "....";
            this.FechaConsumo.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(470, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 13);
            this.label.TabIndex = 83;
            this.label.Text = "Consecutivo:";
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.Location = new System.Drawing.Point(473, 311);
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            this.CodigoDeBarras.Size = new System.Drawing.Size(165, 87);
            this.CodigoDeBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CodigoDeBarras.TabIndex = 86;
            this.CodigoDeBarras.TabStop = false;
            // 
            // pictureQr
            // 
            this.pictureQr.Location = new System.Drawing.Point(473, 424);
            this.pictureQr.Name = "pictureQr";
            this.pictureQr.Size = new System.Drawing.Size(165, 91);
            this.pictureQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureQr.TabIndex = 87;
            this.pictureQr.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(50, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Fecha Consumo:";
            // 
            // FrmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(668, 631);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureQr);
            this.Controls.Add(this.CodigoDeBarras);
            this.Controls.Add(this.FechaConsumo);
            this.Controls.Add(this.labelConsecutivo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.totalFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.txtEstrato);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnCalcularFac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarFact);
            this.Controls.Add(this.GridPredio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.labelIdCatratral);
            this.Controls.Add(this.GridConsumo);
            this.Controls.Add(this.labelFactura);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarFactura";
            this.Text = "Agregar Factura";
            this.Load += new System.EventHandler(this.FrmAgregarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoDeBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.DataGridView GridConsumo;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtCatastro;
        private System.Windows.Forms.Label labelIdCatratral;
        private System.Windows.Forms.DataGridView GridPredio;
        private FontAwesome.Sharp.IconButton btnAgregarFact;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCalcularFac;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox txtEstrato;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalFactura;
        private System.Windows.Forms.Label labelConsecutivo;
        private System.Windows.Forms.Label FechaConsumo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox CodigoDeBarras;
        private System.Windows.Forms.PictureBox pictureQr;
        private System.Windows.Forms.Label label7;
    }
}