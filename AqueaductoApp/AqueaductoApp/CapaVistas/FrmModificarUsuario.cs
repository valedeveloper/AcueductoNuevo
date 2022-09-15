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
using AqueaductoApp.CapaModelos;
using AqueaductoApp.CapaDatos;

namespace AqueaductoApp.CapaVistas
{
    public partial class FrmModificarUsuario : Form

    {

        int rol;
        int estado;
        public int id;
        string direccionImg;
        public int posicion;
        byte[] photo;
        byte[] photo2;
        string pass;
        string password;
        string cedula;
        string estadoStri;
        string estadoB;


        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ////Conexión Casa
            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
            CapaDatos.DataSet1.USUARIOSDataTable ta = tU.GetData();
            GridUser.DataSource = ta;
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
           
            
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;

            }
        }

        private void GridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //leer la primera posicion del la celda del grid llamado gridUser***///
            posicion = GridUser.CurrentRow.Index;
            id = int.Parse(GridUser.CurrentRow.Cells[0].Value.ToString());
            photo2 = (byte[])GridUser.CurrentRow.Cells[7].Value;
            //Para colocar imagen en el circulo
            Image newImage = byteArrayToImage(photo2);
            pictureUser.Image = newImage;
             cedula = GridUser.CurrentRow.Cells[1].Value.ToString();
            this.txtCedula.Text = cedula;
            string name = GridUser.CurrentRow.Cells[2].Value.ToString();
            this.txtName.Text = name;
            string Lastname = GridUser.CurrentRow.Cells[3].Value.ToString();
            this.txtLastName.Text = Lastname;
            string correo = GridUser.CurrentRow.Cells[4].Value.ToString();
            this.txtCorreo.Text = correo;
            string telefono = GridUser.CurrentRow.Cells[5].Value.ToString();
            this.txtTelefono.Text = telefono;
          
            password = GridUser.CurrentRow.Cells[6].Value.ToString();
            this.txtPassword.Text = "Cambiar contraseña si así lo desea, de lo contrario, NO.";
          
             direccionImg = GridUser.CurrentRow.Cells[10].Value.ToString();
            this.txtFile.Text = direccionImg;
            

            int rolBase =int.Parse(GridUser.CurrentRow.Cells[8].Value.ToString());
            string rolString;

            if (rolBase== 1)
            {
                rolString = "ADMIN";
                int index = comboRol.FindString(rolString);
                comboRol.SelectedIndex = index;
            }
            else
            {
                if(rolBase == 2)
                {
                    rolString = "DIGITADOR";
                    int index = comboRol.FindString(rolString);
                    comboRol.SelectedIndex = index;
                }
                else
                {
                    rolString = "FACTURADOR";
                    int index = comboRol.FindString(rolString);
                    comboRol.SelectedIndex = index;
                }
               
            }



            estadoB = GridUser.CurrentRow.Cells[9].Value.ToString();
            string estadoStri;
            //Poner el estado en el comboBox
            if (estadoB == "1")
            {
                estadoStri = "ACTIVO";
                int index = comboEstado.FindString(estadoStri);
                comboEstado.SelectedIndex = index;
            }
            else
            {
                estadoStri = "INACTIVO";
                int index = comboEstado.FindString(estadoStri);
                comboEstado.SelectedIndex = index;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //abrir archivo 
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtFile.Text = "";
                    txtFile.Text = dialog.FileName;
                    pictureUser.Image = Image.FromFile(this.txtFile.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCedula.Text = "";
                this.txtName.Text = "";
                this.txtLastName.Text = "";
                this.txtCorreo.Text = "";
                this.txtTelefono.Text = "";
                this.txtPassword.Text = "";
                this.txtFile.Text = "";
                this.pictureUser.Image = null;
                this.labelID.Text = null;

                //RecargarDatGrid
                CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                CapaDatos.DataSet1.USUARIOSDataTable ta = tU.GetData();
                GridUser.DataSource = ta;


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter userCedula = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
            int user = (int)userCedula.validarCedulaUser(this.txtCedula.Text);
            if(this.txtCedula.Text==cedula || user==0  )
            {
                if (string.IsNullOrEmpty(this.txtName.Text))
                {
                    MessageBox.Show("Digite su Nombre", "Notificación");
                    txtName.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtLastName.Text))
                    {
                        MessageBox.Show("Digite su Apellido", "Notificación");
                        txtLastName.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.txtTelefono.Text))
                        {
                            MessageBox.Show("Digite su Teléfono", "Notificación");
                            txtTelefono.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.comboRol.Text))
                            {
                                MessageBox.Show("Digite el Rol");
                                comboRol.Focus();
                            }

                            else
                            {
                                if (string.IsNullOrEmpty(this.txtCorreo.Text))
                                {
                                    MessageBox.Show("Digite su Correo");
                                    txtCorreo.Focus();
                                }
                                else
                                {

                                    if (this.txtFile.Text == direccionImg)
                                    {
                                        if (this.txtPassword.Text != "Cambiar contraseña si así lo desea, de lo contrario, NO.")
                                        {
                                            //Encripto de nuevo la contraseña
                                            pass = Encript.GetSHA256(this.txtPassword.Text);


                                            //Query
                                            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                                            tU.ModificarUsuario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, pass, photo2, rol, estado, this.txtFile.Text, id);

                                        }
                                        else
                                        {
                                            pass = password;
                                            //Query
                                            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                                            tU.ModificarUsuario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, pass, photo2, rol, estado, this.txtFile.Text, id);
                                        }
                                    }
                                    else
                                    {
                                        if (this.txtPassword.Text != "Cambiar contraseña si así lo desea, de lo contrario, NO.")
                                        {
                                            pass = Encript.GetSHA256(this.txtPassword.Text);
                                            //Conexión Casa
                                            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                                            tU.ModificarUsuario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, pass, photo, rol, estado, this.txtFile.Text, id);

                                        }
                                        else
                                        {
                                            pass = password;
                                            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                                            tU.ModificarUsuario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, pass, photo, rol, estado, this.txtFile.Text, id);

                                        }

                                    }

                                    //Recargar DataGrid
                                    CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter TU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                                    CapaDatos.DataSet1.USUARIOSDataTable ta = TU.GetData();
                                    GridUser.DataSource = ta;


                                    //Mensaje de Salida para que el usuario sepa que está modificado el Usuario 
                                    MessageBox.Show("Usuario modificado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.txtCedula.Text = "";
                                    this.txtName.Text = "";
                                    this.txtLastName.Text = "";
                                    this.txtCorreo.Text = "";
                                    this.txtTelefono.Text = "";
                                    this.txtPassword.Text = "";
                                    this.txtFile.Text = "";
                                    this.pictureUser.Image = null;
                                    this.labelID.Text = null;
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

        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            //Falta validar correo
        }

        private void combotxtRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRol.Text == "ADMINISTRADOR")
            {
                rol = 1;
            }
            else
            {
                if (comboRol.Text == "DIGITADOR")
                {
                    rol = 2;
                }
                else
                {
                    if (comboRol.Text == "FACTURADOR")
                    {
                        rol = 3;
                    }

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

        private void pictureUser_Click(object sender, EventArgs e)
        {

        }

        private void comboEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combotxtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(this.txtPassword.Text=="")
            {
                this.txtPassword.Text = "Cambiar contraseña si así lo desea, de lo contrario, NO.";
                this.txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Cambiar contraseña si así lo desea, de lo contrario, NO.")
            {
                this.txtPassword.Text = "";
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

     
    }

    internal class read
    {
        internal static byte[] ReadBytes(int length)
        {
            throw new NotImplementedException();
        }
    }
}
