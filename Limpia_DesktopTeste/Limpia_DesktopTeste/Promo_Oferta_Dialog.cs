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
        public Promo_Oferta_Dialog()
        {
            InitializeComponent();
            ClsBanco banco = new ClsBanco();
            string id = "";
            id = banco.IdPromo;
           var current = banco.Promo_Ofertas();
            int idInt;
            if (!int.TryParse(banco.IdPromo, out idInt))
            {
                MessageBox.Show("ID da Promoção é inválido.");
                return;
            }

            List<Promo> promoOfertas = banco.Promo_Ofertas();
            if (promoOfertas == null || promoOfertas.Count <= idInt)
            {
                MessageBox.Show("Promoção não encontrada.");
                return;
            }

            txtDescricaoPromo.Text = promoOfertas[idInt].descricao;
        }

        private void Promo_Oferta_Dialog_Load(object sender, EventArgs e)
        {

        }
    }
}
