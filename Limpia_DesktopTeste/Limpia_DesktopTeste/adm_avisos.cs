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
    public partial class adm_avisos : Form
    {
        public principal FormularioPai;
        public PictureBox Button;
        ClsBanco clsBanco;
        int btn;
        int idAviso;
        public adm_avisos()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
        }

        private void adm_avisos_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(panel1, 30);
            switch (Button.Name)
            {
                case "arrow1": btn = 0; break;
                case "arrow2": btn = 1; break;
                case "arrow3": btn = 2; break;
                case "arrow4": btn = 3; break;
                case "arrow5": btn = 4; break;
                case "arrow6": btn = 5; break;
                case "arrow7": btn = 6; break;
                case "arrow8": btn = 7; break;
                case "arrow9": btn = 8; break;
            }

            var lst = clsBanco.avisosHome();

            idAviso = lst[btn].IdAviso;
            lblAviso.Text = lst[btn].Texto;
            lblTitulo.Text = lst[btn].Titulo;

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
            home form = new home();
            form.FormularioPai = this.FormularioPai;

            FormularioPai.openChildForm(form);
        }
    }
}
