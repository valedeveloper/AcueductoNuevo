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
    public partial class FrmModificarPropietario : Form
    {
        int id;
        int posicion;
        int estado;
        public FrmModificarPropietario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter TP = new CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
            CapaDatos.DataSet1.PROPIETARIOSDataTable ta = TP.GetData();
            GridPropietario.DataSource = ta;
        }

        private void GridPropietario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = GridPropietario.CurrentRow.Index;

            id = int.Parse(GridPropietario.CurrentRow.Cells[0].Value.ToString());
            string cedula = GridPropietario.CurrentRow.Cells[1].Value.ToString();
            this.txtCedula.Text = cedula;
            string nombre = GridPropietario.CurrentRow.Cells[2].Value.ToString();
            this.txtName.Text = nombre;
            string apellido = GridPropietario.CurrentRow.Cells[3].Value.ToString();
            this.txtLastName.Text = apellido;
            string telefono = GridPropietario.CurrentRow.Cells[4].Value.ToString();
            this.txtTelefono.Text = telefono;
            string correo = GridPropietario.CurrentRow.Cells[5].Value.ToString();
            this.txtCorreo.Text = correo;


        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                                //Casa
                                CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter TP = new CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
                                TP.ModificarPropietario(this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtTelefono.Text, this.txtCorreo.Text, estado, id);



                                MessageBox.Show("Propietario Modificado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancelar_Click(object sender, EventArgs e)
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

       
    }
}
