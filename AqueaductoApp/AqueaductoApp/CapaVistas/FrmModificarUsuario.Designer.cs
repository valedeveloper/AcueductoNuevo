
namespace AqueaductoApp.CapaVistas
{
    partial class FrmModificarUsuario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureUser = new AqueaductoApp.CapaModelos.PictureRound();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(297, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 20);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(180, 504);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 20);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Modificar usuario";
            // 
            // GridUser
            // 
            this.GridUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Location = new System.Drawing.Point(19, 138);
            this.GridUser.Name = "GridUser";
            this.GridUser.ReadOnly = true;
            this.GridUser.RowTemplate.Height = 25;
            this.GridUser.Size = new System.Drawing.Size(523, 138);
            this.GridUser.TabIndex = 42;
            this.GridUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cedula Usuario";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(192, 91);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(133, 20);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCedula_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Correo Electrónico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtPassword.Location = new System.Drawing.Point(214, 400);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(287, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Cambiar contraseña si así lo desea, de lo contrario, NO.";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Agregue una Foto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(435, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFile
            // 
            this.txtFile.AllowDrop = true;
            this.txtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtFile.Location = new System.Drawing.Point(61, 465);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(358, 20);
            this.txtFile.TabIndex = 53;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtCorreo.Location = new System.Drawing.Point(213, 351);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(289, 20);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Rol de usuario";
            // 
            // comboRol
            // 
            this.comboRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.comboRol.DisplayMember = "dDD";
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "DIGITADOR",
            "FACTURADOR"});
            this.comboRol.Location = new System.Drawing.Point(213, 306);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(111, 21);
            this.comboRol.TabIndex = 5;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.combotxtRol_SelectedIndexChanged);
            this.comboRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combotxtRol_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtTelefono.Location = new System.Drawing.Point(61, 400);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtLastName.Location = new System.Drawing.Point(61, 355);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(135, 20);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.txtName.Location = new System.Drawing.Point(61, 306);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(224)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboEstado.Location = new System.Drawing.Point(363, 306);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(139, 21);
            this.comboEstado.TabIndex = 10;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            this.comboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEstado_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Estado Usuario";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.HotPink;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(345, 91);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(74, 20);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(34, 98);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 67;
            // 
            // pictureUser
            // 
            this.pictureUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureUser.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureUser.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureUser.BorderSize = 2;
            this.pictureUser.GradientAngle = 50F;
            this.pictureUser.Location = new System.Drawing.Point(435, 12);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(98, 98);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 43;
            this.pictureUser.TabStop = false;
            this.pictureUser.Click += new System.EventHandler(this.pictureUser_Click);
            // 
            // FrmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 547);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.GridUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarUsuario";
            this.Text = "Modificar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridUser;
        private CapaModelos.PictureRound pictureUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label labelID;
    }
}