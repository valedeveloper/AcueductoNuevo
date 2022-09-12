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
        public menuDigitador()
        {
            InitializeComponent();
        }

        private void hideSubmenu()
        {
            if (panelSubmenuConsumo.Visible == true)
            {
                panelSubmenuConsumo.Visible = false;
            }
            else
            {
                panelSubmenuConsumo.Visible = true;
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
    }
}
