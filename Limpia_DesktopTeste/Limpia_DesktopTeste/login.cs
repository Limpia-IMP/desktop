using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpia_DesktopTeste
{
    public partial class login : Form
    {
        ClsBanco banco = new ClsBanco();

        public login()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            inicial form = new inicial();
            form.Show();
            this.Hide();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            banco.Senha = txtSenha.Text;
            banco.Id = txtID.Text;

            ClsBanco.LoginResult result = banco.Login();

            if (result.IsSuccessful)
            {
                principal form = new principal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
