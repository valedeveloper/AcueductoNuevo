using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AqueaductoApp.CapaDatos;
using AqueaductoApp.CapaModelos;

namespace AqueaductoApp.CapaVistas
{
    public partial class FrmAgregarUsuario : Form
    {
        public string cadenaArchivo;

        int rol;
        int estado;
        byte[] photo;
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //abrir archivo 
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFile.Text = dialog.FileName;

                }
            }


        }



        private void textBox5_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBox5_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                txtName.Text = files.First(); //select the first o
        }

        private void combotxtRol_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (this.combotxtRol.Text == "ADMINISTRADOR")
            {
                rol = 1;
            }
            else
            {
                if (this.combotxtRol.Text == "DIGITADOR")
                {
                    rol = 2;
                }
                else
                {
                    rol = 3;
                }
            }
        }



        private void combotxtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

      
        private void button2_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCedula.Text = "";
                this.txtName.Text = "";
                this.txtLastName.Text = "";
                this.txtCorreo.Text = "";
                this.txtTelefono.Text = "";
                this.txtPassword.Text = "";
                this.combotxtRol.Items.Clear();
                this.comboEstado.Items.Clear();
                this.txtFile.Text = "";
                this.pictureUser.Image = null;

            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //abrir archivo 
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    txtFile.Text = dialog.FileName;
                    cadenaArchivo = txtFile.Text;
                    this.pictureUser.Image = Image.FromFile(this.txtFile.Text);


                    //leer una imagen => un objeto de clase Bynari=> Binary a bit (Usamos el tableAdapterUsuario INSERT) =
                    //****** LEER FILE******
                    FileStream stream = new FileStream(this.txtFile.Text, FileMode.Open, FileAccess.Read);
                    /// Leer Archivo stream y convertilo en binario
                    /// 
                    BinaryReader read = new BinaryReader(stream);

                    ///**** Guarda los binary en un archivo de bites
                    ///
                    photo = read.ReadBytes((int)stream.Length);


                }
            }
        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboEstado.Text == "ACTIVO")
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
        }

        private void comboEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter userCedula = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
            int user = (int)userCedula.validarCedulaUser(this.txtCedula.Text);

            if (user==0)
            {

                if (string.IsNullOrEmpty(this.txtName.Text))
                {
                    MessageBox.Show("Digite el Nombre de usuario", "Notificación");
                    txtName.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtLastName.Text))
                    {
                        MessageBox.Show("Digite el Apellido de usuario", "Notificación");
                        txtLastName.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.txtTelefono.Text))
                        {
                            MessageBox.Show("Digite el Teléfono de Usuario", "Notificación");
                            txtTelefono.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.combotxtRol.Text))
                            {
                                MessageBox.Show("Digite el Rol de Usuario", "Notificación");
                                combotxtRol.Focus();
                            }

                            else
                            {
                                if (string.IsNullOrEmpty(this.txtCorreo.Text))
                                {
                                    MessageBox.Show("Digite el Correo de Usuario", "Notificación");
                                    txtCorreo.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(this.txtPassword.Text))
                                    {
                                        MessageBox.Show("Digite la Constraseña de Usuario", "Notificación");
                                        txtPassword.Focus();
                                    }
                                    else
                                    {
                                        if(this.txtFile.Text=="")
                                        {
                                            MessageBox.Show("Insertar una Imagen", "Notificación");
                                        }
                                        else
                                        {

                                            //encriptamos la contraseña
                                            string pass = CapaModelos.Encript.GetSHA256(this.txtPassword.Text);


                                            //ahora insertemos el usuario a la base de datos
                                            //la logica para agragar usuario

                                            //Conexión Desde casa
                                            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                                            tU.InsertarUsuario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, pass, photo, rol, estado, this.txtFile.Text);


                                            //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                            MessageBox.Show("Usuario Agregado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.txtCedula.Text = "";
                                            this.txtName.Text = "";
                                            this.txtLastName.Text = "";
                                            this.txtCorreo.Text = "";
                                            this.txtTelefono.Text = "";
                                            this.txtPassword.Text = "";
                                            this.txtFile.Text = "";
                                            this.pictureUser.Image = null;
                                        }
                                     
                                     }

                                    
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Este usuario ya existe, por favor ingrese otra cédula");
                this.txtCedula.Focus();
            }

        }
    }
}
