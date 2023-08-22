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

       // SqlConnection cone = new SqlConnection(@"Password=etesp; Persist Security Info=True; User ID=sa; Initial Catalog=MENTALIA; Data Source=" + Environment.MachineName + "\\SQLEXPRESS");
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


            String senha = txtSenha.Text;
            String id = txtID.Text;
            banco.Senha = senha;
            banco.Id = id;

            principal form = new principal();
            form.Show();
            this.Hide();
            //int chck = banco.Login();
            /* if (chck >= 1)
            {
                principal form = new principal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Os dados inseridos estão incorretos");
            }*/


        }
    }
}
