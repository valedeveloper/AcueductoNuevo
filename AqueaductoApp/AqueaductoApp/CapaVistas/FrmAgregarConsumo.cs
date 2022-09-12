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
    public partial class FrmAgregarConsumo : Form
    {
        public FrmAgregarConsumo()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.txtCatastro.Text=="")
            {
                MessageBox.Show("Digite el Número del Catastro","Notificación");
            }
            else
            {
                if(this.txtConsumo.Text=="")
                {
                    MessageBox.Show("Digite el consumo en metros cúbicos","Notificación");
                }
                else
                {
                    if(this.labelFecha.Text=="")
                    {
                        MessageBox.Show("Digite la fecha del consumo", "Notificación");
                    }
                    else
                    {   //VALIDAR QUE SI UN PREDIO TIENE UN CONSUMO EN ESA FECHA NO SE PUEDE AGREGAR DOS CONSUMOS DE UN PREDIO

                        int consumo = int.Parse(this.txtConsumo.Text);
                        CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter cT = new CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
                        cT.InsertarConsumo(this.txtCatastro.Text, this.labelFecha.Text, consumo);
                         
                        // Mensaje de´pués de haber sido agregado el Consumo
                        MessageBox.Show("Consumo Agregado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtCatastro.Text = "";
                        this.txtConsumo.Text = "";

                    }
                }

            }


        }

        private void DataPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = GridPredio.CurrentRow.Index;
            string catastro = GridPredio.CurrentRow.Cells[1].Value.ToString();
            this.txtCatastro.Text = catastro;
            ;


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter Tp = new CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            CapaDatos.DataSet1.PREDIOSDataTable tp = Tp.GetData();
            GridPredio.DataSource = tp;
        }

        private void FrmAgregarLectura_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCatastro.Text = "";
                this.txtConsumo.Text = "";


            }
        }

        private void dateConsumo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            {
                DateTime fecha = dateTimePicker1.Value;
                this.labelFecha.Text = fecha.ToString();
                this.labelFecha.Visible = true;
            }
        }
    }
}
