﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpia_DesktopTeste
{
    public partial class perfil_gerenciamento : Form
    {
        ClsBanco clsBanco;
        public principal FormularioPai;

        public Button button;
        int btn;
        int id;
        public perfil_gerenciamento()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
        }
        private void Voltar()
        {
            perfil form = new perfil();
            form.FormularioPai = this.FormularioPai;
            FormularioPai.openChildForm(form);
        }

        private void perfil_gerenciamento_Load(object sender, EventArgs e)
        {
            switch (button.Name)
            {
                case "btn1": btn = 0; break;
                case "btn2": btn = 1; break;
                case "btn3": btn = 2; break;
                case "btn4": btn = 3; break;
                case "btn5": btn = 4; break;
                case "btn6": btn = 5; break;
                case "btn7": btn = 6; break;
                case "btn8": btn = 7; break;
                case "btn9": btn = 8; break;
            }

            var lst = clsBanco.perfilsDenunciados();
            var idDenuncia = clsBanco.idDenuncia;
            byte[] imageBytes;

            id = lst[btn].IdDenuncia;
            lblNome.Text = lst[btn].Name;
            lblEmail.Text = lst[btn].Email;
            lblTel.Text = lst[btn].Telefone;
            lblTipo.Text = lst[btn].TipoUser;
            lblDataNasc.Text = lst[btn].DataNasc.ToString("dd/MM/yyyy");
            lblCPF.Text = lst[btn].Cpf;
            lblRG.Text = lst[btn].Rg;
            lblGen.Text = lst[btn].Genero;
            imageBytes = lst[btn].Image;

            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    imgPerfil.Image = image;
                }
            }

            SetRoundedEdges(panel1, 30);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }


        private void btnAprovar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja manter esse perfil?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var idDenuncia = clsBanco.idDenuncia;
                int idEspecifico = idDenuncia[btn];
                var resultado = clsBanco.manterPerfil(idEspecifico);
                if (resultado.IsSuccessful)
                {
                    Voltar();
                }
                else
                {
                    MessageBox.Show("Erro ao manter perfil.");
                }
            }
        }

        private void btnRecusar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse perfil?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var idDenuncia = clsBanco.idDenuncia;
            int idEspecifico = idDenuncia[btn];
            if (result == DialogResult.Yes)
            {
                clsBanco.DeletarPerfil(idDenuncia: idEspecifico);
                Voltar();
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
    }
}
