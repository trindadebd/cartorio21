using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace cartorio21
{
    public class Titulo
    {
        public int Id { get; set; }
        public DateTime dtApresentacao { get; set; }
        public string Protocolo { get; set; }
        public string NomeDevedor { get; set; }
        public string DocumentoDevedor { get; set; }
        public string NomeApresentante { get; set; }
        public string DocumentoApresentante { get; set; }
        public string NomeCredor { get; set; }
        public string DocumentoCredor { get; set; }
        public string NumeroTitulo { get; set; }
        public decimal ValorTitulo { get; set; }
        public DateTime DataEmissao { get; set; }
        public string EspecieTitulo { get; set; }
        public decimal ValorCustas { get; set; }
        public DateTime dtCreate { get; set; }
        public DateTime dtUpdate { get; set; }
        public DateTime dtDelete { get; set; }
        public string sArquivo { get; set; }

    }

    internal class ctrImportaTitulos
    {
        public static List<Titulo> LerXML(string xmlPath)
        {
            try
            {
                ctrUtil ctrUtil = new ctrUtil();
                XDocument doc = XDocument.Load(xmlPath);
                var titulos = from titulo in doc.Descendants("Titulo")
                              select new Titulo
                              {
                                  Protocolo = titulo.Element("Protocolo").Value,
                                  NomeDevedor = titulo.Element("NomeDevedor").Value,
                                  DocumentoDevedor = ctrUtil.RetornarApenasNumeros(titulo.Element("DocumentoDevedor").Value),
                                  NomeApresentante = titulo.Element("NomeApresentante").Value,
                                  DocumentoApresentante = ctrUtil.RetornarApenasNumeros(titulo.Element("DocumentoApresentante").Value),
                                  NomeCredor = titulo.Element("NomeCredor").Value,
                                  DocumentoCredor = ctrUtil.RetornarApenasNumeros(titulo.Element("DocumentoCredor").Value),
                                  NumeroTitulo = titulo.Element("NumeroTitulo").Value,
                                  ValorTitulo = decimal.Parse(titulo.Element("ValorTitulo").Value),
                                  DataEmissao = DateTime.Parse(titulo.Element("DataEmissao").Value),
                                  EspecieTitulo = titulo.Element("EspecieTitulo").Value
                              };

                return titulos.ToList();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao ler arquivo XML!\n{erro}", "Inserir titulos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }
    }
}
