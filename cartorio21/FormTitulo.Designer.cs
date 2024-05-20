namespace cartorio21
{
    partial class FormTitulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbProtocolo = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bttnExcluir = new System.Windows.Forms.Button();
            this.edtProtocolo = new System.Windows.Forms.TextBox();
            this.edtNumerotit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtValorTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtValorCustas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtApresentacao = new System.Windows.Forms.DateTimePicker();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.edtDocApresentante = new System.Windows.Forms.TextBox();
            this.edtNomeApresentante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edtDocDevedor = new System.Windows.Forms.TextBox();
            this.edtNomeDevedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edtDocCredor = new System.Windows.Forms.TextBox();
            this.edtNomeCredor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtEspecie = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCreate = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbArquivo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtEspecie);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtEmissao);
            this.groupBox1.Controls.Add(this.dtApresentacao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edtValorCustas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edtValorTitulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edtNumerotit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edtProtocolo);
            this.groupBox1.Controls.Add(this.lbProtocolo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Titulo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttnExcluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 42);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.edtDocApresentante);
            this.groupBox2.Controls.Add(this.edtNomeApresentante);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apresentante:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.edtDocDevedor);
            this.groupBox3.Controls.Add(this.edtNomeDevedor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(0, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(819, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Devedor:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.edtDocCredor);
            this.groupBox4.Controls.Add(this.edtNomeCredor);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(0, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(819, 59);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Credor:";
            // 
            // lbProtocolo
            // 
            this.lbProtocolo.AutoSize = true;
            this.lbProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbProtocolo.Location = new System.Drawing.Point(12, 28);
            this.lbProtocolo.Name = "lbProtocolo";
            this.lbProtocolo.Size = new System.Drawing.Size(80, 20);
            this.lbProtocolo.TabIndex = 0;
            this.lbProtocolo.Text = "Protocolo:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAlterar.Location = new System.Drawing.Point(392, 7);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(178, 29);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Habilitar Alteração";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(576, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 29);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bttnExcluir
            // 
            this.bttnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnExcluir.Location = new System.Drawing.Point(697, 7);
            this.bttnExcluir.Name = "bttnExcluir";
            this.bttnExcluir.Size = new System.Drawing.Size(115, 29);
            this.bttnExcluir.TabIndex = 2;
            this.bttnExcluir.Text = "Excluir";
            this.bttnExcluir.UseVisualStyleBackColor = true;
            this.bttnExcluir.Click += new System.EventHandler(this.bttnExcluir_Click);
            // 
            // edtProtocolo
            // 
            this.edtProtocolo.Enabled = false;
            this.edtProtocolo.Location = new System.Drawing.Point(98, 25);
            this.edtProtocolo.MaxLength = 7;
            this.edtProtocolo.Name = "edtProtocolo";
            this.edtProtocolo.Size = new System.Drawing.Size(139, 26);
            this.edtProtocolo.TabIndex = 1;
            // 
            // edtNumerotit
            // 
            this.edtNumerotit.Enabled = false;
            this.edtNumerotit.Location = new System.Drawing.Point(98, 57);
            this.edtNumerotit.Name = "edtNumerotit";
            this.edtNumerotit.Size = new System.Drawing.Size(139, 26);
            this.edtNumerotit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(530, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Apresentação:";
            // 
            // edtValorTitulo
            // 
            this.edtValorTitulo.Enabled = false;
            this.edtValorTitulo.Location = new System.Drawing.Point(368, 60);
            this.edtValorTitulo.Name = "edtValorTitulo";
            this.edtValorTitulo.Size = new System.Drawing.Size(139, 26);
            this.edtValorTitulo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(530, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Emissão:";
            // 
            // edtValorCustas
            // 
            this.edtValorCustas.Enabled = false;
            this.edtValorCustas.Location = new System.Drawing.Point(368, 25);
            this.edtValorCustas.Name = "edtValorCustas";
            this.edtValorCustas.Size = new System.Drawing.Size(139, 26);
            this.edtValorCustas.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(258, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Custas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(258, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Titulo:";
            // 
            // dtApresentacao
            // 
            this.dtApresentacao.Enabled = false;
            this.dtApresentacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtApresentacao.Location = new System.Drawing.Point(688, 25);
            this.dtApresentacao.Name = "dtApresentacao";
            this.dtApresentacao.Size = new System.Drawing.Size(119, 26);
            this.dtApresentacao.TabIndex = 11;
            // 
            // dtEmissao
            // 
            this.dtEmissao.Enabled = false;
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmissao.Location = new System.Drawing.Point(688, 60);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(119, 26);
            this.dtEmissao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(530, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Documento:";
            // 
            // edtDocApresentante
            // 
            this.edtDocApresentante.Enabled = false;
            this.edtDocApresentante.Location = new System.Drawing.Point(628, 24);
            this.edtDocApresentante.Name = "edtDocApresentante";
            this.edtDocApresentante.Size = new System.Drawing.Size(179, 26);
            this.edtDocApresentante.TabIndex = 13;
            // 
            // edtNomeApresentante
            // 
            this.edtNomeApresentante.Enabled = false;
            this.edtNomeApresentante.Location = new System.Drawing.Point(98, 24);
            this.edtNomeApresentante.Name = "edtNomeApresentante";
            this.edtNomeApresentante.Size = new System.Drawing.Size(409, 26);
            this.edtNomeApresentante.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(530, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Documento:";
            // 
            // edtDocDevedor
            // 
            this.edtDocDevedor.Enabled = false;
            this.edtDocDevedor.Location = new System.Drawing.Point(628, 25);
            this.edtDocDevedor.Name = "edtDocDevedor";
            this.edtDocDevedor.Size = new System.Drawing.Size(179, 26);
            this.edtDocDevedor.TabIndex = 17;
            // 
            // edtNomeDevedor
            // 
            this.edtNomeDevedor.Enabled = false;
            this.edtNomeDevedor.Location = new System.Drawing.Point(98, 25);
            this.edtNomeDevedor.Name = "edtNomeDevedor";
            this.edtNomeDevedor.Size = new System.Drawing.Size(409, 26);
            this.edtNomeDevedor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(530, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Documento:";
            // 
            // edtDocCredor
            // 
            this.edtDocCredor.Enabled = false;
            this.edtDocCredor.Location = new System.Drawing.Point(628, 25);
            this.edtDocCredor.Name = "edtDocCredor";
            this.edtDocCredor.Size = new System.Drawing.Size(179, 26);
            this.edtDocCredor.TabIndex = 17;
            // 
            // edtNomeCredor
            // 
            this.edtNomeCredor.Enabled = false;
            this.edtNomeCredor.Location = new System.Drawing.Point(98, 25);
            this.edtNomeCredor.Name = "edtNomeCredor";
            this.edtNomeCredor.Size = new System.Drawing.Size(409, 26);
            this.edtNomeCredor.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(12, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nome:";
            // 
            // edtEspecie
            // 
            this.edtEspecie.Enabled = false;
            this.edtEspecie.Location = new System.Drawing.Point(98, 92);
            this.edtEspecie.Name = "edtEspecie";
            this.edtEspecie.Size = new System.Drawing.Size(409, 26);
            this.edtEspecie.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(12, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Espécie:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbArquivo);
            this.panel2.Controls.Add(this.lbUpdate);
            this.panel2.Controls.Add(this.lbCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 31);
            this.panel2.TabIndex = 5;
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbCreate.Location = new System.Drawing.Point(10, 7);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(67, 15);
            this.lbCreate.TabIndex = 19;
            this.lbCreate.Text = "Criado em:";
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbUpdate.Location = new System.Drawing.Point(174, 7);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(112, 15);
            this.lbUpdate.TabIndex = 20;
            this.lbUpdate.Text = "Ultima Atualização:";
            // 
            // lbArquivo
            // 
            this.lbArquivo.AutoSize = true;
            this.lbArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbArquivo.Location = new System.Drawing.Point(401, 7);
            this.lbArquivo.Name = "lbArquivo";
            this.lbArquivo.Size = new System.Drawing.Size(169, 15);
            this.lbArquivo.TabIndex = 21;
            this.lbArquivo.Text = "Nome Arquivo de Importação:";
            // 
            // FormTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTitulo";
            this.Text = "Titulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbProtocolo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtValorCustas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtValorTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtNumerotit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtProtocolo;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        private System.Windows.Forms.DateTimePicker dtApresentacao;
        private System.Windows.Forms.TextBox edtEspecie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtDocApresentante;
        private System.Windows.Forms.TextBox edtNomeApresentante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edtDocDevedor;
        private System.Windows.Forms.TextBox edtNomeDevedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtDocCredor;
        private System.Windows.Forms.TextBox edtNomeCredor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbArquivo;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbCreate;
    }
}