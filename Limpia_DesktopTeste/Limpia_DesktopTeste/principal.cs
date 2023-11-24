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

            home form = new home();
            form.FormularioPai = this;  
            openChildForm(form);
        }

        private void LoadDataAsync()
        {
            try
            {
                banco.ObterAsync();
                txtNomeFunc.Text = banco.Nome;
                txtCodCargo.Text = "#" + banco.IdCargo;
                if (banco.IdCargo.Equals("1"))
                    btnAddFunc.Show();
                else btnAddFunc.Hide();

            }
            catch (Exception ex)
            {
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
            trabalhos trabalhos = new trabalhos();
            trabalhos.FormularioPai = this;
            openChildForm(trabalhos);
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
            perfil form = new perfil();
            form.FormularioPai = this; 
            openChildForm(form);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            openChildForm(new cursos());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home form = new home();
            form.FormularioPai = this;
            openChildForm(form);
        }

        private void btnPromoOfertas_Click_1(object sender, EventArgs e)
        {
            promo_ofertas formPromo = new promo_ofertas();
            formPromo.FormularioPai = this;
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

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            openChildForm(new adicionar_funcionarios());
        }
    }
}
