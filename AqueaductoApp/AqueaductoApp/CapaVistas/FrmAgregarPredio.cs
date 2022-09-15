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
    public partial class FrmagregarPredio : Form
    {
        int id;
        int estado;
       
        public FrmagregarPredio()
        {
            InitializeComponent();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter prediosExist = new CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            int predioExistencia = (int)prediosExist.validarExistenciaCatastro(this.txtCatastro.Text);

            if(predioExistencia==0)
            {
                if (this.txtCedula.Text == "")
                {
                    MessageBox.Show("Digite la Cédula del Propietario", "Notificaciòn");
                }
                else
                {
                    if (this.comboBarrio.Text == "")
                    {
                        MessageBox.Show("Digite el Barrio del Predio", "Notificación");
                    }
                    else
                    {
                        if (this.comboEstrato.Text == "")
                        {
                            MessageBox.Show("Digite el Estrato del Predio");
                        }
                        else
                        {
                            if (this.comboEstado.Text == "")
                            {
                                MessageBox.Show("Digite el Estado del Predio");
                            }
                            else
                            {
                                int cedula = int.Parse(this.txtCedula.Text);

                                //Casa
                                CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter TPR = new CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
                                TPR.InsertarPredio(this.txtCatastro.Text, this.txtCedula.Text, this.comboEstrato.Text, this.comboBarrio.Text, estado);



                                //Recarfar Data Grid
                                CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter dP = new CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
                                CapaDatos.DataSet1.PROPIETARIOSDataTable tp = dP.GetData();
                                GridPropietario.DataSource = tp;


                                //Mensaje despuès de agregado
                                MessageBox.Show("Predio Agregado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txtCedula.Text = "";
                                this.txtCatastro.Text = "";


                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Este predio ya existe, por favor ingrese otro número de catastro");
                this.txtCedula.Focus();
            }

        }

        private void comboEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCedula.Text = "";
                this.txtCedula.Clear();



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

        private void comboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter dP = new CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
            CapaDatos.DataSet1.PROPIETARIOSDataTable tp = dP.GetData();
            GridPropietario.DataSource = tp;
        }

        private void GridPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = GridPropietario.CurrentRow.Index;
            string id = GridPropietario.CurrentRow.Cells[0].Value.ToString();
            string cedula = GridPropietario.CurrentRow.Cells[1].Value.ToString();
            this.txtCedula.Text = cedula;

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            



            //Mensaje de Cancelado
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter prediosExist = new CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
                int predioExistencia = (int)prediosExist.validarExistenciaCatastro(this.txtCatastro.Text);

                this.txtCedula.Text = "";
                this.txtCatastro.Text = "";

                //Recarfar Data Grid
                CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter dP = new CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
                CapaDatos.DataSet1.PROPIETARIOSDataTable tp = dP.GetData();
                GridPropietario.DataSource = tp;
            }

        }

        private void comboBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboEstrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCatastro_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
