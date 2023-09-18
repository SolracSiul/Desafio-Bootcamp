# Desafio bootcamp - 4° Edição
## Descrição
Este repositório contém uma aplicação feita em C# (Asp.NET 6.0 MVC) e SQL Server. Onde é possível realizar um CRUD de produtos com toda integração entre frontend e backend promovido pelo ASP.NET.

## Passo a Passo para Rodar o Projeto

1. **Instalação do SQLServer:**
   - Certifique-se de ter o SQLServer instalado em seu sistema. Se ainda não o tiver, você pode baixá-lo no [site oficial do SQLServer]([https://www.docker.com/get-started](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)).
2. **IDE de sua preferência.**

2. **Instalação das seguintes dependências :**
   - Caso esteja utilizando o Visual Studio, verifique os pacotes do NuGet e adicione: 
     ```shell
      Microsoft.EntityFrameworkCore;
      Microsoft.EntityFrameworkCore.Design;
      Microsoft.EntityFrameworkCore.SqlServer;
      Microsoft.EntityFrameworkCore.Tools;
     ```
4. **Alteração de várivaies de conexão do SQL Server :**
   - Em Program.cs altere a linha 15 e coloque as credênciais da sua máquina:
     ```shell
     ("Data Source=<SuaMaquina>;Initial Catalog=CRUD_MVC;User ID=<username>;Password=<password>;TrustServerCertificate=True"));
     ```

5. **Crie uma migration e inicialize o banco de dados via terminal :**
   - Execute os comandos:
     - Add-Migration <NomeDaNovaMigration> -Context BancoContext
     - Update-Database -Context BancoContext

Pronto! Agora é só rodar o projeto! 
