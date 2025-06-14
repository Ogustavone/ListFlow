# 💻 ListFlow - Gerenciador de serviços em kanban

![](https://img.shields.io/badge/C%23/.NET-729)
![](https://img.shields.io/badge/Entity_Framework-749)
![](https://img.shields.io/badge/Postgres-069)
![](https://img.shields.io/badge/Docker-049)

`Repositório Backend`:
Api desenvolvida para gerenciamento de tarefas e serviços seguindo a metodologia kanban.

## Implementações
- CRUD na rota de tarefas
- Sistema de login + BCrypt
- Autenticação JWT
## Dependências principais
- .NET 8.0.16
- Entity Framework 8.0.16
- PostgreSQL 16
## Rotas/Endpoints
```
GET:
    api/tasks
    api/users
    api/tasks/id
    api/users/id
POST:
    api/tasks
    api/users
PUT:
    api/tasks/id
    api/users/id
```
