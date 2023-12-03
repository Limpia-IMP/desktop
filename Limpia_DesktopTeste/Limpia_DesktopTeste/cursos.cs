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
    public partial class cursos : Form
    {
        public principal FormularioPai { get; set; }

        ClsBanco banco = new ClsBanco();
        public cursos()
        {
            InitializeComponent();
        }

         private void Cursos_Load(object sender, EventArgs e)
        {
            var cursos = banco.cursos();


            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }

            for (int i = 0; i < cursos.Count && i < this.Controls.Count; i++)
            {
                int iAtual = i;
                var current = cursos[i];
                var control = this.Controls[i];

                control.Visible = true;

                if (control is Panel panel)
                {
                    if (panel.Controls.Count >= 2)
                    {
                        // Considerando que o primeiro controle é uma Label para descrição
                        if (panel.Controls[0] is Label lblDesc)
                        {
                            lblDesc.Text = current.Duracao.ToString();
                        }

                        // E o segundo controle é uma Label para o nome
                        if (panel.Controls[1] is Label lblName)
                        {
                            lblName.Text = current.Nome;
                        }

                        // Atribuir o idcursos ao painel para uso posterior
                        panel.Name = current.Idcursos;
                    }
                }

                control.Click += (ee, s) =>
                {
                    var cursoAtual = cursos[iAtual];

                    CursosDialog cursos_dialog = new CursosDialog();
                    cursos_dialog.cursosAtual = cursoAtual;
                    cursos_dialog.CarregarDados();
                    cursos_dialog.FormularioPai = this.FormularioPai;  // Copia a referência do formulário principal
                    FormularioPai.openChildForm(cursos_dialog);
                    this.Close();
                };
            }
        }
    }
}
