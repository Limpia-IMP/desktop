using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Limpia_DesktopTeste.ClsBanco;

namespace Limpia_DesktopTeste
{
    public partial class Promo_Oferta_Dialog : Form
    {
        public principal FormularioPai { get; set; }

        public ClsBanco.Promo promocaoAtual;

        public Promo_Oferta_Dialog()
        {
            InitializeComponent();
        }

        public void CarregarDados()
        {
            txtTituloPromo.Text = promocaoAtual.nome;
            dtpValidade.Value = (promocaoAtual.validade_inic);
            txtDescricaoPromo.Text = promocaoAtual.descricao;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            promo_ofertas form = new promo_ofertas();
            FormularioPai.openChildForm(form);
            form.FormularioPai = this.FormularioPai;
            this.Close();
        }
    }
}
