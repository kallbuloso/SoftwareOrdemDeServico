﻿namespace View.Pessoas
{
    partial class Frm_PessoaJuridica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PessoaJuridica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_RazaoSocial = new System.Windows.Forms.TextBox();
            this.Txt_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Contato = new System.Windows.Forms.MaskedTextBox();
            this.Txt_InscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btm_Salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_Estado = new System.Windows.Forms.ComboBox();
            this.Txt_Observacoes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Situacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Cep = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Txt_RazaoSocial);
            this.panel1.Controls.Add(this.Txt_CNPJ);
            this.panel1.Controls.Add(this.Txt_Contato);
            this.panel1.Controls.Add(this.Txt_InscricaoEstadual);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-11, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 131);
            this.panel1.TabIndex = 18;
            // 
            // Txt_RazaoSocial
            // 
            this.Txt_RazaoSocial.Location = new System.Drawing.Point(525, 58);
            this.Txt_RazaoSocial.Name = "Txt_RazaoSocial";
            this.Txt_RazaoSocial.Size = new System.Drawing.Size(236, 20);
            this.Txt_RazaoSocial.TabIndex = 7;
            // 
            // Txt_CNPJ
            // 
            this.Txt_CNPJ.Location = new System.Drawing.Point(67, 16);
            this.Txt_CNPJ.Mask = "000.000.000-00";
            this.Txt_CNPJ.Name = "Txt_CNPJ";
            this.Txt_CNPJ.Size = new System.Drawing.Size(235, 20);
            this.Txt_CNPJ.TabIndex = 1;
            // 
            // Txt_Contato
            // 
            this.Txt_Contato.Location = new System.Drawing.Point(67, 61);
            this.Txt_Contato.Name = "Txt_Contato";
            this.Txt_Contato.Size = new System.Drawing.Size(235, 20);
            this.Txt_Contato.TabIndex = 3;
            // 
            // Txt_InscricaoEstadual
            // 
            this.Txt_InscricaoEstadual.Location = new System.Drawing.Point(525, 13);
            this.Txt_InscricaoEstadual.Name = "Txt_InscricaoEstadual";
            this.Txt_InscricaoEstadual.Size = new System.Drawing.Size(235, 20);
            this.Txt_InscricaoEstadual.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(425, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Inscrição Estadual";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Razão Social";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Contato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CNPJ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btm_Salvar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Btm_Salvar
            // 
            this.Btm_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("Btm_Salvar.Image")));
            this.Btm_Salvar.Name = "Btm_Salvar";
            this.Btm_Salvar.Size = new System.Drawing.Size(66, 20);
            this.Btm_Salvar.Text = "Salvar";
            this.Btm_Salvar.Click += new System.EventHandler(this.Btm_Salvar_Click);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.FormattingEnabled = true;
            this.Txt_Estado.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia  - BA",
            "Ceará - CE",
            "Distrito Federal  - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.Txt_Estado.Location = new System.Drawing.Point(63, 219);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(236, 21);
            this.Txt_Estado.TabIndex = 9;
            // 
            // Txt_Observacoes
            // 
            this.Txt_Observacoes.Location = new System.Drawing.Point(513, 172);
            this.Txt_Observacoes.Multiline = true;
            this.Txt_Observacoes.Name = "Txt_Observacoes";
            this.Txt_Observacoes.Size = new System.Drawing.Size(236, 73);
            this.Txt_Observacoes.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Observações";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CEP";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(513, 88);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(236, 20);
            this.Txt_Bairro.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bairro";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(513, 53);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(236, 20);
            this.Txt_Cidade.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // Txt_Situacao
            // 
            this.Txt_Situacao.Location = new System.Drawing.Point(63, 172);
            this.Txt_Situacao.Name = "Txt_Situacao";
            this.Txt_Situacao.Size = new System.Drawing.Size(236, 20);
            this.Txt_Situacao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Situação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // Txt_Endereco
            // 
            this.Txt_Endereco.Location = new System.Drawing.Point(63, 88);
            this.Txt_Endereco.Name = "Txt_Endereco";
            this.Txt_Endereco.Size = new System.Drawing.Size(236, 20);
            this.Txt_Endereco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(63, 50);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(236, 20);
            this.Txt_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(64, 130);
            this.Txt_Telefone.Mask = "(00)90000-0000";
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(235, 20);
            this.Txt_Telefone.TabIndex = 20;
            // 
            // Txt_Cep
            // 
            this.Txt_Cep.Location = new System.Drawing.Point(513, 127);
            this.Txt_Cep.Mask = "99999-999";
            this.Txt_Cep.Name = "Txt_Cep";
            this.Txt_Cep.Size = new System.Drawing.Size(235, 20);
            this.Txt_Cep.TabIndex = 21;
            this.Txt_Cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_PessoaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 395);
            this.Controls.Add(this.Txt_Cep);
            this.Controls.Add(this.Txt_Telefone);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.Txt_Observacoes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Situacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_PessoaJuridica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa Jurídica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox Txt_CNPJ;
        private System.Windows.Forms.MaskedTextBox Txt_Contato;
        private System.Windows.Forms.MaskedTextBox Txt_InscricaoEstadual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Btm_Salvar;
        private System.Windows.Forms.TextBox Txt_RazaoSocial;
        private System.Windows.Forms.ComboBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_Observacoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Situacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Txt_Telefone;
        private System.Windows.Forms.MaskedTextBox Txt_Cep;
    }
}