using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpia_DesktopTeste
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            openChildForm(new home());
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();                    
        }

        private void btnTrabalhos_Click(object sender, EventArgs e)
        {
            openChildForm(new trabalhos());
        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            suporte formSuporte = new suporte();
            formSuporte.FormularioPai = this;  // 'this' se refere ao FormPrincipal
            openChildForm(formSuporte);
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            openChildForm(new perfil());
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new cursos());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new home());
            /*parei aqui por preguiça pq não fui feito pra essa vida*/
            /*tem q trabalhar sebss!!!!*/
        }

        private void btnPromoOfertas_Click_1(object sender, EventArgs e)
        {
            promo_ofertas formPromo = new promo_ofertas();
            formPromo.FormularioPai = this;  // 'this' se refere ao FormPrincipal
            openChildForm(formPromo);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            inicial form = new inicial();
            form.Show();
            this.Hide();
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
