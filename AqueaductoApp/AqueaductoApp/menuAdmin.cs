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

namespace AqueaductoApp
{
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();

            CustomizeDesign();
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
            Reportes.CrystalReportUser reportUser = new Reportes.CrystalReportUser();
            hideSubmenu();
        }

        private void btnReportePropi_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnReportePredio_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}
