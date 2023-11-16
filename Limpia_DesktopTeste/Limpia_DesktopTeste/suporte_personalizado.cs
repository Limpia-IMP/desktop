using MailKit;
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
    public partial class suporte_personalizado : Form
    {
        public principal FormularioPai { get; set; }
        public ClsEmail clsEmail;
        public int num;
        public string subject;
        public string text;
        public string name;
        public string from;

        public UniqueId uId;

        public suporte_personalizado()
        {
            InitializeComponent();
            
        }
        private void suporte_personalizado_Load(object sender, EventArgs e)
        {
            DisplayEmails(subject, name, text);
        }

        private void DisplayEmails(string subject, string name, string text)
        {
            lblTitulo.Text = subject + " - " + name;
            lblTexto.Text = text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void Voltar()
        {
            Carregando carregando = new Carregando();
            carregando.janela = "Suporte1";
            carregando.FormularioPai = FormularioPai;
            FormularioPai.openChildForm(carregando);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {            // Chamando o método de resposta
            DialogResult result = MessageBox.Show("Tem certeza que deseja enviar essa resposta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                string reply = txtResposta.Text;
                clsEmail.SendReply(from, subject, reply, uId);
                clsEmail.MarkEmailAsRead(uId);

                Voltar();
            }
        }

    }
}

