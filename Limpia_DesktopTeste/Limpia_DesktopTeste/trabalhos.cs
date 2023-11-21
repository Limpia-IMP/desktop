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
        public partial class trabalhos : Form
        {
            public principal FormularioPai;
            public ClsBanco clsBanco;
        public trabalhos()
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
            private async void trabalhos_Load(object sender, EventArgs e)
            {
                SetRoundedEdges(panel1, 30); // 30 é o raio. Ajuste conforme sua necessidade.
                var lst = await clsBanco.trabalhosG(); // A função 'trabalhosG' deveria ser 'async', então você precisaria chamar com 'await'
                var labelsF = new List<Label> { lblTrab1, lblTrab2, lblTrab3, lblTrab4, lblTrab5, lblTrab6, lblTrab7, lblTrab8, lblTrab9 };
                var labelsA = new List<Label> { lblTrabDesc1, lblTrabDesc2, lblTrabDesc3, lblTrabDesc4, lblTrabDesc5, lblTrabDesc6, lblTrabDesc7, lblTrabDesc8, lblTrabDesc9 };
                var buttons = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

                // Presumo que 'trabalhos' seja uma lista de strings ou um objeto que você possa converter em strings.
                if (lst.Count < labelsF.Count)
                {
                    for (int i = lst.Count; i < labelsF.Count; i++)
                    {
                        labelsF[i].Visible = false;
                        labelsA[i].Visible = false;
                        buttons[i].Visible = false;
                    }
                }

                for (int i = 0; i < lst.Count; i++)
                {
                    labelsF[i].Text = lst[i].Titulo;
                    labelsA[i].Text = lst[i].Desc;
                }
            }


            private void btnTrabalho_Click(object sender, EventArgs e)
            {
                trabalhos_gerenciamento gerenciamento = new trabalhos_gerenciamento();
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
