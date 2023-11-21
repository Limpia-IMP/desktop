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

        public ClsBanco.Cursos cursosDialog;

        public void CarregarDados()
        {
            /*txtTituloPromo.Text = promocaoAtual.nome;
            dtpValidade.Value = (promocaoAtual.validade_inic);
            txtDescricaoPromo.Text = promocaoAtual.descricao;*/
        }

        public CursosDialog()
        {
            InitializeComponent();
        }
    }
}
