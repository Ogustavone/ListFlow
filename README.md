# 💻 ListFlow - Gerenciador de serviços em kanban

![](https://img.shields.io/badge/C%23/.NET-729)
![](https://img.shields.io/badge/Entity_Framework-749)
![](https://img.shields.io/badge/Postgres-069)
<!-- ![](https://img.shields.io/badge/Docker-049) -->

`Repositório Backend`:
Api desenvolvida para gerenciamento de tarefas e serviços seguindo a metodologia kanban.

## Implementações
- CRUD na rota de tarefas
<!-- - Sistema de login + BCrypt -->
<!-- - Autenticação JWT -->
## Dependências principais
- .NET 8.0.16
- Entity Framework 8.0.16
- PostgreSQL 16

## Endpoints
- #### Tasks (api/tasks)

| Método    | Rota                      | Descrição                         |
| ---       | ---                       | --------------------------------- |
| `GET`     | **api/tasks**             | Retorna todas as tarefas          |
| `GET`     | **api/tasks/id**          | Busca uma tarefa pelo ID          |
| `POST`    | **api/tasks/**            | Adiciona uma nova tarefa          |
| `DELETE`  | **api/tasks/id**          | Deleta a tarefa pelo ID           |
| `PATCH`   | **api/tasks/id**          | Atualiza a tarefa parcialmente    |
| `PUT`     | **api/tasks/id**          | Atualiza a tarefa pelo ID         |

<!-- - #### Users

| Método    | Rota                      | Descrição                     |
| --------- | ------------------------- | ----------------------------- |
| `GET`     | **api/users**             | Retorna todos usuários        |
| `GET`     | **api/users/id**          | Retorna o usuário pelo ID     |
| `POST`    | **api/users/**            | Adiciona um novo usuário      |
| `DELETE`  | **api/users/id**          | Deleta o usuário pelo ID      |
| `PUT`     | **api/users/id**          | Atualiza o usuário pelo ID    | -->

