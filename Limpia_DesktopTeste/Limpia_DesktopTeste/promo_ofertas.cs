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
    public partial class promo_ofertas : Form

        
    {
        ClsBanco banco = new ClsBanco();
        public promo_ofertas()
        {
            InitializeComponent();
        }


        private void Promo_ofertas_Load(object sender, EventArgs e)
        {
            var promo = banco.Promo_Ofertas();
            
            foreach(Control control in this.Controls)
            {
                control.Visible = false;
            }

            for(int i = 0; i < promo.Count; i++)
            {
                var current = promo[i];
                this.Controls[i].Visible = true;
                //descricao
                this.Controls[i].Controls[0].Text = current.descricao;
                //nome
                this.Controls[i].Controls[1].Text = current.nome;
            }
                
            
        }
    }
}
