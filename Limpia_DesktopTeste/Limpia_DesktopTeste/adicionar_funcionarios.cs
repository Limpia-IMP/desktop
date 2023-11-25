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

            txtCPF.KeyPress += new KeyPressEventHandler(txtCPF_KeyPress);
            txtCPF.TextChanged += new EventHandler(txtCPF_TextChanged);
            txtRG.KeyPress += new KeyPressEventHandler(txtRG_KeyPress);
            txtRG.TextChanged += new EventHandler(txtRG_TextChanged);
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
                clsBanco.Cadastrar(nomeFunc, emailFunc, senhaFunc, codCargo, rg, cpf);
                Limpar();
            }
            else
                MessageBox.Show("Preencha todos os campos!");

            MessageBox.Show(clsBanco.msgCadastro);
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            cbCodCargo.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtSenha.Text = "";

            txtNome.Focus();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            FormatCPF();
        }

        private void FormatCPF()
        {
            string text = txtCPF.Text.Replace(".", "").Replace("-", "").Trim();
            if (text.Length > 9)
            {
                txtCPF.Text = $"{text.Substring(0, 3)}.{text.Substring(3, 3)}.{text.Substring(6, 3)}-{text.Substring(9)}";
            }
            else if (text.Length > 6)
            {
                txtCPF.Text = $"{text.Substring(0, 3)}.{text.Substring(3, 3)}.{text.Substring(6)}";
            }
            else if (text.Length > 3)
            {
                txtCPF.Text = $"{text.Substring(0, 3)}.{text.Substring(3)}";
            }
            else
            {
                txtCPF.Text = text;
            }
            txtCPF.SelectionStart = txtCPF.Text.Length;
        }

            private bool isUpdatingRG = false;

      private void txtRG_TextChanged(object sender, EventArgs e)
       {
         if (!isUpdatingRG)
          {
           FormatRG();
          }
       }

        private void FormatRG()
        {
            isUpdatingRG = true;

            string text = txtRG.Text.Replace(".", "").Replace("-", "").Trim();
            int textLength = text.Length;

            try
            {
                if (textLength > 8)
                {
                    txtRG.Text = $"{text.Substring(0, 2)}.{text.Substring(2, 3)}.{text.Substring(5, 3)}-{text.Substring(8)}";
                }
                else if (textLength > 5)
                {
                    txtRG.Text = $"{text.Substring(0, 2)}.{text.Substring(2, 3)}.{text.Substring(5)}";
                }
                else if (textLength > 2)
                {
                    txtRG.Text = $"{text.Substring(0, 2)}.{text.Substring(2)}";
                }
                else
                {
                    txtRG.Text = text;
                }

                txtRG.SelectionStart = txtRG.Text.Length;
            }
            finally
            {
                isUpdatingRG = false;
            }
        }



        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbCodCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
