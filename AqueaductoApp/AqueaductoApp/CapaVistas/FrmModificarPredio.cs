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
    public partial class FrmModificarPredio : Form
    {
        int estado;
        int id;
        int posicion;

        public FrmModificarPredio()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtCatastro.Text == "")
            {
                MessageBox.Show("Digite el Catastro del Predio", "Notificaciòn");
            }
            else
            {
                if (this.txtCedula.Text == "")
                {
                    MessageBox.Show("Digite la Cédula del Propietario", "Notificación");
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
                            MessageBox.Show("Digite el Estrato del Predio", "Notificación");
                        }
                        else
                        {
                            if (this.comboEstado.Text == "")
                            {
                                MessageBox.Show("Digite el Estado del Predio", "Notificación");
                            }
                            else
                            {

                                int cedula = int.Parse(this.txtCedula.Text);
                                //Casa
                                CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter TPR = new CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
                                TPR.ModificarPredio(this.txtCatastro.Text, this.comboEstrato.Text, this.comboBarrio.Text, estado, id);


                                //Mensaje de Modificado Predio, limpia los campos. 
                                MessageBox.Show("Predio modificado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txtCatastro.Text = "";

                            }
                        }
                    }
                }
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCedula.Text = "";
                this.txtCatastro.Text = "";

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter Tp = new CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            CapaDatos.DataSet1.PREDIOSDataTable tp = Tp.GetData();
            GridPredio.DataSource = tp;
        }

        private void GridPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            posicion = GridPredio.CurrentRow.Index;

            id = int.Parse(GridPredio.CurrentRow.Cells[0].Value.ToString());
            string catastro = GridPredio.CurrentRow.Cells[1].Value.ToString();
            this.txtCatastro.Text = catastro;
            string barrio = GridPredio.CurrentRow.Cells[4].Value.ToString();
            this.comboBarrio.Text = barrio;
            string estrato = GridPredio.CurrentRow.Cells[3].Value.ToString();
            this.comboEstrato.Text = estrato;
            string cedula = GridPredio.CurrentRow.Cells[2].Value.ToString();
            this.txtCedula.Text = cedula;
            string estado = GridPredio.CurrentRow.Cells[5].Value.ToString();
            this.comboEstado.Text = estado;



        }

        private void FrmModificarPredio_Load(object sender, EventArgs e)
        {

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

        private void txtContador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No permite que el Usuario escriba en el campo
            e.Handled = true;
        }
    }
}
