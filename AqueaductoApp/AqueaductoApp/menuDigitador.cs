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
using AqueaductoApp.CapaModelos;
using AqueaductoApp.CapaDatos;

namespace AqueaductoApp
{
    public partial class menuDigitador : Form
    {
        public menuDigitador(string User,string Password)
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
            if (panelSubmenuConsumo.Visible == true)
            {
                panelSubmenuConsumo.Visible = false;
            }
           
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
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

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuConsumo);
        }

        private void btnNuevaLectura_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmAgregarConsumo());
            hideSubmenu();
        }

        private void btnModificarLectura_Click(object sender, EventArgs e)
        {
            mostrarPanel(new FrmModificarConsumo());
            hideSubmenu();
        }

        private void menuDigitador_Load(object sender, EventArgs e)
        {

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

        private void cONSUMOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONSUMOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.acueductoDataSet);

        }

        private void menuDigitador_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'acueductoDataSet.CONSUMOS' Puede moverla o quitarla según sea necesario.
            this.cONSUMOSTableAdapter.Fill(this.acueductoDataSet.CONSUMOS);

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Reportes.CrystalReportConsumos reportDatos = new Reportes.CrystalReportConsumos();

            //Traer los datos
            this.cONSUMOSTableAdapter.Fill(this.acueductoDataSet.CONSUMOS);
            reportDatos.SetDataSource(this.acueductoDataSet);

            Cursor.Current = Cursors.Default;

            //Asignamos a reporte View
            Reportes.FrmReporteConsumo frmReporteConsumo = new Reportes.FrmReporteConsumo();
            frmReporteConsumo.crystalReportViewer1.ReportSource = reportDatos;
            frmReporteConsumo.ShowDialog();
            frmReporteConsumo.Close();
            hideSubmenu();
        }
    }
}
