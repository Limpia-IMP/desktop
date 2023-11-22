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
    public partial class adicionar_funcionarios : Form
    {
        ClsBanco clsBanco;
        public adicionar_funcionarios()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
        }

        private void adicionar_funcionarios_Load(object sender, EventArgs e)
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

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            string nomeFunc = txtNome.Text;
            string emailFunc = txtEmail.Text;
            string senhaFunc = txtSenha.Text;
            int codCargo = Convert.ToInt32(cbCodCargo.Text);
            string rg = txtRG.Text;
            string cpf = txtCPF.Text;
            if (nomeFunc != "" && emailFunc != "" && senhaFunc != "" && codCargo != 0 && rg != "" && cpf != "") { 
                clsBanco.Cadastrar(nomeFunc, emailFunc, senhaFunc, codCargo, rg, cpf);}
            else
                MessageBox.Show("Preencha todos os campos!");

            MessageBox.Show(clsBanco.msgCadastro);
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            // Criar MaskedTextBox para CPF
            MaskedTextBox mtbCPF = new MaskedTextBox();
            mtbCPF.Mask = "000.000.000-00";
            this.Controls.Add(mtbCPF); // Adiciona ao formulário

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox mtbRG = new MaskedTextBox();
            mtbRG.Mask = "00.000.000-0";
            this.Controls.Add(mtbRG); // Adiciona ao formulário
        }
    }
}
