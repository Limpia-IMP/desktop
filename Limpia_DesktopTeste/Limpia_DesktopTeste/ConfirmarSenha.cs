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
    public partial class ConfirmarSenha : Form
    {
        public string nome;
        public string email;
        public string Novasenha;
        public principal FormularioPai;
        ClsBanco clsBanco;
        public ConfirmarSenha()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
        }

        private void ConfirmarSenha_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(panel1, 30);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            if(senha != "") { 
            if (nome != clsBanco.Nome && nome != "") {
                clsBanco.Atualizar(senha, nome, "nome");
            }
            if(email != clsBanco.Email && email != "")
            {
                clsBanco.Atualizar(senha, email, "email");
            }
            if (Novasenha != senha && Novasenha != "")
            {
                clsBanco.Atualizar(senha, Novasenha, "senha");
            }
            }
            this.Close();
            FormularioPai.Close();
            principal form = new principal();
            form.Show();
        }
    }
}
