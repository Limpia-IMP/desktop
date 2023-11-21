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
    public partial class cursos : Form
    {
        public principal FormularioPai { get; set; }

        ClsBanco banco = new ClsBanco();
        public cursos()
        {
            InitializeComponent();
        }

        private void Promo_ofertas_Load(object sender, EventArgs e)
        {
            var promo = banco.Promo_Ofertas();


            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }

            for (int i = 0; i < promo.Count && i < this.Controls.Count; i++)
            {
                int iAtual = i;
                var current = promo[i];
                var control = this.Controls[i];

                control.Visible = true;

                if (control is Panel panel)
                {
                    if (panel.Controls.Count >= 2)
                    {
                        // Considerando que o primeiro controle é uma Label para descrição
                        if (panel.Controls[0] is Label lblDesc)
                        {
                            lblDesc.Text = current.descricao;
                        }

                        // E o segundo controle é uma Label para o nome
                        if (panel.Controls[1] is Label lblName)
                        {
                            lblName.Text = current.nome;
                        }

                        // Atribuir o idpromo ao painel para uso posterior
                        panel.Name = current.idpromo;
                    }
                }

                control.Click += (ee, s) =>
                {
                    var promocaoAtual = promo[iAtual];

                    Promo_Oferta_Dialog promo_Oferta_Dialog = new Promo_Oferta_Dialog();
                    promo_Oferta_Dialog.promocaoAtual = promocaoAtual;
                    promo_Oferta_Dialog.CarregarDados();
                    promo_Oferta_Dialog.FormularioPai = this.FormularioPai;  // Copia a referência do formulário principal
                    FormularioPai.openChildForm(promo_Oferta_Dialog);
                    this.Close();
                };
            }
        }
    }
}
