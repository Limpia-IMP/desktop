using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpia_DesktopTeste
{
    public partial class Carregando : Form
    {
        public ClsEmail clsEmail;
        public principal FormularioPai;
        public string janela;
        public Button button;
        int btn = 0;
        public Carregando()
        {
            InitializeComponent();
            clsEmail = new ClsEmail();
        }

        private void CarregarSuportePers()
        {
            clsEmail.ConnectAndAuthenticate();
            suporte_personalizado form = new suporte_personalizado();
            form.FormularioPai = this.FormularioPai;  // Copia a referência do formulário principal
            var (emailName, emailFrom, emailSubjects, emailText, emailUids) = clsEmail.FetchEmail("_Duvida");
            if (button != null)
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
                
                form.name = emailName[btn];
                form.subject = emailSubjects[btn];
                form.text = emailText[btn];
                form.from = emailFrom[btn];
                form.uId = emailUids[btn];
            }
            clsEmail.Disconnect();
            FormularioPai.Cursor = Cursors.Default;
            FormularioPai.openChildForm(form);
            
        }

        private void CarregarSuporte()
        {
            suporte form = new suporte();
            clsEmail.ConnectAndAuthenticate();
            var (emailName, emailFrom, emailSubjects, emailText, emailUids) = clsEmail.FetchEmail("_Duvida");
            form.FormularioPai = this.FormularioPai;  // 'this' se refere ao FormPrincipal
            form.emailFrom = emailName;
            form.emailSubjects = emailSubjects;
            clsEmail.Disconnect();
            FormularioPai.Cursor = Cursors.Default;
            FormularioPai.openChildForm(form);
        }

        private async void Carregando_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            switch (janela)
            {
                case "Suporte1":
                    CarregarSuporte();
                    break;
                case "Suporte2":
                    CarregarSuportePers();
                    break;
            }

        }

    }
}
