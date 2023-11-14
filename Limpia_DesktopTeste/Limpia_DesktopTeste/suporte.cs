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
    public partial class suporte : Form
    {
        public principal FormularioPai { get; set; }
        public suporte()
        {
            InitializeComponent();
        }
        private void suporte_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(panel1, 30); // 30 é o raio. Ajuste conforme sua necessidade.
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            suporte_personalizado suportePers = new suporte_personalizado();
            suportePers.FormularioPai = this.FormularioPai;  // Copia a referência do formulário principal
            FormularioPai.openChildForm(suportePers);
            this.Close();
        }

    }
}
