using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartorio21
{
    public class ctrTitulo
    {
        private DBConnection _dbConnection;

        public ctrTitulo()
        {
            _dbConnection = new DBConnection();
        }

        public void InserirTitulos(List<Titulo> titulos, string nomeArquivoXML)
        {
            try
            {
                using (SqlConnection con = _dbConnection.GetConnection())
                {
                    int protocolo = verificarProximoProtocolo();

                    foreach (var titulo in titulos)
                    {
                        protocolo += 1;
                        string query = @"INSERT INTO [cartorio21].[dbo].[titulo]
                                (dtApresentacao, sprotocolo, sNomeDevedor, sDocumentoDevedor, sNomeApresentante, sDocumentoApresentante, sNomeCredor, sDocumentoCredor, sNumeroTitulo, dValorTitulo, dtEmissao, sEspecieTitulo, dCustas, dtCreate, dtUpdate, sArquivo)
                                VALUES (@dtAprentacao,@Protocolo, @NomeDevedor, @DocumentoDevedor, @NomeApresentante, @DocumentoApresentante, @NomeCredor, @DocumentoCredor, @NumeroTitulo, @ValorTitulo, @DataEmissao, @EspecieTitulo, @dCustas, @dtCreate,@dtUpdate, @sArquivo)";

                        decimal custas = calcularCustasTitulos(titulo.ValorTitulo);

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@dtAprentacao", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Protocolo", protocolo.ToString("0000000"));
                            cmd.Parameters.AddWithValue("@NomeDevedor", titulo.NomeDevedor);
                            cmd.Parameters.AddWithValue("@DocumentoDevedor", titulo.DocumentoDevedor);
                            cmd.Parameters.AddWithValue("@NomeApresentante", titulo.NomeApresentante);
                            cmd.Parameters.AddWithValue("@DocumentoApresentante", titulo.DocumentoApresentante);
                            cmd.Parameters.AddWithValue("@NomeCredor", titulo.NomeCredor);
                            cmd.Parameters.AddWithValue("@DocumentoCredor", titulo.DocumentoCredor);
                            cmd.Parameters.AddWithValue("@NumeroTitulo", titulo.NumeroTitulo);
                            cmd.Parameters.AddWithValue("@ValorTitulo", titulo.ValorTitulo);
                            cmd.Parameters.AddWithValue("@DataEmissao", titulo.DataEmissao);
                            cmd.Parameters.AddWithValue("@EspecieTitulo", titulo.EspecieTitulo);
                            cmd.Parameters.AddWithValue("@dCustas", custas);
                            cmd.Parameters.AddWithValue("@dtCreate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@dtUpdate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@sArquivo", nomeArquivoXML);


                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao inserir titulos no banco de dados!\n{erro}", "Inserir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public decimal calcularCustasTitulos(decimal valorTitulo)
        {
            try
            {
                double teste = double.Parse(valorTitulo.ToString());
                decimal custas = decimal.Parse((teste * 0.1).ToString());
                return custas;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao calcular custas do titulo!\n{erro}", "Inserir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
        }

        private int verificarProximoProtocolo()
        {
            try
            {
                using (SqlConnection con = _dbConnection.GetConnection())
                {
                    int protocolo = 0;
                    string query = @"select max(cast(sProtocolo as int)) from [cartorio21].[dbo].[titulo] where dtDelete is null;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        var result = cmd.ExecuteScalar().ToString();
                        if (!string.IsNullOrEmpty(result))
                            protocolo = int.Parse(result);
                        return protocolo;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao verificar ultimo protocolo!\n{erro}", "Inserir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
        }

        public Titulo AbrirPeloID(int id)
        {
            try
            {
                string query = $"SELECT * FROM titulo WHERE Id = {id}";
                var titulo = new Titulo();
                using (SqlConnection con = _dbConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                titulo.Id = id;
                                titulo.dtApresentacao = DateTime.Parse(reader["dtApresentacao"].ToString());
                                titulo.Protocolo = reader["sProtocolo"].ToString();
                                titulo.NomeDevedor = reader["sNomeDevedor"].ToString();
                                titulo.DocumentoDevedor = reader["sDocumentoDevedor"].ToString();
                                titulo.NomeApresentante = reader["sNomeApresentante"].ToString();
                                titulo.DocumentoApresentante = reader["sDocumentoApresentante"].ToString();
                                titulo.NomeCredor = reader["sNomeCredor"].ToString();
                                titulo.DocumentoCredor = reader["sDocumentoCredor"].ToString();
                                titulo.NumeroTitulo = reader["sNumeroTitulo"].ToString();
                                titulo.ValorTitulo = decimal.Parse(reader["dValorTitulo"].ToString());
                                titulo.DataEmissao = DateTime.Parse(reader["dtEmissao"].ToString());
                                titulo.EspecieTitulo = reader["sEspecieTitulo"].ToString();
                                titulo.ValorCustas = decimal.Parse(reader["dCustas"].ToString());
                                titulo.dtCreate = DateTime.Parse(reader["dtCreate"].ToString());
                                titulo.dtUpdate = DateTime.Parse(reader["dtUpdate"].ToString());
                                titulo.sArquivo = reader["sArquivo"].ToString();
                                return titulo;
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao abrir titulo!\n{erro}", "Titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public void UpdateTitulo(Titulo titulo)
        {
            try
            {
                string query = $@"UPDATE [dbo].[titulo] SET 
                                    [dtApresentacao] = @DtApresentacao,
                                    [sProtocolo] = @SProtocolo,
                                    [sNomeDevedor] = @SNomeDevedor,
                                    [sDocumentoDevedor] = @SDocumentoDevedor,
                                    [sNomeApresentante] = @SNomeApresentante,
                                    [sDocumentoApresentante] = @SDocumentoApresentante,
                                    [sNomeCredor] = @SNomeCredor,
                                    [sDocumentoCredor] = @SDocumentoCredor,
                                    [sNumeroTitulo] = @SNumeroTitulo,
                                    [dValorTitulo] = @DValorTitulo,
                                    [dtEmissao] = @DtEmissao,
                                    [sEspecieTitulo] = @SEspecieTitulo,
                                    [dCustas] = @DCustas,
                                    [dtUpdate] = @DtUpdate,
                                    [sArquivo] = @SArquivo
                                WHERE [id] = @Id";

                using (SqlConnection con = _dbConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DtApresentacao", titulo.dtApresentacao);
                        cmd.Parameters.AddWithValue("@SProtocolo", titulo.Protocolo);
                        cmd.Parameters.AddWithValue("@SNomeDevedor", titulo.NomeDevedor);
                        cmd.Parameters.AddWithValue("@SDocumentoDevedor", titulo.DocumentoDevedor);
                        cmd.Parameters.AddWithValue("@SNomeApresentante", titulo.NomeApresentante);
                        cmd.Parameters.AddWithValue("@SDocumentoApresentante", titulo.DocumentoApresentante);
                        cmd.Parameters.AddWithValue("@SNomeCredor", titulo.NomeCredor);
                        cmd.Parameters.AddWithValue("@SDocumentoCredor", titulo.DocumentoCredor);
                        cmd.Parameters.AddWithValue("@SNumeroTitulo", titulo.NumeroTitulo);
                        cmd.Parameters.AddWithValue("@DValorTitulo", titulo.ValorTitulo);
                        cmd.Parameters.AddWithValue("@DtEmissao", titulo.DataEmissao);
                        cmd.Parameters.AddWithValue("@SEspecieTitulo", titulo.EspecieTitulo);
                        cmd.Parameters.AddWithValue("@DCustas", titulo.ValorCustas);
                        cmd.Parameters.AddWithValue("@DtUpdate", titulo.dtUpdate);
                        cmd.Parameters.AddWithValue("@SArquivo", titulo.sArquivo);
                        cmd.Parameters.AddWithValue("@Id", titulo.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao abrir titulo!\n{erro}", "Titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                string query = @"UPDATE [dbo].[titulo] SET [dtDelete] = @DtDelete WHERE [id] = @id";

                using (SqlConnection con = _dbConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DtDelete", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao abrir titulo!\n{erro}", "Titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
