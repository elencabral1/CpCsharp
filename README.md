# Sistema de Gerenciamento de Fornecedores e Vendedores

Este projeto foi desenvolvido como parte de um checkpoint para a faculdade, com o objetivo de implementar um sistema de gerenciamento de informações de fornecedores e vendedores.

## Índice

- [Visão Geral](#visão-geral)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Funcionalidades](#funcionalidades)


## Visão Geral

O **Sistema de Gerenciamento de Fornecedores e Vendedores** permite realizar operações CRUD (Create, Read, Update, Delete) para gerenciar informações tanto de fornecedores quanto de vendedores. Este sistema foi desenvolvido em C# com ASP.NET Core, utilizando práticas de injeção de dependência, documentação via XML, e validações com FluentValidation.

## Tecnologias Utilizadas

- **C#**
- **ASP.NET Core**
- **Entity Framework Core** para acesso ao banco de dados
- **SQL Server** para persistência de dados
- **FluentValidation** para validação de dados
- **Dependency Injection (DI)** para a gestão de dependências
- **Swagger** para documentação da API


## Funcionalidades

### 1. **Fornecedores**
- Gerenciamento completo dos fornecedores
### 2. **Vendedores**
- Gerenciamento completo dos vendedores

### 3. **CRUD Completo**
- Implementação de operações CRUD para Fornecedor e Vendedor (Criar, Ler, Atualizar, Excluir).

### 4. **Validação com FluentValidation**
- Implementação de validações robustas para garantir a integridade dos dados inseridos no sistema.

### 5. **Documentação da API**
- Cada endpoint da API é documentado utilizando comentários XML, e a API é exposta via Swagger para fácil visualização e teste.

### 6. **Injeção de Dependência**
- Implementação de injeção de dependência para serviços e repositórios, garantindo modularidade e flexibilidade no código.
