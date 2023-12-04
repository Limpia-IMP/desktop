namespace Limpia_DesktopTeste
{
    partial class Promo_Oferta_Dialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promo_Oferta_Dialog));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicioPromo = new System.Windows.Forms.DateTimePicker();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPublicoPromo = new System.Windows.Forms.GroupBox();
            this.rdoTodos = new System.Windows.Forms.RadioButton();
            this.rdoPrestador = new System.Windows.Forms.RadioButton();
            this.rdoContratante = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDescricaoPromo = new System.Windows.Forms.TextBox();
            this.txtTituloPromo = new System.Windows.Forms.TextBox();
            this.txtResponsavelPromo = new System.Windows.Forms.TextBox();
            this.txtCodigoPromo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEditarPromo = new Limpia_DesktopTeste.BtnLimpia.btnPrincipal();
            this.btnInativarPromo = new Limpia_DesktopTeste.BtnLimpia.btnPrincipal();
            this.btnSalvar = new Limpia_DesktopTeste.BtnLimpia.btnPrincipal();
            this.grpPublicoPromo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(5, 6);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(34, 37);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(63, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resumo da Oferta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(63, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Título: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(63, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Disponível durante:";
            // 
            // dtpInicioPromo
            // 
            this.dtpInicioPromo.Enabled = false;
            this.dtpInicioPromo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioPromo.Location = new System.Drawing.Point(176, 223);
            this.dtpInicioPromo.Name = "dtpInicioPromo";
            this.dtpInicioPromo.Size = new System.Drawing.Size(59, 20);
            this.dtpInicioPromo.TabIndex = 6;
            this.dtpInicioPromo.Value = new System.DateTime(2023, 10, 18, 16, 30, 40, 0);
            // 
            // dtpValidade
            // 
            this.dtpValidade.Enabled = false;
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(252, 223);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(59, 20);
            this.dtpValidade.TabIndex = 7;
            this.dtpValidade.Value = new System.DateTime(2023, 10, 18, 16, 30, 40, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(236, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(63, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Público:";
            // 
            // grpPublicoPromo
            // 
            this.grpPublicoPromo.Controls.Add(this.rdoTodos);
            this.grpPublicoPromo.Controls.Add(this.rdoPrestador);
            this.grpPublicoPromo.Controls.Add(this.rdoContratante);
            this.grpPublicoPromo.Enabled = false;
            this.grpPublicoPromo.Location = new System.Drawing.Point(112, 249);
            this.grpPublicoPromo.Name = "grpPublicoPromo";
            this.grpPublicoPromo.Size = new System.Drawing.Size(195, 30);
            this.grpPublicoPromo.TabIndex = 10;
            this.grpPublicoPromo.TabStop = false;
            // 
            // rdoTodos
            // 
            this.rdoTodos.AutoSize = true;
            this.rdoTodos.Enabled = false;
            this.rdoTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTodos.Location = new System.Drawing.Point(145, 11);
            this.rdoTodos.Name = "rdoTodos";
            this.rdoTodos.Size = new System.Drawing.Size(48, 16);
            this.rdoTodos.TabIndex = 2;
            this.rdoTodos.TabStop = true;
            this.rdoTodos.Text = "Todos";
            this.rdoTodos.UseVisualStyleBackColor = true;
            // 
            // rdoPrestador
            // 
            this.rdoPrestador.AutoSize = true;
            this.rdoPrestador.Enabled = false;
            this.rdoPrestador.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrestador.Location = new System.Drawing.Point(84, 11);
            this.rdoPrestador.Name = "rdoPrestador";
            this.rdoPrestador.Size = new System.Drawing.Size(63, 16);
            this.rdoPrestador.TabIndex = 1;
            this.rdoPrestador.TabStop = true;
            this.rdoPrestador.Text = "Prestador";
            this.rdoPrestador.UseVisualStyleBackColor = true;
            // 
            // rdoContratante
            // 
            this.rdoContratante.AutoSize = true;
            this.rdoContratante.Enabled = false;
            this.rdoContratante.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoContratante.Location = new System.Drawing.Point(6, 10);
            this.rdoContratante.Name = "rdoContratante";
            this.rdoContratante.Size = new System.Drawing.Size(72, 16);
            this.rdoContratante.TabIndex = 0;
            this.rdoContratante.TabStop = true;
            this.rdoContratante.Text = "Contratante";
            this.rdoContratante.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(63, 301);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Responsável:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(63, 332);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Código:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(63, 364);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Região:";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sul",
            "Sudeste",
            "Norte",
            "Nordeste",
            "Centro-Oeste"});
            this.comboBox1.Location = new System.Drawing.Point(116, 362);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // txtDescricaoPromo
            // 
            this.txtDescricaoPromo.Enabled = false;
            this.txtDescricaoPromo.Location = new System.Drawing.Point(66, 106);
            this.txtDescricaoPromo.Multiline = true;
            this.txtDescricaoPromo.Name = "txtDescricaoPromo";
            this.txtDescricaoPromo.Size = new System.Drawing.Size(245, 64);
            this.txtDescricaoPromo.TabIndex = 19;
            // 
            // txtTituloPromo
            // 
            this.txtTituloPromo.Enabled = false;
            this.txtTituloPromo.Location = new System.Drawing.Point(114, 185);
            this.txtTituloPromo.Name = "txtTituloPromo";
            this.txtTituloPromo.Size = new System.Drawing.Size(197, 20);
            this.txtTituloPromo.TabIndex = 20;
            // 
            // txtResponsavelPromo
            // 
            this.txtResponsavelPromo.Enabled = false;
            this.txtResponsavelPromo.Location = new System.Drawing.Point(146, 299);
            this.txtResponsavelPromo.Name = "txtResponsavelPromo";
            this.txtResponsavelPromo.Size = new System.Drawing.Size(165, 20);
            this.txtResponsavelPromo.TabIndex = 21;
            // 
            // txtCodigoPromo
            // 
            this.txtCodigoPromo.Enabled = false;
            this.txtCodigoPromo.Location = new System.Drawing.Point(117, 332);
            this.txtCodigoPromo.Name = "txtCodigoPromo";
            this.txtCodigoPromo.Size = new System.Drawing.Size(194, 20);
            this.txtCodigoPromo.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Limpia_DesktopTeste.Properties.Resources.banheiro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(349, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 163);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEditarPromo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnInativarPromo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCodigoPromo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtResponsavelPromo);
            this.panel1.Controls.Add(this.dtpInicioPromo);
            this.panel1.Controls.Add(this.txtTituloPromo);
            this.panel1.Controls.Add(this.dtpValidade);
            this.panel1.Controls.Add(this.txtDescricaoPromo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.grpPublicoPromo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(96, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 472);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 49);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oferta Personalizada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Limpia_DesktopTeste.Properties.Resources.ellipse_suporte_roxo;
            this.pictureBox3.Location = new System.Drawing.Point(-16, -21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(243, 278);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Limpia_DesktopTeste.Properties.Resources.ellipse_suporte_verde;
            this.pictureBox2.Location = new System.Drawing.Point(604, 375);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btnEditarPromo
            // 
            this.btnEditarPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(109)))));
            this.btnEditarPromo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(109)))));
            this.btnEditarPromo.BorderColor = System.Drawing.Color.White;
            this.btnEditarPromo.BorderRadius = 32;
            this.btnEditarPromo.BorderSize = 0;
            this.btnEditarPromo.FlatAppearance.BorderSize = 0;
            this.btnEditarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPromo.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPromo.Location = new System.Drawing.Point(349, 290);
            this.btnEditarPromo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPromo.Name = "btnEditarPromo";
            this.btnEditarPromo.Size = new System.Drawing.Size(98, 32);
            this.btnEditarPromo.TabIndex = 25;
            this.btnEditarPromo.Text = "Editar";
            this.btnEditarPromo.TextColor = System.Drawing.Color.Black;
            this.btnEditarPromo.UseVisualStyleBackColor = false;
            this.btnEditarPromo.Click += new System.EventHandler(this.btnEditarPromo_Click);
            // 
            // btnInativarPromo
            // 
            this.btnInativarPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(87)))), ((int)(((byte)(189)))));
            this.btnInativarPromo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(87)))), ((int)(((byte)(189)))));
            this.btnInativarPromo.BorderColor = System.Drawing.Color.Aqua;
            this.btnInativarPromo.BorderRadius = 32;
            this.btnInativarPromo.BorderSize = 0;
            this.btnInativarPromo.FlatAppearance.BorderSize = 0;
            this.btnInativarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativarPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativarPromo.ForeColor = System.Drawing.Color.Black;
            this.btnInativarPromo.Location = new System.Drawing.Point(480, 290);
            this.btnInativarPromo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInativarPromo.Name = "btnInativarPromo";
            this.btnInativarPromo.Size = new System.Drawing.Size(98, 32);
            this.btnInativarPromo.TabIndex = 24;
            this.btnInativarPromo.Text = "Inativar";
            this.btnInativarPromo.TextColor = System.Drawing.Color.Black;
            this.btnInativarPromo.UseVisualStyleBackColor = false;
            this.btnInativarPromo.Click += new System.EventHandler(this.btnInativarPromo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(87)))), ((int)(((byte)(189)))));
            this.btnSalvar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(87)))), ((int)(((byte)(189)))));
            this.btnSalvar.BorderColor = System.Drawing.Color.Aqua;
            this.btnSalvar.BorderRadius = 32;
            this.btnSalvar.BorderSize = 0;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(480, 332);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 32);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.Black;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Promo_Oferta_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(828, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Promo_Oferta_Dialog";
            this.Text = "Promo_Oferta_Dialog";
            this.grpPublicoPromo.ResumeLayout(false);
            this.grpPublicoPromo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicioPromo;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpPublicoPromo;
        private System.Windows.Forms.RadioButton rdoTodos;
        private System.Windows.Forms.RadioButton rdoPrestador;
        private System.Windows.Forms.RadioButton rdoContratante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescricaoPromo;
        private System.Windows.Forms.TextBox txtTituloPromo;
        private System.Windows.Forms.TextBox txtResponsavelPromo;
        private System.Windows.Forms.TextBox txtCodigoPromo;
        private BtnLimpia.btnPrincipal btnInativarPromo;
        private BtnLimpia.btnPrincipal btnEditarPromo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private BtnLimpia.btnPrincipal btnSalvar;
    }
}