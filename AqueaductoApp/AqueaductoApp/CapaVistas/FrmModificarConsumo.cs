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
    public partial class FrmModificarConsumo : Form
    {
        public FrmModificarConsumo()
        {
            InitializeComponent();
        }

        int id;
        string catastro;
        int month;
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtCatastro.Text))
            {
                MessageBox.Show("Digite el número de catastro");
                txtCatastro.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtConsumo.Text))
                {
                    MessageBox.Show("Digite la fecha del consumo");
                    txtConsumo.Focus();
                }
                else
                {
                   if(string.IsNullOrEmpty(this.labelFecha.Text))
                    {
                        MessageBox.Show("Digite la fecha del consumo", "Notificación");
                   }
                   else
                    {
                        int consumo = int.Parse(this.txtConsumo.Text);

                        CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter cT = new CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
                        cT.ModificarConsumo(this.txtCatastro.Text, this.labelFecha.Text, consumo, month);

                        //Recargar DataGrid
                        CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter Tp = new CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
                        CapaDatos.DataSet1.CONSUMOSDataTable tp = Tp.GetData();
                        GridConsumo.DataSource = tp;


                        //Después de ser modificado
                        MessageBox.Show("Consumo Modificado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtCatastro.Text = "";
                        this.txtConsumo.Text = "";
                        this.labelFecha.Text = "";
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.txtCatastro.Text = "";
                this.txtConsumo.Text = "";
                this.labelFecha.Text = "";

                //Recargar DataGrid
                CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter Tp = new CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
                CapaDatos.DataSet1.CONSUMOSDataTable tp = Tp.GetData();
                GridConsumo.DataSource = tp;


            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Falla en la carga CONSUMO
            CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter consumoTable = new CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
            CapaDatos.DataSet1.CONSUMOSDataTable ta = consumoTable.GetData();
            GridConsumo.DataSource = ta;
        }

 
        private void GridConsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(GridConsumo.CurrentRow.Cells[0].Value.ToString());
            catastro = GridConsumo.CurrentRow.Cells[1].Value.ToString();
            this.txtCatastro.Text = catastro;


            string fecha = GridConsumo.CurrentRow.Cells[2].Value.ToString();
            this.labelFecha.Text = fecha;
            this.labelFecha.Visible = true;


            string consumo = GridConsumo.CurrentRow.Cells[3].Value.ToString();
            this.txtConsumo.Text = consumo;
            this.txtConsumo.Visible = true;
           month =(int)GridConsumo.CurrentRow.Cells[4].Value;

        }

     


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            this.labelFecha.Text = fecha.ToString();
            this.labelFecha.Visible = true;
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

        private void txtConsumo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

      
    }
}
