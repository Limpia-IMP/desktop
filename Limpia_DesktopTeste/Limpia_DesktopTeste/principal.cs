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
        ClsBanco banco = new ClsBanco();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public principal()
        {
            InitializeComponent();
            this.customTopBar.MouseDown += new MouseEventHandler(customTopBar_MouseDown);
            this.customTopBar.MouseMove += new MouseEventHandler(customTopBar_MouseMove);
            this.customTopBar.MouseUp += new MouseEventHandler(customTopBar_MouseUp);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
            openChildForm(new home());
        }

        private async void LoadDataAsync()
        {
            try
            {
                await banco.ObterAsync();
                txtNomeFunc.Text = banco.Nome;
                txtCodCargo.Text = "#" + banco.IdCargo;// Update UI with the fetched name
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
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
            Carregando carregando = new Carregando();
            Cursor = Cursors.WaitCursor;
            carregando.FormularioPai = this;
            carregando.janela = "Suporte1";
            openChildForm(carregando);
            
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
            banco.Email = "";
            inicial form = new inicial();
            form.Show();
            Close();
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void customTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }
        private void customTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void customTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
