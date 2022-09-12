
namespace AqueaductoApp.CapaVistas
{
    partial class FrmagregarPredio
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
            this.labelAgregarPredio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.labelBarrio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.comboBarrio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.GridPredio = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAgregarPredio
            // 
            this.labelAgregarPredio.AutoSize = true;
            this.labelAgregarPredio.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAgregarPredio.Location = new System.Drawing.Point(74, 84);
            this.labelAgregarPredio.Name = "labelAgregarPredio";
            this.labelAgregarPredio.Size = new System.Drawing.Size(231, 29);
            this.labelAgregarPredio.TabIndex = 21;
            this.labelAgregarPredio.Text = "Agregar Predios";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(350, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(211, 575);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 30);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtCedula.Location = new System.Drawing.Point(328, 151);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(161, 23);
            this.txtCedula.TabIndex = 51;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // labelBarrio
            // 
            this.labelBarrio.AutoSize = true;
            this.labelBarrio.Location = new System.Drawing.Point(395, 418);
            this.labelBarrio.Name = "labelBarrio";
            this.labelBarrio.Size = new System.Drawing.Size(75, 15);
            this.labelBarrio.TabIndex = 67;
            this.labelBarrio.Text = "Barrio Predio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(428, 504);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 75;
            this.label12.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboEstado.Location = new System.Drawing.Point(495, 496);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(106, 23);
            this.comboEstado.TabIndex = 74;
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "Estrato ";
            // 
            // comboEstrato
            // 
            this.comboEstrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboEstrato.Location = new System.Drawing.Point(495, 451);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(106, 23);
            this.comboEstrato.TabIndex = 76;
            this.comboEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstrato_KeyPress);
            // 
            // comboBarrio
            // 
            this.comboBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.comboBarrio.FormattingEnabled = true;
            this.comboBarrio.Items.AddRange(new object[] {
            "Colombia",
            "Colombina",
            "San Pedro",
            "Sembrador",
            "Petruc",
            "Independencia",
            "Las Flores"});
            this.comboBarrio.Location = new System.Drawing.Point(495, 410);
            this.comboBarrio.Name = "comboBarrio";
            this.comboBarrio.Size = new System.Drawing.Size(106, 23);
            this.comboBarrio.TabIndex = 78;
            this.comboBarrio.SelectedIndexChanged += new System.EventHandler(this.comboBarrio_SelectedIndexChanged);
            this.comboBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBarrio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Número del Catastro";
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtCatastro.Location = new System.Drawing.Point(200, 434);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.Size = new System.Drawing.Size(161, 23);
            this.txtCatastro.TabIndex = 80;
            // 
            // GridPredio
            // 
            this.GridPredio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.GridPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPredio.Location = new System.Drawing.Point(74, 191);
            this.GridPredio.Name = "GridPredio";
            this.GridPredio.RowTemplate.Height = 25;
            this.GridPredio.Size = new System.Drawing.Size(528, 142);
            this.GridPredio.TabIndex = 81;
            this.GridPredio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPredio_CellContentClick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(527, 151);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 82;
            this.iconButton1.Text = "Buscar Propietario";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "Cédula Propietario";
            // 
            // FrmagregarPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 670);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.GridPredio);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBarrio);
            this.Controls.Add(this.comboEstrato);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBarrio);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelAgregarPredio);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmagregarPredio";
            this.Text = "Agregar Propietario";
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAgregarPredio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label labelBarrio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEstrato;
        private System.Windows.Forms.ComboBox comboBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatastro;
        private System.Windows.Forms.DataGridView GridPredio;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
    }
}