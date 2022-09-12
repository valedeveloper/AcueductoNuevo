using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AqueaductoApp.CapaDatos;
using AqueaductoApp.CapaModelos;
using AqueaductoApp.CapaVistas;

namespace AqueaductoApp.CapaVistas
{
    public partial class FrmAgregarFactura : Form
    {
        int min;
        int numero;
        int estrato;
        string strato;
        string cedula;
        string namePropietario;
        string celular;
        string correo;
        string barrio;
        int id;
        string estado = "pendiente";
        string consec;
        BigInteger consecutivo;
        byte[] ms;
        byte[] mQr;

        public FrmAgregarFactura()
        {
            InitializeComponent();
        }

        private void GridConsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            id = int.Parse(GridConsumo.CurrentRow.Cells[0].Value.ToString());
            string FechaConsumo = GridConsumo.CurrentRow.Cells[2].Value.ToString();
            this.FechaConsumo.Text = FechaConsumo;
            string catastro = GridConsumo.CurrentRow.Cells[1].Value.ToString();
            min = int.Parse(GridConsumo.CurrentRow.Cells[3].Value.ToString());
            this.txtMetros.Text = min.ToString();
            this.txtCatastro.Text = catastro;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter predios = new CapaDatos.DataSet1TableAdapters.PREDIOSTableAdapter();
            CapaDatos.DataSet1.PREDIOSDataTable predioDatos = predios.GetData();
            GridPredio.DataSource = predioDatos;
        }

        private void GridPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            int posicion = GridPredio.CurrentRow.Index;
            string catastro = GridPredio.CurrentRow.Cells[1].Value.ToString();
            this.txtCatastro.Text = catastro;
            cedula = GridPredio.CurrentRow.Cells[2].Value.ToString();
            strato = GridPredio.CurrentRow.Cells[3].Value.ToString();
            this.txtEstrato.Text = strato;
            barrio = GridPredio.CurrentRow.Cells[4].Value.ToString();



            CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter propietarioDatos = new CapaDatos.DataSet1TableAdapters.PROPIETARIOSTableAdapter();
            namePropietario = propietarioDatos.Traer_Nombre(cedula);
            celular = propietarioDatos.TraerCelular(cedula);
            correo = propietarioDatos.TraerCorreo(cedula);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter consumos = new CapaDatos.DataSet1TableAdapters.CONSUMOSTableAdapter();
            CapaDatos.DataSet1.CONSUMOSDataTable consumoDatos = consumos.ObtenerConsumo(this.txtCatastro.Text);
            GridConsumo.DataSource = consumoDatos;

        }

        private void btnCalcularFac_Click(object sender, EventArgs e)
        {

            if (this.txtCatastro.Text == "")
            {
                MessageBox.Show("Digite el Catastro del Predio");
            }
            else
            {
                if (this.txtEstrato.Text == "")
                {
                    MessageBox.Show("Digite el Estrato del Predio", "Notificación");
                }
                else
                {
                    if (this.txtMetros.Text == "")
                    {
                        MessageBox.Show("Digite el Consumo en Metros Cúbicos", "Notificación");
                    }
                    else
                    {
                        if (this.FechaConsumo.Text == "")
                        {
                            MessageBox.Show("Digite la Fecha del Consumo", "Notificación");
                        }
                        else
                        {
                            // generar codigo de barras
                            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "Acueducto Valle");

                            // establecer resolución
                            generator.Parameters.Resolution = 100;

                            // generar código de barras
                            Image codigoBarras = generator.GenerateBarCodeImage();

                            //mostrar codigo de barras en front end
                            this.CodigoDeBarras.Image = codigoBarras;

                            //convertir codigo Barras en bytes para guardarlos en sql server
                            ClsConvertToArray con = new ClsConvertToArray();

                            ms = con.ImageToByteArray(codigoBarras);


                            ////generar qr
                            BarcodeGenerator generatorQr = new BarcodeGenerator(EncodeTypes.QR, "Acueducto Valle");

                            // establecer QR resolución
                            generator.Parameters.Resolution = 1000;

                            ///mostrar Qr
                            Image codigoQr = generatorQr.GenerateBarCodeImage();

                            //convertir codigo qr en bytes para guardarlos en sql server
                            mQr = con.ImageToByteArray(codigoQr);
                            //mostrar codigo Qr en front end
                            this.pictureQr.Image = codigoQr;

                            // crear consecutivo
                            DateTime currentDateTime = DateTime.Now;
                            int mont = currentDateTime.Month;
                            int day = currentDateTime.Day;
                            int year = currentDateTime.Year;
                            int minutes = currentDateTime.Minute;
                            int millesec = currentDateTime.Millisecond;

                            consec = mont.ToString() + day.ToString() + year.ToString() + minutes.ToString() + millesec.ToString();

                            this.labelConsecutivo.Text = consec;

                            int consumoMetro = int.Parse(txtMetros.Text);
                            //va la logica de negocio
                            if (consumoMetro >= 0 && consumoMetro < 30)
                            {
                                if (estrato == 1)
                                {
                                    this.totalFactura.Text = (2000 * consumoMetro).ToString();
                                }
                                else
                                {
                                    this.totalFactura.Text = (3000 * consumoMetro).ToString();
                                }
                            }
                            else
                            {
                                if (estrato == 1)
                                {
                                    this.totalFactura.Text = (2500 * consumoMetro).ToString();
                                }
                                else
                                {
                                    this.totalFactura.Text = (4000 * consumoMetro).ToString();
                                }
                            }
                            MessageBox.Show("Factura Calculada", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }







        }

        private void btnAgregarFact_Click(object sender, EventArgs e)
        {
            if (this.labelConsecutivo.Text == "" || this.totalFactura.Text == "")
            {
                MessageBox.Show("Faltam datos necesarios para la Factura", "Notificación");
            }
            else
            {

                if (this.CodigoDeBarras.Image == null)
                {
                    MessageBox.Show("Falta Código de Barras");
                }
                else
                {
                    if (this.pictureQr.Image == null)
                    {
                        MessageBox.Show("Falta Código QR");
                    }
                    else
                    {

                        Int64 consecutivoFact = Int64.Parse(consec);


                        CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter facturas = new CapaDatos.DataSet1TableAdapters.FACTURASTableAdapter();
                        facturas.InsertarFactura(consec, this.txtCatastro.Text, this.FechaConsumo.Text, cedula, namePropietario, celular, correo, strato, barrio, id, int.Parse(this.totalFactura.Text), estado, ms, mQr);

                        //Acción luego de ser creada la factura

                        MessageBox.Show("Factura Agregada", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.labelConsecutivo.Text = "";
                        this.txtCatastro.Text = "";
                        this.txtEstrato.Text = "";
                        this.txtMetros.Text = "";
                        this.FechaConsumo.Text = "";
                        this.pictureQr.Image = null;
                        this.CodigoDeBarras.Image = null;
                        this.totalFactura.Text = "";

                    }
                }
            }

        }

        private void txtCatastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMetros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GridPredio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GridConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
