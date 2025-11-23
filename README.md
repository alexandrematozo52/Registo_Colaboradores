📌 Registo de Colaboradores – Aplicação WinForms em C# (.NET Framework)

🧑‍💻 Projeto desenvolvido como parte dos meus estudos de C# e Windows Forms.

Este projeto consiste numa aplicação de Registo e Gestão de Colaboradores, construída com C#, WinForms, ADO.NET e SQL Server.
O objetivo é treinar práticas profissionais de desenvolvimento desktop, arquitetura de código limpa, acesso a dados e boas práticas de UI/UX dentro do Windows Forms.

🚀 Funcionalidades Principais

✔️ Listagem de Colaboradores

🔹Carrega automaticamente todos os colaboradores da base de dados SQL Server.

🔹Colunas configuradas manualmente para melhor visualização.

🔹Suporte a hover destacando a linha com efeito visual.

🔹Seleção visual aprimorada (linha com cor diferente).

✔️ Adicionar Novo Colaborador

🔹Abre um formulário Novo_Registo com campos para inserção.

🔹Eventos customizados para atualizar automaticamente o DataGridView após gravar.

✔️ Edição com Duplo Clique

🔹Ao dar double-click numa linha, o formulário de edição é carregado com os dados preenchidos.

🔹Ação de editar visível, botão de salvar oculto.

🔹Callback para recarregar a grelha após edição.

✔️ Efeitos Visuais e UX

🔹DataGridView com:

🔹Hover row highlight

🔹Seleção personalizada

🔹DoubleBuffer ligado para remover "flickering"

🔹PictureBox com recorte arredondado usando GraphicsPath

✔️ Conexão com SQL Server

🔹Utilização de SqlConnection, SqlCommand e SqlDataAdapter

🔹String de conexão lida via ConfigurationManager (app.config)

🏗️ Arquitetura do Projeto

Registo_Colaboradores/
│

├── Registar.cs                 // Tela principal com DataGridView

├── Novo_Registo.cs             // Formulário para inserir/editar colaborador

├── App.config                  // Configuração da ligação ao SQL Server

└── Properties/

🗂️ Tecnologias Utilizadas

🔹C# – .NET Framework

🔹Windows Forms

🔹ADO.NET (SqlConnection, SqlDataAdapter, SqlCommand)

🔹SQL Server

🔹System.Configuration

🔹System.Drawing / GraphicsPath

🗃️ Estrutura da Tabela Utilizada

CREATE TABLE [dbo].[Colaboradores](

    [ID] INT IDENTITY PRIMARY KEY,
    
    [Colaborador] NVARCHAR(20),
    
    [Apelido] NVARCHAR(20),
    
    [Cargo] NVARCHAR(100),
    
    [Telemóvel] NVARCHAR(15),
    
    [Email] NVARCHAR(150),
    
    [Morada] NVARCHAR(200),
    
    [Cidade] NVARCHAR(50),
    
    [Distrito] NVARCHAR(50),
    
    [Código Postal] NVARCHAR(9),
    
    [País] NVARCHAR(50)
);

🔧 Configuração da Conexão (App.config)
<connectionStrings>
    <add name="ConexaoBD"
         connectionString="Data Source=SERVIDOR;Initial Catalog=Colaboradores;Integrated Security=True"/>
</connectionStrings>

📸 Recursos de UI Implementados

🔹 Hover no DataGridView

Ao passar o mouse sobre uma linha não selecionada, o fundo muda para LightCyan.

🔹 Seleção Personalizada

Quando uma linha é clicada, ela recebe cor diferenciada e a anterior é restaurada.

🔹 PictureBox com cantos arredondados

🔹Criado usando GraphicsPath e atribuído à propriedade Region.

🧠 Aprendizados e Boas Práticas Aplicadas

🔹Uso correto de eventos para comunicação entre forms.

🔹Melhoria de UI com DoubleBuffering para evitar flicker.

🔹Separação de responsabilidades dentro da interface.

🔹Carregamento dinâmico com SqlDataAdapter.

🔹Boas práticas de leitura de connection strings com ConfigurationManager.

🔹Manipulação avançada de controles com GraphicsPath e customização de interface.

📝 Próximas Evoluções Planejadas

🔹Implementar pesquisa com filtro dinâmico.

🔹Adicionar paginação para bases de dados extensas.

🔹Criar um repositório de dados para separar lógica da UI.

🔹Implementar validação de dados mais avançada.

🔹Criar versão em WPF usando MVVM.

🤝 Contribuição

Sinta-se à vontade para contribuir com melhorias no código, UI, arquitetura ou documentação via Pull Request.

🔗 Conecte-se comigo no LinkedIn

Se quiser acompanhar minha evolução e projetos:

👉 www.linkedin.com/in/alexandre-matozo-699393280

⭐ Se achou útil, deixe uma estrela no GitHub!

Agradeço pelo apoio 😊
