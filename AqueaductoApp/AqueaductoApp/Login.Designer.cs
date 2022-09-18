
namespace AqueaductoApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.labelErrorUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picturePass = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Location = new System.Drawing.Point(45, 189);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 20);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(45, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 20);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.Location = new System.Drawing.Point(15, 287);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(229, 29);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(717, 10);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(30, 28);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureClose.TabIndex = 5;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // labelErrorUsuario
            // 
            this.labelErrorUsuario.AutoSize = true;
            this.labelErrorUsuario.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelErrorUsuario.Location = new System.Drawing.Point(45, 318);
            this.labelErrorUsuario.Name = "labelErrorUsuario";
            this.labelErrorUsuario.Size = new System.Drawing.Size(170, 13);
            this.labelErrorUsuario.TabIndex = 6;
            this.labelErrorUsuario.Text = "Usuario y/o Contraseña Incorrecta";
            this.labelErrorUsuario.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picturePass);
            this.panel1.Controls.Add(this.pictureUser);
            this.panel1.Controls.Add(this.labelErrorUsuario);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(253, 100);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(264, 421);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(15, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 2);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(15, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 2);
            this.panel2.TabIndex = 10;
            // 
            // picturePass
            // 
            this.picturePass.Image = ((System.Drawing.Image)(resources.GetObject("picturePass.Image")));
            this.picturePass.Location = new System.Drawing.Point(9, 240);
            this.picturePass.Name = "picturePass";
            this.picturePass.Size = new System.Drawing.Size(26, 26);
            this.picturePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePass.TabIndex = 9;
            this.picturePass.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUser.InitialImage")));
            this.pictureUser.Location = new System.Drawing.Point(13, 184);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(26, 26);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 8;
            this.pictureUser.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Bauhaus 93", 24F);
            this.labelLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLogin.Location = new System.Drawing.Point(80, 130);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(100, 36);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(758, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Label labelErrorUsuario;
        //private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        //private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox picturePass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        #endregion

        private System.Windows.Forms.PictureBox pictureUser;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtPassword;
    }
}