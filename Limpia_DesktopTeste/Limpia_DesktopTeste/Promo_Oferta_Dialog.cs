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
    public partial class Promo_Oferta_Dialog : Form
    {
        public principal FormularioPai { get; set; }

        public ClsBanco.Promo promocaoAtual;

        ClsBanco banco = new ClsBanco();

        public void CarregarDados()
        {
            txtTituloPromo.Text = promocaoAtual.nome;
            dtpValidade.Value = promocaoAtual.validade_fim;
            dtpInicioPromo.Value = promocaoAtual.validade_inic;
            txtDescricaoPromo.Text = promocaoAtual.descricao;

            /*codigo publico 1 - todos, 2 - contratantes, 3 - prestadores*/
            int rdo = promocaoAtual.publ;
            if (rdo == 1) { rdoTodos.Select(); }
            if (rdo == 2) { rdoContratante.Select(); }
            if (rdo == 3) { rdoPrestador.Select(); }

            SqlDataReader func = banco.Select("tblfunc", "nome", 1, "nome =" + promocaoAtual.IdFuncPromo);

            txtResponsavelPromo.Text = func.GetString(0);
            txtCodigoPromo.Text = promocaoAtual.codigo;

            //codigo regiao 0 - sudeste, 1 - nordeste, 2 - norte, 3 - centro - oeste, 4 - sul, 5 - todos
            int cmb = promocaoAtual.region;
            if (cmb == 0) { comboBox1.Text = "Sudeste"; }
            if (cmb == 1) { comboBox1.Text = "Nordeste"; }
            if (cmb == 2) { comboBox1.Text = "Norte"; }
            if (cmb == 3) { comboBox1.Text = "Centro-Oeste"; }
            if (cmb == 4) { comboBox1.Text = "Sul"; }
            if (cmb == 5) { comboBox1.Text = "Todas"; }
        }

        public Promo_Oferta_Dialog()
        {
            InitializeComponent();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {

            promo_ofertas form = new promo_ofertas();
            FormularioPai.openChildForm(form);
            form.FormularioPai = this.FormularioPai;
            this.Close();
        }

        private void btnEditarPromo_Click(object sender, EventArgs e)
        {
            txtCodigoPromo.Enabled = true;
            txtDescricaoPromo.Enabled = true;
            txtResponsavelPromo.Enabled = true;
            comboBox1.Enabled = true;
            grpPublicoPromo.Enabled = true;
            dtpInicioPromo.Enabled = true;
            dtpValidade.Enabled = true;
            txtTituloPromo.Enabled = true;
        }

        private void btnInativarPromo_Click(object sender, EventArgs e)
        {
            banco.deleteInfo("tblpromo", promocaoAtual.idpromo);

            txtCodigoPromo.Text = "";
            txtDescricaoPromo.Text = "";
            txtResponsavelPromo.Text = "";
            comboBox1.Text = "";
            grpPublicoPromo.Text = "";
            dtpInicioPromo.Text = "";
            dtpValidade.Text = "";
            txtTituloPromo.Text = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
