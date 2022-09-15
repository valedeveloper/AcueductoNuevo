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
    public partial class FrmImprimirFactura : Form
    {
        public FrmImprimirFactura()
        {
            InitializeComponent();
        }

        string factEstado;
        string consecutivo;



        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(this.labelConsecutivo.Text=="")
            {
                MessageBox.Show("Ingrese el consecutivo de la Factura");
            }
            else
            {
                CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter facturas = new CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
                facturas.modificarEstadofact(consecutivo);
            }
           
        }

        private void dataGridImprimir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            factEstado = "Pendiente";
            CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter facturasImprimir = new CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
            CapaDatos.DataSet1.FACTURASDataTable facturasDatos = new CapaDatos.DataSet1.FACTURASDataTable();
            facturasDatos = facturasImprimir.VerFacturasImprimirTable(factEstado);
            GridImprimir.DataSource = facturasDatos;

            int posicion = GridImprimir.CurrentRow.Index;
            consecutivo=GridImprimir.CurrentRow.Cells[0].Value.ToString();
            this.labelConsecutivo.Text = consecutivo;
            this.labelConsecutivo.Visible = true;



        }
    }
}
