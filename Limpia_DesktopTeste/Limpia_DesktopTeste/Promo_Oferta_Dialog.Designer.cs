﻿namespace Limpia_DesktopTeste
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInicioPromo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPublicoPromo = new System.Windows.Forms.GroupBox();
            this.rdoContratante = new System.Windows.Forms.RadioButton();
            this.rdoPrestador = new System.Windows.Forms.RadioButton();
            this.rdoTodos = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditarPromo = new System.Windows.Forms.Button();
            this.txtDescricaoPromo = new System.Windows.Forms.TextBox();
            this.txtTituloPromo = new System.Windows.Forms.TextBox();
            this.txtResponsavelPromo = new System.Windows.Forms.TextBox();
            this.txtCodigoPromo = new System.Windows.Forms.TextBox();
            this.btnInativarPromo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpPublicoPromo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resumo da Oferta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Título: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(28, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Disponível durante";
            // 
            // dtInicioPromo
            // 
            this.dtInicioPromo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioPromo.Location = new System.Drawing.Point(138, 151);
            this.dtInicioPromo.Name = "dtInicioPromo";
            this.dtInicioPromo.Size = new System.Drawing.Size(59, 20);
            this.dtInicioPromo.TabIndex = 6;
            this.dtInicioPromo.Value = new System.DateTime(2023, 10, 18, 16, 30, 40, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(59, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2023, 10, 18, 16, 30, 40, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(199, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(28, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Público:";
            // 
            // grpPublicoPromo
            // 
            this.grpPublicoPromo.Controls.Add(this.rdoTodos);
            this.grpPublicoPromo.Controls.Add(this.rdoPrestador);
            this.grpPublicoPromo.Controls.Add(this.rdoContratante);
            this.grpPublicoPromo.Location = new System.Drawing.Point(77, 177);
            this.grpPublicoPromo.Name = "grpPublicoPromo";
            this.grpPublicoPromo.Size = new System.Drawing.Size(195, 30);
            this.grpPublicoPromo.TabIndex = 10;
            this.grpPublicoPromo.TabStop = false;
            // 
            // rdoContratante
            // 
            this.rdoContratante.AutoSize = true;
            this.rdoContratante.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoContratante.Location = new System.Drawing.Point(6, 10);
            this.rdoContratante.Name = "rdoContratante";
            this.rdoContratante.Size = new System.Drawing.Size(72, 16);
            this.rdoContratante.TabIndex = 0;
            this.rdoContratante.TabStop = true;
            this.rdoContratante.Text = "Contratante";
            this.rdoContratante.UseVisualStyleBackColor = true;
            // 
            // rdoPrestador
            // 
            this.rdoPrestador.AutoSize = true;
            this.rdoPrestador.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPrestador.Location = new System.Drawing.Point(84, 11);
            this.rdoPrestador.Name = "rdoPrestador";
            this.rdoPrestador.Size = new System.Drawing.Size(63, 16);
            this.rdoPrestador.TabIndex = 1;
            this.rdoPrestador.TabStop = true;
            this.rdoPrestador.Text = "Prestador";
            this.rdoPrestador.UseVisualStyleBackColor = true;
            // 
            // rdoTodos
            // 
            this.rdoTodos.AutoSize = true;
            this.rdoTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTodos.Location = new System.Drawing.Point(145, 11);
            this.rdoTodos.Name = "rdoTodos";
            this.rdoTodos.Size = new System.Drawing.Size(48, 16);
            this.rdoTodos.TabIndex = 2;
            this.rdoTodos.TabStop = true;
            this.rdoTodos.Text = "Todos";
            this.rdoTodos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(28, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Responsável:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(28, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Código:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(28, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Região:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sul",
            "Sudeste",
            "Norte",
            "Nordeste",
            "Centro-Oeste"});
            this.comboBox1.Location = new System.Drawing.Point(81, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Limpia_DesktopTeste.Properties.Resources.banheiro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(303, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 134);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditarPromo
            // 
            this.btnEditarPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(109)))));
            this.btnEditarPromo.FlatAppearance.BorderSize = 0;
            this.btnEditarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPromo.Location = new System.Drawing.Point(331, 284);
            this.btnEditarPromo.Name = "btnEditarPromo";
            this.btnEditarPromo.Size = new System.Drawing.Size(71, 23);
            this.btnEditarPromo.TabIndex = 18;
            this.btnEditarPromo.Text = "Editar";
            this.btnEditarPromo.UseVisualStyleBackColor = false;
            // 
            // txtDescricaoPromo
            // 
            this.txtDescricaoPromo.Enabled = false;
            this.txtDescricaoPromo.Location = new System.Drawing.Point(31, 71);
            this.txtDescricaoPromo.Name = "txtDescricaoPromo";
            this.txtDescricaoPromo.Size = new System.Drawing.Size(241, 20);
            this.txtDescricaoPromo.TabIndex = 19;
            // 
            // txtTituloPromo
            // 
            this.txtTituloPromo.Enabled = false;
            this.txtTituloPromo.Location = new System.Drawing.Point(79, 114);
            this.txtTituloPromo.Name = "txtTituloPromo";
            this.txtTituloPromo.Size = new System.Drawing.Size(193, 20);
            this.txtTituloPromo.TabIndex = 20;
            // 
            // txtResponsavelPromo
            // 
            this.txtResponsavelPromo.Enabled = false;
            this.txtResponsavelPromo.Location = new System.Drawing.Point(110, 226);
            this.txtResponsavelPromo.Name = "txtResponsavelPromo";
            this.txtResponsavelPromo.Size = new System.Drawing.Size(162, 20);
            this.txtResponsavelPromo.TabIndex = 21;
            // 
            // txtCodigoPromo
            // 
            this.txtCodigoPromo.Enabled = false;
            this.txtCodigoPromo.Location = new System.Drawing.Point(82, 259);
            this.txtCodigoPromo.Name = "txtCodigoPromo";
            this.txtCodigoPromo.Size = new System.Drawing.Size(190, 20);
            this.txtCodigoPromo.TabIndex = 22;
            // 
            // btnInativarPromo
            // 
            this.btnInativarPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(87)))), ((int)(((byte)(189)))));
            this.btnInativarPromo.FlatAppearance.BorderSize = 0;
            this.btnInativarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativarPromo.Location = new System.Drawing.Point(428, 284);
            this.btnInativarPromo.Name = "btnInativarPromo";
            this.btnInativarPromo.Size = new System.Drawing.Size(75, 23);
            this.btnInativarPromo.TabIndex = 23;
            this.btnInativarPromo.Text = "Inativar";
            this.btnInativarPromo.UseVisualStyleBackColor = false;
            // 
            // Promo_Oferta_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 331);
            this.Controls.Add(this.btnInativarPromo);
            this.Controls.Add(this.txtCodigoPromo);
            this.Controls.Add(this.txtResponsavelPromo);
            this.Controls.Add(this.txtTituloPromo);
            this.Controls.Add(this.txtDescricaoPromo);
            this.Controls.Add(this.btnEditarPromo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpPublicoPromo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtInicioPromo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Promo_Oferta_Dialog";
            this.Text = "Promo_Oferta_Dialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpPublicoPromo.ResumeLayout(false);
            this.grpPublicoPromo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInicioPromo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.Button btnEditarPromo;
        private System.Windows.Forms.TextBox txtDescricaoPromo;
        private System.Windows.Forms.TextBox txtTituloPromo;
        private System.Windows.Forms.TextBox txtResponsavelPromo;
        private System.Windows.Forms.TextBox txtCodigoPromo;
        private System.Windows.Forms.Button btnInativarPromo;
    }
}