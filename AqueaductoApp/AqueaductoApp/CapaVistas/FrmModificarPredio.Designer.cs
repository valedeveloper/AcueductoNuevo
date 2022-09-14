
namespace AqueaductoApp.CapaVistas
{

    partial class FrmModificarPredio
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.labelModificarPredio = new System.Windows.Forms.Label();
            this.txtCatastro = new System.Windows.Forms.TextBox();
            this.labelBarrio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCatastral = new System.Windows.Forms.Label();
            this.GridPredio = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.comboBarrio = new System.Windows.Forms.ComboBox();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(305, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(192, 478);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 20);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // labelModificarPredio
            // 
            this.labelModificarPredio.AutoSize = true;
            this.labelModificarPredio.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.labelModificarPredio.Location = new System.Drawing.Point(54, 46);
            this.labelModificarPredio.Name = "labelModificarPredio";
            this.labelModificarPredio.Size = new System.Drawing.Size(246, 29);
            this.labelModificarPredio.TabIndex = 49;
            this.labelModificarPredio.Text = "Modificar Predios";
            // 
            // txtCatastro
            // 
            this.txtCatastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtCatastro.Location = new System.Drawing.Point(278, 103);
            this.txtCatastro.Name = "txtCatastro";
            this.txtCatastro.Size = new System.Drawing.Size(145, 20);
            this.txtCatastro.TabIndex = 1;
            this.txtCatastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatastro_KeyPress);
            // 
            // labelBarrio
            // 
            this.labelBarrio.AutoSize = true;
            this.labelBarrio.Location = new System.Drawing.Point(54, 378);
            this.labelBarrio.Name = "labelBarrio";
            this.labelBarrio.Size = new System.Drawing.Size(67, 13);
            this.labelBarrio.TabIndex = 55;
            this.labelBarrio.Text = "Barrio Predio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cédula Propietario";
            // 
            // labelCatastral
            // 
            this.labelCatastral.AutoSize = true;
            this.labelCatastral.Location = new System.Drawing.Point(169, 107);
            this.labelCatastral.Name = "labelCatastral";
            this.labelCatastral.Size = new System.Drawing.Size(103, 13);
            this.labelCatastral.TabIndex = 50;
            this.labelCatastral.Text = "Número del Catastro";
            // 
            // GridPredio
            // 
            this.GridPredio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.GridPredio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPredio.Location = new System.Drawing.Point(54, 146);
            this.GridPredio.Name = "GridPredio";
            this.GridPredio.RowTemplate.Height = 25;
            this.GridPredio.Size = new System.Drawing.Size(471, 130);
            this.GridPredio.TabIndex = 59;
            this.GridPredio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPredio_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.HotPink;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(445, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 20);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Estrato Predio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(377, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "Estado Usuario";
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboEstado.Location = new System.Drawing.Point(377, 410);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(149, 21);
            this.comboEstado.TabIndex = 68;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress);
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
            this.comboBarrio.Location = new System.Drawing.Point(54, 410);
            this.comboBarrio.Name = "comboBarrio";
            this.comboBarrio.Size = new System.Drawing.Size(149, 21);
            this.comboBarrio.TabIndex = 79;
            this.comboBarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBarrio_KeyPress);
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
            this.comboEstrato.Location = new System.Drawing.Point(377, 341);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(149, 21);
            this.comboEstrato.TabIndex = 80;
            this.comboEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstrato_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtCedula.Location = new System.Drawing.Point(54, 341);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(149, 20);
            this.txtCedula.TabIndex = 81;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // FrmModificarPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 547);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.comboEstrato);
            this.Controls.Add(this.comboBarrio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.GridPredio);
            this.Controls.Add(this.txtCatastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBarrio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCatastral);
            this.Controls.Add(this.labelModificarPredio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModificar);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarPredio";
            this.Text = "Modificar Predio";
            ((System.ComponentModel.ISupportInitialize)(this.GridPredio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label labelModificarPredio;
        private System.Windows.Forms.TextBox txtCatastro;
        private System.Windows.Forms.Label labelBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCatastral;
        private System.Windows.Forms.DataGridView GridPredio;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.ComboBox comboBarrio;
        private System.Windows.Forms.ComboBox comboEstrato;
        private System.Windows.Forms.TextBox txtCedula;
    }
}