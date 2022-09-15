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
        public menuFacturador()
        {
            InitializeComponent();
        }
        private void hideSubmenu()
        {
            if (panelSubmenuFactura.Visible == true)
            {
                panelSubmenuFactura.Visible = false;
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if (panelSubmenuFactura.Visible == false)
            {
                panelSubmenuFactura.Visible = true;
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
    }
}
