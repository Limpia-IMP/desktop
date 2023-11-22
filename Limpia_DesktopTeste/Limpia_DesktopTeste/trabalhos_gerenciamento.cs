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
    public partial class trabalhos_gerenciamento : Form
    {
        public principal FormularioPai;
        public ClsBanco clsBanco;
        public Button button;
        int btn = 0;
        int idAnuncio;
        public trabalhos_gerenciamento()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void Voltar()
        {
            trabalhos trabalhos = new trabalhos();
            trabalhos.FormularioPai = this.FormularioPai;
            FormularioPai.openChildForm(trabalhos);
        }

        private async void trabalhos_gerenciamento_Load(object sender, EventArgs e)
        {
            switch (button.Name)
            {
                case "btn1": btn = 0; break;
                case "btn2": btn = 1; break;
                case "btn3": btn = 2; break;
                case "btn4": btn = 3; break;
                case "btn5": btn = 4; break;
                case "btn6": btn = 5; break;
                case "btn7": btn = 6; break;
                case "btn8": btn = 7; break;
                case "btn9": btn = 8; break;
            }

            var lst = await clsBanco.trabalhosG();

            idAnuncio = lst[btn].IdAnuncio;
            lblTitulo.Text = lst[btn].Titulo;
            lblNome.Text = lst[btn].NomeContratante;
            lblData.Text = lst[btn].Data.ToString();
            lblValor.Text = lst[btn].Valor;
            lblEndereco.Text = lst[btn].Endereco;
            lblCidade.Text = lst[btn].Cidade;
            lblEstado.Text = lst[btn].Estado;
            lblDesc.Text = lst[btn].Desc;
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            int idAnuncioEspecifico = idAnuncio;
            clsBanco.status = "Aprovado";
            var resultado = clsBanco.Aprovacao(idAnuncioEspecifico);
            if (resultado.IsSuccessful)
            {
                Voltar();
            }
            else
            {
                MessageBox.Show("Erro ao aprovar o anúncio.");
            }
        }


    }
}
