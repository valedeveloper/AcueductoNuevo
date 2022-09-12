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

        public int posicion;


        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {

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
            byte[] Img = (byte[])GridUser.CurrentRow.Cells[7].Value;
            Image newImage = byteArrayToImage(Img);
            pictureUser.Image = newImage;
            string cedula = GridUser.CurrentRow.Cells[1].Value.ToString();
            this.txtCedula.Text = cedula;
            string name = GridUser.CurrentRow.Cells[2].Value.ToString();
            this.txtName.Text = name;
            string Lastname = GridUser.CurrentRow.Cells[3].Value.ToString();
            this.txtLastName.Text = Lastname;
            string correo = GridUser.CurrentRow.Cells[4].Value.ToString();
            this.txtCorreo.Text = correo;
            string telefono = GridUser.CurrentRow.Cells[5].Value.ToString();
            this.txtTelefono.Text = telefono;
            string rol = GridUser.CurrentRow.Cells[8].Value.ToString();
            string password = "";
            this.txtPassword.Text = password;
            string estado = GridUser.CurrentRow.Cells[9].Value.ToString();
            id = int.Parse(GridUser.CurrentRow.Cells[0].Value.ToString());
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
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtName.Text = "";
                this.txtLastName.Text = "";
                this.txtCorreo.Text = "";
                this.txtTelefono.Text = "";
                this.txtPassword.Text = "";
                this.combotxtRol.Items.Clear();
                this.txtFile.Text = "";

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                        if (string.IsNullOrEmpty(this.combotxtRol.Text))
                        {
                            MessageBox.Show("Digite el Rol");
                            combotxtRol.Focus();
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
                                if (string.IsNullOrEmpty(this.txtPassword.Text))
                                {
                                    MessageBox.Show("Digite su Constraseña");
                                    txtPassword.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(this.txtFile.Text))
                                    {
                                        MessageBox.Show("Coloque una Foto Nueva");
                                        txtPassword.Focus();

                                    }
                                    else
                                    {
                                        FileStream stream = new FileStream(this.txtFile.Text, FileMode.Open, FileAccess.Read);
                                        /// Leer Archivo stream y convertilo en binario
                                        /// 
                                        BinaryReader read = new BinaryReader(stream);

                                        ///**** Guarda los binary en un archivo de bites
                                        ///
                                        byte[] photo = read.ReadBytes((int)stream.Length);



                                        //encriptamos la contraseña
                                        string pass = Encript.GetSHA256(this.txtPassword.Text);

                                        //Conexión Casa
                                       CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
                                        tU.ModificarUsuario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, pass, photo, rol, estado, id);


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
            if (combotxtRol.Text == "ADMINISTRADOR")
            {
                rol = 1;
            }
            else
            {
                if (combotxtRol.Text == "DIGITADOR")
                {
                    rol = 2;
                }
                else
                {
                    if (combotxtRol.Text == "FACTURADOR")
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

        //private void btnModificar_Click(object sender, EventArgs e)
        //{   
        //    CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter tU = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
        //    tU.update(posicion,this.txtName.Text,this.txtLastName.Text,this.txtCorreo.Text,this.t);
        //}
    }

    internal class read
    {
        internal static byte[] ReadBytes(int length)
        {
            throw new NotImplementedException();
        }
    }
}
