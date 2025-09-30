# Checkpoint 5 - C#: App para gerenciamento de tarefas

Esse projeto é uma aplicação para gerenciamento de tarefas, na qual é possível categorizar suas tarefas conforme sua necessidade.

A aplicação implementa operações CRUD (Create / Read / Update / Delete) usando Entity Framework Core para persistência em banco. A arquitetura usa Models → Repositories → Services → Program (UI/menu), separando acesso a dados e lógica de negócio.

---
## Funcionalidades

- Cadastro (Create) de Categorias e Tarefas.
- Leitura (Read) de todas as categorias e tarefas, com mensagem de aviso quando não houver itens.
- Atualização (Update) de tarefa (descrição, conclusão).
- Exclusão (Delete) de tarefa.
- Arquitetura em camadas (Models / Repositories / Services) para boa organização de código.

---
## Estrutura do projeto

```
ToDoApp/
 ├─ Models/
 │   ├─ Tarefa.cs
 │   └─ Categoria.cs
 ├─ Data/
 │   └─ AppDbContext.cs
 ├─ Repositories/
 │   ├─ ITarefaRepository.cs
 │   ├─ TarefaRepository.cs
 │   ├─ ICategoriaRepository.cs
 │   └─ CategoriaRepository.cs
 ├─ Services/
 │   ├─ TarefaService.cs
 │   └─ CategoriaService.cs
 └─ Program.cs
 ```

---
## Pré-requisitos

- .NET 8
- `dotnet-ef` instalado globalmente, com o seguinte código:
```
dotnet tool install --global dotnet-ef
```
- Pacotes NuGet no projeto: `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.Sqlite`, `Microsoft.EntityFrameworkCore.Tools`

- Para rodar no terminal: `dotnet run`
- Para rodar diretamente pela IDE (Visual Studio): garantir que o caminho completo para o arquivo `todo.db` esteja na connection string na classe `AppDbContext.cs`

---
## Integrantes

- Aline Fernandes Zeppelini - RM97966
- Camilly Breitbach Ishida - RM551474
- Julia Leite Galvão - RM550201
- Jessica Costacurta - RM99068







