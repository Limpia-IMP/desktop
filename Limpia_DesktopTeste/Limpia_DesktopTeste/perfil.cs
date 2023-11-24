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
    public partial class perfil : Form
    {
        ClsBanco clsBanco;
        public principal FormularioPai;
        public perfil()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
        }

        private void perfil_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(panel1, 30);
            SetRoundedEdges(panel2, 30);

            var lst = clsBanco.perfilsDenunciados();
            var labelsU = new List<Label> { lblUser1, lblUser2, lblUser3, lblUser4, lblUser5, lblUser6, lblUser7, lblUser8, lblUser9};
            var labelsE = new List<Label> { lblEmail1,lblEmail2, lblEmail3, lblEmail4, lblEmail5, lblEmail6, lblEmail7, lblEmail8, lblEmail9};
            var labelsG = new List<Label> { lblGenero1, lblGenero2, lblGenero3, lblGenero4, lblGenero5, lblGenero6, lblGenero7, lblGenero8, lblGenero9};
            var labelsO = new List<Label> { lblOcup1, lblOcup2, lblOcup3, lblOcup4, lblOcup5, lblOcup6, lblOcup7, lblOcup8, lblOcup9};
            var buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            if (lst.Count < labelsU.Count) { 
            
                for ( int i = lst.Count; i < labelsU.Count; i++)
                {
                    labelsU[i].Visible = false;
                    labelsE[i].Visible = false;
                    labelsG[i].Visible = false;
                    labelsO[i].Visible = false;
                    buttons[i].Visible = false;
                }
            }

            for ( int i = 0;  i < lst.Count; i++) {
                labelsU[i].Text = lst[i].Name;
                labelsE[i].Text = lst[i].Email;
                labelsG[i].Text = lst[i].Genero;
                labelsO[i].Text = lst[i].TipoUser;
            }

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

        private void btn_Click(object sender, EventArgs e)
        {
            perfil_gerenciamento gerenciamento = new perfil_gerenciamento();
            gerenciamento.FormularioPai = this.FormularioPai;
            Button button = sender as Button;
            if (button != null)
            {
                gerenciamento.button = button;
            }
            FormularioPai.openChildForm(gerenciamento);
        }
    }
}
