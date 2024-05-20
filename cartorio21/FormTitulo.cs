using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartorio21
{
    public partial class FormTitulo : Form
    {
        private int idTitulo;
        private Titulo titulo;
        ctrTitulo ctrTit = new ctrTitulo();
        public FormTitulo(int id)
        {
            idTitulo = id;
            InitializeComponent(); 
            preencherTela();
        }

        private void preencherTela()
        {
            titulo = ctrTit.AbrirPeloID(idTitulo);
            if (titulo != null)
            {
                edtProtocolo.Text = titulo.Protocolo;
                edtNumerotit.Text = titulo.NumeroTitulo;
                edtEspecie.Text = titulo.EspecieTitulo;
                edtValorCustas.Text = titulo.ValorCustas.ToString("N2");
                edtValorTitulo.Text = titulo.ValorTitulo.ToString("N2");
                dtApresentacao.Text = titulo.dtApresentacao.ToString("dd/MM/yyyy");
                dtEmissao.Text = titulo.DataEmissao.ToString("dd/MM/yyyy");
                edtNomeApresentante.Text = titulo.NomeApresentante;
                edtNomeCredor.Text = titulo.NomeCredor;
                edtNomeDevedor.Text = titulo.NomeDevedor;
                edtDocApresentante.Text = ctrUtil.FormatarCPFCNPJ(titulo.DocumentoApresentante);
                edtDocCredor.Text = ctrUtil.FormatarCPFCNPJ(titulo.DocumentoCredor);
                edtDocDevedor.Text = ctrUtil.FormatarCPFCNPJ(titulo.DocumentoDevedor);
                lbArquivo.Text = $"Nome Arquivo de Importação: {titulo.sArquivo}";
                lbCreate.Text = $"Criado em: {titulo.dtCreate.ToString("dd/MM/yyyy")}";
                lbUpdate.Text = $"Ultima Atualização: {titulo.dtUpdate.ToString("dd/MM/yyyy")}";
            }
            edtProtocolo.Enabled = false;
            edtNumerotit.Enabled = false;
            edtEspecie.Enabled = false;
            edtValorTitulo.Enabled = false;
            dtApresentacao.Enabled = false;
            dtEmissao.Enabled = false;
            edtNomeApresentante.Enabled = false;
            edtNomeCredor.Enabled = false;
            edtNomeDevedor.Enabled = false;
            edtDocApresentante.Enabled = false;
            edtDocCredor.Enabled = false;
            edtDocDevedor.Enabled = false;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            edtProtocolo.Enabled = true;
            edtNumerotit.Enabled = true;
            edtEspecie.Enabled = true;
            edtValorTitulo.Enabled = true;
            dtApresentacao.Enabled = true;
            dtEmissao.Enabled = true;
            edtNomeApresentante.Enabled = true;
            edtNomeCredor.Enabled = true;
            edtNomeDevedor.Enabled = true;
            edtDocApresentante.Enabled = true;
            edtDocCredor.Enabled = true;
            edtDocDevedor.Enabled = true;
        }

        private void bttnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ctrTit.Excluir(titulo.Id);
                MessageBox.Show("Título excluído com sucesso." , "Excluir titulos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir titulo!\n{erro}", "Excluir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (titulo != null)
                {
                    titulo.Protocolo = edtProtocolo.Text;
                    titulo.NumeroTitulo = edtNumerotit.Text;
                    titulo.EspecieTitulo = edtEspecie.Text;
                    titulo.ValorTitulo = decimal.Parse(edtValorTitulo.Text);
                    titulo.ValorCustas = ctrTit.calcularCustasTitulos(titulo.ValorTitulo);
                    titulo.dtApresentacao = DateTime.Parse(dtApresentacao.Text);
                    titulo.DataEmissao = DateTime.Parse(dtEmissao.Text);
                    titulo.NomeApresentante = edtNomeApresentante.Text;
                    titulo.NomeCredor = edtNomeCredor.Text;
                    titulo.NomeDevedor = edtNomeDevedor.Text;
                    titulo.DocumentoApresentante = ctrUtil.RetornarApenasNumeros(edtDocApresentante.Text);
                    titulo.DocumentoCredor = ctrUtil.RetornarApenasNumeros(edtDocCredor.Text);
                    titulo.DocumentoDevedor = ctrUtil.RetornarApenasNumeros(edtDocDevedor.Text);
                    titulo.dtUpdate = DateTime.Now;
                    ctrTit.UpdateTitulo(titulo);
                    MessageBox.Show("Título atualizado com sucesso.", "Alterar titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    preencherTela();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao alterar titulo!\n{erro}", "Alterar titulo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}
