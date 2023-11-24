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
    public partial class perfil_gerenciamento : Form
    {
        ClsBanco clsBanco;
        public principal FormularioPai;

        public Button button;
        int btn = 0;
        int id = 0;
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

            id = lst[btn].IdDenuncia;
            lblNome.Text = lst[btn].Name;
            lblEmail.Text = lst[btn].Email;
            lblTel.Text = lst[btn].Telefone;
            lblTipo.Text = lst[btn].TipoUser;
            lblDataNasc.Text = lst[btn].DataNasc.ToString();
            lblCPF.Text = lst[btn].Cpf;
            lblRG.Text = lst[btn].Rg;
            lblGen.Text = lst[btn].Genero;
        }
    }
}
