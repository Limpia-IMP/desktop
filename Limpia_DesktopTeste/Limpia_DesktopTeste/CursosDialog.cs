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
        public principal FormularioPai { get; set; }

        public ClsBanco.Cursos cursosAtual;

        public void CarregarDados()
        {
            txtValor.Text = cursosAtual.Nome;
            txtDuracao.Text = cursosAtual.Duracao;
            txtDescricao.Text = cursosAtual.Descri;
            comboBox1.Text = cursosAtual.Categoria.ToString();
        }

        public CursosDialog()
        {
            InitializeComponent();
        }

        private void btnEditarPromo_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            txtDuracao.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void CursosDialog_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(panel1, 30);
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
    }
}
