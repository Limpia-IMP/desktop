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

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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
            openChildForm(new suporte());
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
            /*parei aqui por preguiça pq não fui feito pra essa vida*/
            /*tem q trabalhar sebss!!!!*/
        }

        private void btnPromoOfertas_Click_1(object sender, EventArgs e)
        {
            openChildForm(new promo_ofertas());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            inicial form = new inicial();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
