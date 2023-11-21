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
        public trabalhos_gerenciamento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            trabalhos trabalhos = new trabalhos();
            trabalhos.FormularioPai = this.FormularioPai;
            FormularioPai.openChildForm(trabalhos);
        }
    }
}
