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
using static Limpia_DesktopTeste.ClsBanco;

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
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Por favor, insira tanto o ID quanto a senha.");
                return;
            }

            banco.Id = txtID.Text;
            banco.Senha = txtSenha.Text;

            try
            {
                LoginResult result = banco.Login();

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
            catch (Exception ex)
            {
                // Log the actual exception for diagnostics. Implement a logger if you haven't.
                MessageBox.Show("Ocorreu um erro ao tentar fazer o login. Tente novamente mais tarde.");
            }
        }
    }
    }
