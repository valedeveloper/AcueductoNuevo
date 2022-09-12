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
                        cT.ModificarConsumo(this.labelFecha.Text, consumo, id);


                        //Después de ser modificado
                        MessageBox.Show("Consumo Modificado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtCatastro.Text = "";
                        this.txtConsumo.Text = "";
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


            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter Tp = new CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
            CapaDatos.DataSet1.CONSUMOSDataTable tp = Tp.GetData();
            GridConsumo.DataSource = tp;
        }

        private void FrmModificarLectura_Load(object sender, EventArgs e)
        {

        }

        private void GridConsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(GridConsumo.CurrentRow.Cells[0].Value.ToString());
            catastro = GridConsumo.CurrentRow.Cells[1].Value.ToString();
            this.txtCatastro.Text = catastro;
            string fecha = GridConsumo.CurrentRow.Cells[2].Value.ToString();
            this.labelFecha.Text = fecha;
            string consumo = GridConsumo.CurrentRow.Cells[3].Value.ToString();
            this.txtConsumo.Text = consumo;

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void dateConsumo_ValueChanged(object sender, EventArgs e)
        {
            //    DateTime fecha = new DateTime(2022, 9, 1);
            //    this.labelFecha.Text = fecha.ToString();
            //    this.labelFecha.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            this.labelFecha.Text = fecha.ToString();
            this.labelFecha.Visible = true;



        }
    }
}
