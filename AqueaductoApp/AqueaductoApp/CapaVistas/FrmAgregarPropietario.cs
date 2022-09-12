using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AqueaductoApp.CapaVistas
{
    public partial class FrmAgregarPropietario : Form
    {

        int estado;
        public FrmAgregarPropietario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCedula.Text))
            {
                MessageBox.Show("Digite la cédula", "Notificación");

            }
            else
            {
                if (string.IsNullOrEmpty(this.txtName.Text))
                {
                    MessageBox.Show("Digite el nombre", "Notificación");
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtTelefono.Text))
                    {
                        MessageBox.Show("Digite el teléfono", "Notificación");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.txtCorreo.Text))
                        {
                            MessageBox.Show("Digite el correo", "Notificación");
                        }
                        else
                        {
                            //CapaDatos.DataSet2TableAdapters.PROPIETARIOSTableAdapter tP = new CapaDatos.DataSet2TableAdapters.PROPIETARIOSTableAdapter();
                            ////tP.InsertarPropietarios(this.txtCedula.Text, this.txtName.Text, this.txtCorreo.Text, this.txtTelefono.Text);

                            MessageBox.Show("Usuario Agregado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtCedula.Text = "";
                            this.txtName.Text = "";
                            this.txtCorreo.Text = "";
                            this.txtTelefono.Text = "";
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCedula.Text = "";
                this.txtName.Text = "";
                this.txtCorreo.Text = "";
                this.txtTelefono.Text = "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtCedula.Text))
            {
                MessageBox.Show("Digite la cédula del propietario", "Notificación");
                this.txtCedula.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtName.Text))
                {
                    MessageBox.Show("Digite el nombre del propietario", "Notificación");
                    this.txtName.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtLastName.Text))
                    {
                        MessageBox.Show("Digite el apellido del propietario");
                        this.txtLastName.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.txtCorreo.Text))
                        {
                            MessageBox.Show("Digite el correo del propietario");
                            this.txtCorreo.Focus();
                        }
                        else
                        {

                            if (string.IsNullOrEmpty(this.txtTelefono.Text))
                            {
                                MessageBox.Show("Digite el teléfono del propietario");
                                this.txtTelefono.Focus();
                            }
                            else
                            {
                                ////Conexión Casa
                                CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter TP = new CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
                                TP.InsertarPropietario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtTelefono.Text, this.txtCorreo.Text, estado);




                                MessageBox.Show("Propietario Agregado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txtCedula.Text = "";
                                this.txtName.Text = "";
                                this.txtLastName.Text = "";
                                this.txtCorreo.Text = "";
                                this.txtTelefono.Text = "";
                            }
                        }
                    }

                }


            }



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
            }
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboEstado.Text == "ACTIVADO")
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

     
    }
} 
