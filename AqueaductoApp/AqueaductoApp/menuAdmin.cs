using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AqueaductoApp.CapaVistas;
using AqueaductoApp.Reportes;
using AqueaductoApp.CapaDatos;
using System.IO;

namespace AqueaductoApp
{
    public partial class menuAdmin : Form
    {
        public menuAdmin(string User,string Password)
        {
            InitializeComponent();

            CustomizeDesign();
            CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter fotoUser = new CapaDatos.DataSet1TableAdapters.USUARIOSTableAdapter();
            byte[] fotoUsuario = (byte[])fotoUser.traerFoto(User,Password);

            Image imagenUsuario = CapaModelos.ClsConvertToImage.byteArrayToImage(fotoUsuario);
            pictureRound1.Image = imagenUsuario;
            this.labelNombre.Text = User;

        }


        public void CustomizeDesign()
        {
            panelSubmenuUsuario.Visible = false;
            panelSubmenuCliente.Visible = false;

        }



        public void hideSubmenu()
        {

            if (panelSubmenuUsuario.Visible == true)
            {
                panelSubmenuUsuario.Visible = false;
            }
            if (panelSubmenuCliente.Visible == true)
            {
                panelSubmenuCliente.Visible = false;
            }
            if (panelSubmenuPredio.Visible == true)
            {
                panelSubmenuPredio.Visible = false;
            }
            if(panelsubMenuReportes.Visible==true)
            {
                panelsubMenuReportes.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                subMenu.Visible = true;
            }

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuUsuario);
        }




        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            mostrarPanel(new FrmAgregarUsuario());
            hideSubmenu();

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

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmModificarUsuario());
            hideSubmenu();
        }

        private void btnEstadoUsuario_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmAgregarPropietario());

            hideSubmenu();
        }

        private void btnModificarPropietario_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmModificarPropietario());
            hideSubmenu();
        }

        private void btnEstadoCliente_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            showSubMenu(panelSubmenuCliente);
        }

        private void btnCrearPredio_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmagregarPredio());
            hideSubmenu();
        }

        private void btnModificarPredio_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnEstadoPredio_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnPredio_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuPredio);
        }

        private void btnCrearPredio_Click_1(object sender, EventArgs e)
        {
            mostrarPanel(new FrmagregarPredio());

            hideSubmenu();

        }

        private void btnModificarPredio_Click_1(object sender, EventArgs e)
        {
            mostrarPanel(new FrmModificarPredio());
            hideSubmenu();

        }

        private void btnEstadoPredio_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();

        }

        private void pictureRound1_Click(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
                this.labelRol.Text = "ADMINISTRADOR";
            }
        }

        private void menuAdmin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubMenuReportes);
        }

        private void btnReportUser_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            Reportes.CrystalReportUser reportDatos = new Reportes.CrystalReportUser();

            //Traer los datos
            this.uSUARIOSTableAdapter.Fill(this.acueductoDataSet.USUARIOS);
            reportDatos.SetDataSource(this.acueductoDataSet);

            Cursor.Current = Cursors.Default;

            //Asignamos a reporte View
            Reportes.FrmReporteUsuarios frmReporteUser = new Reportes.FrmReporteUsuarios();
            frmReporteUser.crystalReportViewer1.ReportSource = reportDatos;
            frmReporteUser.ShowDialog();
            frmReporteUser.Close();
            hideSubmenu();
        }

        private void btnReportePropi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Reportes.CrystalReportProp reportDatos = new Reportes.CrystalReportProp();

            //Traer los datos

            //Acomodar error
            this.pROPIETARIOSTableAdapter1.Fill(this.acueductoDataSet.PROPIETARIOS);
            reportDatos.SetDataSource(this.acueductoDataSet);

            Cursor.Current = Cursors.Default;

            //Asignamos a reporte View
            Reportes.FrmReportePropietario frmReporteUser = new Reportes.FrmReportePropietario();
            frmReporteUser.crystalReportViewer1.ReportSource =reportDatos;
            frmReporteUser.ShowDialog();
            frmReporteUser.Close();
            hideSubmenu();
        }

        private void btnReportePredio_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //Traigo el reportePredio
            Reportes.CrystalReportPredios reportDatos = new Reportes.CrystalReportPredios();

            //Traer los datos y arreglar Datos

            this.pREDIOSTableAdapter.Fill(this.dataSet1.PREDIOS);
            reportDatos.SetDataSource(this.acueductoDataSet);

            //Traer Form

            Reportes.FrmReportPredio reportePredio= new Reportes.FrmReportPredio();
            reportePredio.crystalReportViewer1.ReportSource = reportDatos;
            reportePredio.ShowDialog();
            reportePredio.Close();
            hideSubmenu();

        }

        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.acueductoDataSet);

        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
           


            // TODO: esta línea de código carga datos en la tabla 'acueductoDataSet.PROPIETARIOS' Puede moverla o quitarla según sea necesario.
            this.pROPIETARIOSTableAdapter1.Fill(this.acueductoDataSet.PROPIETARIOS);
            // TODO: esta línea de código carga datos en la tabla 'acueductoDataSet.PREDIOS' Puede moverla o quitarla según sea necesario.
            this.pREDIOSTableAdapter1.Fill(this.acueductoDataSet.PREDIOS);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.FACTURAS' Puede moverla o quitarla según sea necesario.

            this.pREDIOSTableAdapter.Fill(this.dataSet1.PREDIOS);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.PROPIETARIOS' Puede moverla o quitarla según sea necesario.
            this.pROPIETARIOSTableAdapter.Fill(this.dataSet1.PROPIETARIOS);
            // TODO: esta línea de código carga datos en la tabla 'acueductoDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.acueductoDataSet.USUARIOS);

        }

        private void panelUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
    }
}
