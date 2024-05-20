namespace cartorio21
{
    partial class FormImportaTitulo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQtdTiulos = new System.Windows.Forms.Label();
            this.btnExcluirSelecionados = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.edtDocumentoCredor = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.edtNomeCredor = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.edtDocumentoApresentante = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.edtNomeApresentante = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edtDocDevedor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edtNomeDevedor = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.edtEspecie = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtEmissao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtApresentacaoFinal = new System.Windows.Forms.MaskedTextBox();
            this.dtApresentacaoInicio = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edtProtocolo = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbQtdTiulos);
            this.panel1.Controls.Add(this.btnExcluirSelecionados);
            this.panel1.Controls.Add(this.btnImportar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 33);
            this.panel1.TabIndex = 0;
            // 
            // lbQtdTiulos
            // 
            this.lbQtdTiulos.AutoSize = true;
            this.lbQtdTiulos.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbQtdTiulos.Location = new System.Drawing.Point(604, 0);
            this.lbQtdTiulos.Name = "lbQtdTiulos";
            this.lbQtdTiulos.Padding = new System.Windows.Forms.Padding(10);
            this.lbQtdTiulos.Size = new System.Drawing.Size(134, 33);
            this.lbQtdTiulos.TabIndex = 4;
            this.lbQtdTiulos.Text = "Quantidade de Titulos:";
            // 
            // btnExcluirSelecionados
            // 
            this.btnExcluirSelecionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcluirSelecionados.Location = new System.Drawing.Point(738, 0);
            this.btnExcluirSelecionados.Name = "btnExcluirSelecionados";
            this.btnExcluirSelecionados.Size = new System.Drawing.Size(151, 33);
            this.btnExcluirSelecionados.TabIndex = 3;
            this.btnExcluirSelecionados.Text = "EXCLUIR SELECIONADOS";
            this.btnExcluirSelecionados.UseVisualStyleBackColor = true;
            this.btnExcluirSelecionados.Click += new System.EventHandler(this.btnExcluirSelecionados_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportar.Location = new System.Drawing.Point(0, 0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(166, 33);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 489);
            this.panel2.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.edtDocumentoCredor);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(0, 414);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(166, 45);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Documento Credor";
            // 
            // edtDocumentoCredor
            // 
            this.edtDocumentoCredor.Location = new System.Drawing.Point(6, 15);
            this.edtDocumentoCredor.Name = "edtDocumentoCredor";
            this.edtDocumentoCredor.Size = new System.Drawing.Size(154, 20);
            this.edtDocumentoCredor.TabIndex = 1;
            this.edtDocumentoCredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.edtNomeCredor);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(0, 367);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(166, 47);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Nome Credor";
            // 
            // edtNomeCredor
            // 
            this.edtNomeCredor.Location = new System.Drawing.Point(6, 17);
            this.edtNomeCredor.Name = "edtNomeCredor";
            this.edtNomeCredor.Size = new System.Drawing.Size(154, 20);
            this.edtNomeCredor.TabIndex = 1;
            this.edtNomeCredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.edtDocumentoApresentante);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(0, 322);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(166, 45);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Documento Apresentante";
            // 
            // edtDocumentoApresentante
            // 
            this.edtDocumentoApresentante.Location = new System.Drawing.Point(6, 15);
            this.edtDocumentoApresentante.Name = "edtDocumentoApresentante";
            this.edtDocumentoApresentante.Size = new System.Drawing.Size(154, 20);
            this.edtDocumentoApresentante.TabIndex = 1;
            this.edtDocumentoApresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.edtNomeApresentante);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 275);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(166, 47);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nome Apresentante";
            // 
            // edtNomeApresentante
            // 
            this.edtNomeApresentante.Location = new System.Drawing.Point(6, 17);
            this.edtNomeApresentante.Name = "edtNomeApresentante";
            this.edtNomeApresentante.Size = new System.Drawing.Size(154, 20);
            this.edtNomeApresentante.TabIndex = 1;
            this.edtNomeApresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.edtDocDevedor);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 230);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 45);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Documento Devedor";
            // 
            // edtDocDevedor
            // 
            this.edtDocDevedor.Location = new System.Drawing.Point(6, 15);
            this.edtDocDevedor.Name = "edtDocDevedor";
            this.edtDocDevedor.Size = new System.Drawing.Size(154, 20);
            this.edtDocDevedor.TabIndex = 1;
            this.edtDocDevedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edtNomeDevedor);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 183);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nome Devedor";
            // 
            // edtNomeDevedor
            // 
            this.edtNomeDevedor.Location = new System.Drawing.Point(6, 17);
            this.edtNomeDevedor.Name = "edtNomeDevedor";
            this.edtNomeDevedor.Size = new System.Drawing.Size(154, 20);
            this.edtNomeDevedor.TabIndex = 1;
            this.edtNomeDevedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.edtEspecie);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 135);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 48);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Espécie do Titulo";
            // 
            // edtEspecie
            // 
            this.edtEspecie.Location = new System.Drawing.Point(6, 19);
            this.edtEspecie.Name = "edtEspecie";
            this.edtEspecie.Size = new System.Drawing.Size(154, 20);
            this.edtEspecie.TabIndex = 2;
            this.edtEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtEmissao);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 88);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 47);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Emissão";
            // 
            // dtEmissao
            // 
            this.dtEmissao.Location = new System.Drawing.Point(6, 17);
            this.dtEmissao.Mask = "00/00/0000";
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(154, 20);
            this.dtEmissao.TabIndex = 1;
            this.dtEmissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtApresentacaoFinal);
            this.groupBox2.Controls.Add(this.dtApresentacaoInicio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 47);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data de Apresentação";
            // 
            // dtApresentacaoFinal
            // 
            this.dtApresentacaoFinal.Location = new System.Drawing.Point(91, 19);
            this.dtApresentacaoFinal.Mask = "00/00/0000";
            this.dtApresentacaoFinal.Name = "dtApresentacaoFinal";
            this.dtApresentacaoFinal.Size = new System.Drawing.Size(69, 20);
            this.dtApresentacaoFinal.TabIndex = 1;
            this.dtApresentacaoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // dtApresentacaoInicio
            // 
            this.dtApresentacaoInicio.Location = new System.Drawing.Point(6, 19);
            this.dtApresentacaoInicio.Mask = "00/00/0000";
            this.dtApresentacaoInicio.Name = "dtApresentacaoInicio";
            this.dtApresentacaoInicio.Size = new System.Drawing.Size(69, 20);
            this.dtApresentacaoInicio.TabIndex = 0;
            this.dtApresentacaoInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtProtocolo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 41);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocolo";
            // 
            // edtProtocolo
            // 
            this.edtProtocolo.Location = new System.Drawing.Point(6, 15);
            this.edtProtocolo.Name = "edtProtocolo";
            this.edtProtocolo.Size = new System.Drawing.Size(154, 20);
            this.edtProtocolo.TabIndex = 0;
            this.edtProtocolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 466);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(166, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTitulos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(166, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 489);
            this.panel3.TabIndex = 2;
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.AllowUserToAddRows = false;
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTitulos.Location = new System.Drawing.Point(0, 0);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.Size = new System.Drawing.Size(723, 489);
            this.dgvTitulos.TabIndex = 0;
            this.dgvTitulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTitulos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // FormImportaTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 522);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormImportaTitulo";
            this.Text = "Protesto21";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirSelecionados;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox edtDocDevedor;
        private System.Windows.Forms.TextBox edtNomeDevedor;
        private System.Windows.Forms.TextBox edtProtocolo;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private System.Windows.Forms.TextBox edtEspecie;
        private System.Windows.Forms.Label lbQtdTiulos;
        private System.Windows.Forms.MaskedTextBox dtApresentacaoInicio;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox edtDocumentoCredor;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox edtNomeCredor;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox edtDocumentoApresentante;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox edtNomeApresentante;
        private System.Windows.Forms.MaskedTextBox dtEmissao;
        private System.Windows.Forms.MaskedTextBox dtApresentacaoFinal;
        private System.Windows.Forms.Label label1;
    }
}

