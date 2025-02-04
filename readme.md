# Agenda de Contatos

Um projeto desenvolvido em ASP.NET MVC que permite gerenciar uma agenda de contatos. Com esta aplicação, é possível adicionar, pesquisar, editar, visualizar e excluir informações de contatos, como nome, telefone e e-mail.

## Funcionalidades

- **Adicionar Contatos**: Cadastre novos contatos informando nome, telefone e e-mail.
- **Pesquisar Contatos**: Localize contatos específicos através de uma listagem organizada.
- **Editar Contatos**: Atualize as informações de contatos existentes.
- **Excluir Contatos**: Remova contatos da agenda de forma definitiva.

### Validações

- E-mail no formato correto (ex: usuario@dominio.com).
- Telefone no padrão brasileiro (ex: (11) 98765-4321).

## Tecnologias Utilizadas

- ASP.NET MVC
- Entity Framework Core
- SQL Server
- Bootstrap 5 para estilização
- FontAwesome para ícones

## Configuração do Projeto

### Requisitos

- Visual Studio (versão 2022 ou superior)
- SQL Server (LocalDB ou outra instância configurada)
- .NET 9.0

### Passos para Configurar

1. **Clone o Repositório**:
    ```bash
    git clone https://github.com/seu-usuario/agenda-de-contatos.git
    ```

2. **Abra o Projeto no Visual Studio**.

3. **Configure a String de Conexão**:
    No arquivo `appsettings.json`, atualize a string de conexão com os dados do seu SQL Server:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgendaDeContatos;Trusted_Connection=True;"
    }
    ```

4. **Atualize o Banco de Dados**:
    Execute os comandos abaixo no Package Manager Console:
    ```powershell
    Update-Database
    ```
    Isso criará as tabelas necessárias no banco de dados.

5. **Execute o Projeto**:
    Pressione `F5` no Visual Studio para iniciar o servidor e acessar a aplicação no navegador.

## Estrutura do Projeto

- **Models**: Contém a classe `Contato` com as propriedades e validações.
- **Views**: Arquivos `.cshtml` para renderização das páginas.
    - `Index.cshtml`: Listagem dos contatos.
    - `Create.cshtml`: Formulário para adicionar novos contatos.
    - `Edit.cshtml`: Formulário para editar contatos existentes.
    - `Delete.cshtml`: Confirmação de exclusão de contatos.
    - `Details.cshtml`: Visualização dos detalhes de um contato.
- **Controllers**: Contém a lógica de controle da aplicação. Exemplo: `ContatosController`.
- **Migrations**: Gerenciadas pelo Entity Framework para controle do banco de dados.

## Estilização

- A aplicação utiliza o Bootstrap 5 para responsividade e estilo moderno.
- FontAwesome é usado para ícones, como nos botões de editar, excluir e adicionar.
- Campos com placeholders e validações para melhor experiência do usuário.

## Contribuição

Contribuições são bem-vindas! Siga os passos abaixo para colaborar:

1. **Fork o repositório**.
2. **Crie um branch para sua feature**:
    ```bash
    git checkout -b minha-feature
    ```
3. **Commit suas alterações**:
    ```bash
    git commit -m "Minha nova feature"
    ```
4. **Envie suas alterações**:
    ```bash
    git push origin minha-feature
    ```
5. **Abra um Pull Request**.

## Licença

Este projeto está licenciado sob a MIT License.

Desenvolvido por Ronaldo Domingues.