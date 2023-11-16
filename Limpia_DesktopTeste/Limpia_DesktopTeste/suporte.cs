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
        public ClsEmail clsEmail;
        public principal FormularioPai { get; set; }
        int btn = 0;
        public suporte()
        {
            InitializeComponent();
        }

        private void suporte_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(panel1, 30); // 30 é o raio. Ajuste conforme sua necessidade.
        }

        public void DisplayEmails(List<string> emailFrom, List<string> emailSubjects)
        {
            // Exemplo de como exibir os assuntos dos e-mails
            // Isso deve ser ajustado conforme o número de e-mails e labels disponíveis
            var labelsF = new List<Label> { lblFrom1, lblFrom2, lblFrom3, lblFrom4, lblFrom5, lblFrom6, lblFrom7, lblFrom8, lblFrom9 };
            for (int i = 0; i < emailFrom.Count && i < labelsF.Count; i++)
            {
                labelsF[i].Text = emailFrom[i];
            }
            var labelsA = new List<Label> { lblAssunto1, lblAssunto2, lblAssunto3, lblAssunto4, lblAssunto5, lblAssunto6, lblAssunto7, lblAssunto8, lblAssunto9 };
            for (int i = 0; i < emailSubjects.Count && i < labelsA.Count; i++)
            {
                labelsA[i].Text = emailSubjects[i];
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

        private void btnSuporte_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            suporte_personalizado suportePers = new suporte_personalizado();
            suportePers.FormularioPai = this.FormularioPai;  // Copia a referência do formulário principal
            

            if (button != null)
            {
                
                switch (button.Name)
                {
                    case "btn1":
                        btn = 0;
                        break;

                    case "btn2":
                        btn = 1;
                        break;

                    case "btn3":
                        btn = 2;
                        break;

                    case "btn4":
                        btn = 3;
                        break;

                    case "btn5":
                        btn = 4;
                        break;

                    case "btn6":
                        btn = 5;
                        break;

                    case "btn7":
                        btn = 6;
                        break;

                    case "btn8":
                        btn = 7;
                        break;

                    case "btn9":
                        btn = 8;
                        break;
                }
                suportePers.num = btn;
                suportePers.clsEmail = clsEmail;
            }
            
            FormularioPai.openChildForm(suportePers);
            this.Close();
        }

    }
}
