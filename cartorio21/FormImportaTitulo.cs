using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static cartorio21.DBConnection;
using System.Xml.Linq;
using System.Drawing;

namespace cartorio21
{
    public partial class FormImportaTitulo : Form
    {
        private DBConnection _dbConnection;
        public FormImportaTitulo()
        {
            InitializeComponent();
            _dbConnection = new DBConnection();
            carregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportarDadosXML();
            carregarDados();
        }

        private void ImportarDadosXML()
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Selecionar Arquivo de Importação";
                    openFileDialog.Filter = "Arquivos de Texto|*.xml;";

                    DialogResult result = openFileDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                    {
                        string xmlFile = openFileDialog.FileName;
                        var titulos = ctrImportaTitulos.LerXML(xmlFile);
                        if (titulos != null)
                        {
                            var ctrTitulo = new ctrTitulo();
                            ctrTitulo.InserirTitulos(titulos, xmlFile);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao Pesquisar Titulos!\n{erro}", "Inserir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void carregarDados()
        {
            try
            {
                dgvTitulos.Columns.Clear();

                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Abrir";
                btnColumn.Text = "Abrir";
                btnColumn.UseColumnTextForButtonValue = true;
                btnColumn.Name = "btnAbrir";
                dgvTitulos.Columns.Add(btnColumn);

                string where = "";
                if (!string.IsNullOrEmpty(edtProtocolo.Text))
                    where = $" and sProtocolo like '%{edtProtocolo.Text}%' ";
                if (!string.IsNullOrEmpty(edtNomeDevedor.Text))
                    where = $" and sNomeDevedor like '%{edtNomeDevedor.Text}%' ";
                if (!string.IsNullOrEmpty(edtDocDevedor.Text))
                    where = $" and sDocumentoDevedor like '%{ctrUtil.RetornarApenasNumeros(edtDocDevedor.Text)}%' ";
                if (!string.IsNullOrEmpty(edtEspecie.Text))
                    where = $" and sEspecieTitulo like '%{edtEspecie.Text}%' ";
                if (dtApresentacaoInicio.Text != "  /  /" && dtApresentacaoFinal.Text != "  /  /")
                {
                    DateTime dataInicio = DateTime.Parse(dtApresentacaoInicio.Text);
                    DateTime dataFinal = DateTime.Parse(dtApresentacaoFinal.Text);
                    where = $" and dtApresentacao between '{dataInicio.ToString("yyyy-MM-dd")}' and '{dataFinal.ToString("yyyy-MM-dd")}' ";
                }
                if (dtEmissao.Text != "  /  /")
                {
                    DateTime dataEmissao = DateTime.Parse(dtEmissao.Text);
                    where = $" and dtEmissao = '{dataEmissao.ToString("yyyy-MM-dd")}' ";
                }

                if (!string.IsNullOrEmpty(edtNomeApresentante.Text))
                    where = $" and sNomeApresentante like '%{edtNomeApresentante.Text}%' ";
                if (!string.IsNullOrEmpty(edtDocumentoApresentante.Text))
                    where = $" and sDocumentoApresentante like '%{ctrUtil.RetornarApenasNumeros(edtDocumentoApresentante.Text)}%' ";
                if (!string.IsNullOrEmpty(edtNomeCredor.Text))
                    where = $" and sNomeCredor like '%{edtNomeCredor.Text}%' ";
                if (!string.IsNullOrEmpty(edtDocumentoCredor.Text))
                    where = $" and sDocumentoCredor like '%{ctrUtil.RetornarApenasNumeros(edtDocumentoCredor.Text)}%' ";

                using (SqlConnection con = _dbConnection.GetConnection())
                {
                    string consulta = $@"select  id,
                                                sProtocolo as 'Protocolo',
	                                            dtApresentacao as 'Data Apresentação',
	                                            sNomeDevedor as 'Devedor',
	                                            sDocumentoDevedor as 'Documento Devedor',
	                                            sNomeApresentante as 'Apresentante',
	                                            sDocumentoApresentante as 'Documento Apresentante',
	                                            sNomeCredor as 'Credor',
	                                            sDocumentoCredor as 'Documento Credor',
	                                            sNumeroTitulo as 'Numero Titulo',
	                                            dtEmissao as 'Data Emissao',
	                                            sEspecieTitulo as 'Especie de Titulo',
	                                            dValorTitulo as 'Valor do Titulo',
	                                            dCustas as 'Valor Custas'
                                            from [cartorio21].[dbo].[titulo] where dtDelete is null {where};";

                    SqlCommand cmd = new SqlCommand(consulta, con);
                    SqlDataReader reader = cmd.ExecuteReader();


                    DataTable dt = new DataTable();
                    dt.Columns.Add("id", typeof(int));
                    dt.Columns.Add("Protocolo", typeof(string));
                    dt.Columns.Add("Data Apresentação", typeof(DateTime)); 
                    dt.Columns.Add("Devedor", typeof(string));
                    dt.Columns.Add("Documento Devedor", typeof(string));
                    dt.Columns.Add("Apresentante", typeof(string));
                    dt.Columns.Add("Documento Apresentante", typeof(string));
                    dt.Columns.Add("Credor", typeof(string));
                    dt.Columns.Add("Documento Credor", typeof(string));
                    dt.Columns.Add("Numero Titulo", typeof(string));
                    dt.Columns.Add("Data Emissao", typeof(DateTime)); 
                    dt.Columns.Add("Especie de Titulo", typeof(string));
                    dt.Columns.Add("Valor do Titulo", typeof(decimal)); 
                    dt.Columns.Add("Valor Custas", typeof(decimal)); 

                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["id"] = reader.GetInt32(0);
                        row["Protocolo"] = reader.GetString(1);
                        row["Data Apresentação"] = reader.GetDateTime(2); 
                        row["Devedor"] = reader.GetString(3);
                        row["Documento Devedor"] = ctrUtil.FormatarCPFCNPJ(reader.GetString(4));
                        row["Apresentante"] = reader.GetString(5);
                        row["Documento Apresentante"] = ctrUtil.FormatarCPFCNPJ(reader.GetString(6));
                        row["Credor"] = reader.GetString(7);
                        row["Documento Credor"] = ctrUtil.FormatarCPFCNPJ(reader.GetString(8));
                        row["Numero Titulo"] = reader.GetString(9);
                        row["Data Emissao"] = reader.GetDateTime(10);
                        row["Especie de Titulo"] = reader.GetString(11);
                        row["Valor do Titulo"] = reader.GetDecimal(12).ToString("N2");
                        row["Valor Custas"] = reader.GetDecimal(13).ToString("N2");

                        dt.Rows.Add(row);
                    }

                    dgvTitulos.DataSource = dt;
                    dgvTitulos.Columns["id"].Visible = false;
                }            

                lbQtdTiulos.Text = $"Quantidade de Titulos: {dgvTitulos.Rows.Count}";
            }
            catch(Exception erro)
            {
                MessageBox.Show($"Erro ao Pesquisar Titulos!\n{erro}", "Inserir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void DgvTitulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
                return;
            if (e.RowIndex >= 0 && dgvTitulos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvTitulos.Columns[e.ColumnIndex].Name == "btnAbrir")
            {
                DataGridViewRow selectedRow = dgvTitulos.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                var form = new FormTitulo(int.Parse(id));
                form.Show();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                carregarDados();
            }
        }

        private void btnExcluirSelecionados_Click(object sender, EventArgs e)
        {
            try
            {
                ctrTitulo ctrtit = new ctrTitulo();

                foreach (DataGridViewRow row in dgvTitulos.SelectedRows)
                {
                    if (row.Cells["id"].Value != null)
                    {
                        string id = row.Cells["id"].Value.ToString();
                        ctrtit.Excluir(int.Parse(id));
                    }
                }
                MessageBox.Show("Linhas selecionadas foram excluídas com sucesso!");
                carregarDados();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao excluir Titulos!\n{erro}", "Excluir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
