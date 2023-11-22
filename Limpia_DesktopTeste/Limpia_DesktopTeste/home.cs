﻿using System;
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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
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
            SetRoundedEdges(panel1, 30);
            SetRoundedEdges(panel2, 30); 
            SetRoundedEdges(panel3, 30); 
            SetRoundedEdges(panel4, 30); 
            SetRoundedEdges(panel5, 30); 
            SetRoundedEdges(panel6, 30); 
            SetRoundedEdges(panel7, 30); 
            SetRoundedEdges(panel8, 30); 
            SetRoundedEdges(panel9, 30); 
        }
    }
}
