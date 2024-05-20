# Cartório de Protesto (Cartório21)

## Visão Geral

O Cartorio21 faz a importação de arquivos XML para o sistema, que por sua vez salva as informações já existentes no XML e adiciona o Protocolo (código único do cartório), Data de Apresentação (data em que o título foi apresentado) e Valor das Custas (10% do Valor do Título). Além de possibilitar a alteração ou exclusão dos titulos.

## Funcionalidades

- Importação automática dos títulos de um arquivo XML para um banco de dados SQL Server.
- Cálculo automático do Valor das Custas baseado- se em 10% no Valor do Título.
- Exibição dos títulos importados em um DataGridView.
- Funcionalidades para visualizar, editar e excluir os dados dos títulos.
- Uso de boas práticas de programação para garantir a qualidade e manutenibilidade do código.

## Arquivos Necessários

- **Arquivo XML de Títulos:** Arquivo XML contendo os dados dos títulos para importação.

## Tecnologias

- **.NET Framework 4.8:** Utilizado para desenvolvimento do aplicativo Windows Forms.
- **Windows Forms:** Para criação da interface gráfica do usuário.
- **SQL Server:** Para armazenamento dos dados dos títulos.
- **C#:** Linguagem de programação utilizada para desenvolvimento do sistema.
- **XML:** Formato de arquivo utilizado para importação dos dados dos títulos.

## Instalação e Configuração

1. Clone o repositório do projeto.
2. Restaure o banco de dados utilizando o arquivo .bak fornecido (arquivo .bak na solução).
3. Configure a conexão com o banco de dados no projeto na string de conexão localizada no App.config.
4. Compile e execute o projeto utilizando o Visual Studio.

## Como Usar

- Importe o arquivo XML de títulos através da interface do sistema.
- Os títulos serão automaticamente adicionados ao banco de dados com os campos extras (Protocolo, Data de Apresentação e Valor das Custas).
- Utilize o DataGridView para visualizar, editar e excluir títulos conforme necessário.

## Contato

Para mais informações, entre em contato:
- Nome: Brenda Trindade Carbas
- Email: brenda.trindade001@gmail.com
- LinkedIn: https://www.linkedin.com/in/brenda-trindade-50361a176/
