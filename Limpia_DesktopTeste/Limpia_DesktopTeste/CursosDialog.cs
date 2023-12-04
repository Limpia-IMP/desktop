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
    public partial class CursosDialog : Form
    {
        ClsBanco banco = new ClsBanco();

        public principal FormularioPai { get; set; }

        public ClsBanco.Cursos cursosAtual;
        

        public void CarregarDados()
        {
            txtNome.Text = cursosAtual.Nome;
            txtValor.Text = cursosAtual.Valor.ToString();
            txtDuracao.Text = cursosAtual.Duracao;
            txtDescricao.Text = cursosAtual.Descri;
            comboBox1.Text = cursosAtual.Categoria.ToString();
        }

        public CursosDialog()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            txtNome.Enabled = true;
            txtDuracao.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
                cursosAtual.Nome = txtNome.Text;
                cursosAtual.Valor = Convert.ToInt32(txtValor.Text);
                cursosAtual.Duracao = txtDuracao.Text;
                cursosAtual.Descri = txtDescricao.Text;
                cursosAtual.Categoria = comboBox1.Text;

                Boolean update = banco.updateCurso(cursosAtual);

            if (update == true)
            {
                txtDescricao.Enabled = false;
                txtValor.Enabled = false;
                txtNome.Enabled = false;
                txtDuracao.Enabled = false;
                comboBox1.Enabled = false;

                MessageBox.Show("Update realizado");
            }
            else
            {
                MessageBox.Show("Update não realizado, tente novamente");
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            banco.deleteInfo("tblcursos", cursosAtual.Idcursos);

            txtNome.Text = "";
            txtValor.Text = "";
            txtDuracao.Text = "";
            txtDescricao.Text = "";
            comboBox1.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }
        private void Voltar()
        {
            cursos cursos = new cursos();
            cursos.FormularioPai = this.FormularioPai;
            FormularioPai.openChildForm(cursos);
        }
        public void SetRoundedEdges(Panel panel, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddLine(radius, 0, panel.Width - radius, 0);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddLine(panel.Width - radius, panel.Height, radius, panel.Height);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new System.Drawing.Region(path);
        }

        private void CursosDialog_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(panel1, 30);
        }
    }
}
