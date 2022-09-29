using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AqueaductoApp.CapaDatos;
using AqueaductoApp.CapaVistas;

namespace AqueaductoApp
{

    public partial class menuFacturador : Form
    {
        string estadoFactura ;
        public menuFacturador(string User,string Password)
        {
            InitializeComponent();
            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter fotoUser = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
            byte[] fotoUsuario = (byte[])fotoUser.traerFoto(User, Password);

            Image imagenUsuario = CapaModelos.ClsConvertToImage.byteArrayToImage(fotoUsuario);
            pictureRound1.Image = imagenUsuario;
            this.labelNombre.Text = User;
        }
        private void hideSubmenu()
        {
            if (panelSubmenuFactura.Visible == true  )
            {
                panelSubmenuFactura.Visible = false;
            }
            if(panelSubmenuReportes.Visible==true)
            {
                panelSubmenuReportes.Visible = false;
            }
        }
        private void showSubmenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {

                subMenu.Visible = true;
            }

        }
        private Form Activeform = null;
        private void mostrarPanel(Form childForm)
        {
            if (Activeform != null)
                Activeform.Close();
            Activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDerecho.Controls.Add(childForm);
            panelDerecho.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

            showSubmenu(panelSubmenuFactura);
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmAgregarFactura());
            hideSubmenu();
        }

        private void btnModificarFactura_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmImprimirFactura());
            hideSubmenu();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea salir?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }

        }

        private void panelDerecho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuReportes);
        }

        private void btnReportePendi_Click(object sender, EventArgs e)
        {
            estadoFactura = "Pendiente";
            Cursor.Current = Cursors.WaitCursor;
            Reportes.CrystalReportFactPendientes facPendientes = new Reportes.CrystalReportFactPendientes();
            Cursor.Current = Cursors.Default;


            //Traigo los datos

            this.fACTURASTableAdapter.FacturasPendiente(this.dataSet1.FACTURAS, estadoFactura);
            facPendientes.SetDataSource(dataSet1);
            //Asignamos a reporte View
            Reportes.FrmFacPendi facIm = new Reportes.FrmFacPendi();
            facIm.crystalReportViewer1.ReportSource = facPendientes;
            facIm.ShowDialog();
            facIm.Close();
        }

        private void btnImpresas_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void fACTURASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fACTURASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void menuFacturador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.FACTURAS' Puede moverla o quitarla según sea necesario.
            this.fACTURASTableAdapter.Fill(this.dataSet1.FACTURAS);

        }

        private void btnImpresas_Click_1(object sender, EventArgs e)
        {
            estadoFactura = "Generada";

            Cursor.Current = Cursors.WaitCursor;
            Reportes.CrystalReportFactGeneradas facImpresas = new Reportes.CrystalReportFactGeneradas();
            Cursor.Current = Cursors.Default;

            //Traer Datos
            this.fACTURASTableAdapter.FacturaGenerada(this.dataSet1.FACTURAS, estadoFactura);
            facImpresas.SetDataSource(this.dataSet1);

            //Asignamos a reporte View
            Reportes.FrmReportesFacImpresas facIm = new Reportes.FrmReportesFacImpresas();
            facIm.crystalReportViewer1.ReportSource = facImpresas;
            facIm.ShowDialog();
            facIm.Close();
        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
