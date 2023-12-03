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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
