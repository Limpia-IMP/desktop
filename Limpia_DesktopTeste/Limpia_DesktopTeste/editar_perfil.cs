﻿using System;
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
    public partial class editar_perfil : Form
    {
        ClsBanco clsBanco;
        public principal FormularioPai;
        public editar_perfil()
        {
            InitializeComponent();
            clsBanco = new ClsBanco();
        }

        private void editar_perfil_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
            SetRoundedEdges(panel1, 30);
        }

        private void LoadDataAsync()
        {
            try
            {
                clsBanco.ObterAsync();
                txtNome.Text = clsBanco.Nome;
                txtEmail.Text = clsBanco.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        { 
            ConfirmarSenha form = new ConfirmarSenha();
            form.nome = txtNome.Text;
            form.email = txtEmail.Text;
            if(txtNovaSenha.Text == txtConfirmarSenha.Text) { 
            form.Novasenha = txtNovaSenha.Text;
            form.FormularioPai = this.FormularioPai;
            form.ShowDialog();
            }
        }
    }

        
}
