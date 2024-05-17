using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    public partial class frm_est : Form
    {
        DataTable dt = new DataTable();
        private Form frmAtivo;

        public frm_est()
        {
            InitializeComponent();
            Inicializar();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        public void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMaterial);
            FormShow(new frmMaterial());
        }

        public void Inicializar()
        {
            dt = Material.GetMateriais(true);
            dgvMaterial.DataSource = dt;
        }
    }
}
