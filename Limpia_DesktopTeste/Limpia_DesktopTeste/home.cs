using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Limpia_DesktopTeste
{
    public partial class home : Form
    {
        ClsBanco clsBanco;
        public home()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
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

        private void home_Load(object sender, EventArgs e)
        {
            var lst = clsBanco.avisosHome();
            var panel  = new List<Panel> { pan1, pan2, pan3, pan4, pan5, pan6, pan7, pan8, pan9 };
            for (int i = 0; i < panel.Count(); i++)
                SetRoundedEdges(panel[i], 30);
          
            var lTxt = new List<System.Windows.Forms.Label> { lblTxt1, lblTxt2, lblTxt3, lblTxt4, lblTxt5, lblTxt6, lblTxt7, lblTxt8, lblTxt9 };
            var lTit = new List<System.Windows.Forms.Label> { lblTitulo1, lblTitulo2, lblTitulo3, lblTitulo4, lblTitulo5, lblTitulo6, lblTitulo7, lblTitulo8, lblTitulo9 };
            
            if (lst.Count < panel.Count)
            {
                for (int i = lst.Count; i < panel.Count; i++)
                {
                    panel[i].Visible = false;
                }
            }

            for ( int i = 0; i < lst.Count(); i++) {
                panel[i].Visible = true;
                lTxt[i].Text = lst[i].Texto.ToString();
                lTit[i].Text = lst[i].Titulo.ToString();
            }
        }
    }
}
