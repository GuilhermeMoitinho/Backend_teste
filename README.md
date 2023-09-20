# API de Gerenciamento de Usuários

Esta é uma API para gerenciar informações de usuários.

## Endpoints Disponíveis

### 1. Criação de Usuário

- **URL**: `/api/Usuario`
- **Método**: `POST`
- **Descrição**: Cria um novo usuário com as informações fornecidas.
- **Corpo da Requisição**: Um objeto `Usuario` que contém informações do usuário a ser criado.
- **Resposta de Sucesso**: Retorna um objeto `ServiceResponse<List<Usuario>>` com a lista de todos os usuários após a criação.
- **Resposta de Erro**: Retorna um código de erro com uma mensagem em caso de falha.

### 2. Exclusão de Usuário

- **URL**: `/api/Usuario/{id}`
- **Método**: `DELETE`
- **Descrição**: Exclui o usuário com o ID especificado.
- **Parâmetro de Rota**: `id` - O ID do usuário a ser excluído.
- **Resposta de Sucesso**: Retorna um objeto `ServiceResponse<List<Usuario>>` com a lista de todos os usuários após a exclusão.
- **Resposta de Erro**: Retorna um código de erro com uma mensagem em caso de falha.

### 3. Listagem de Usuários

- **URL**: `/api/Usuario`
- **Método**: `GET`
- **Descrição**: Retorna uma lista de todos os usuários.
- **Resposta de Sucesso**: Retorna um objeto `List<UsuarioDTO>` contendo informações de todos os usuários.
- **Resposta de Erro**: Retorna um código de erro com uma mensagem em caso de falha.

### 4. Detalhes do Usuário

- **URL**: `/api/Usuario/{id}`
- **Método**: `GET`
- **Descrição**: Retorna os detalhes do usuário com o ID especificado.
- **Parâmetro de Rota**: `id` - O ID do usuário a ser consultado.
- **Resposta de Sucesso**: Retorna um objeto `UsuarioDTO` contendo informações do usuário.
- **Resposta de Erro**: Retorna um código de erro com uma mensagem em caso de falha.

### 5. Atualização de Usuário

- **URL**: `/api/Usuario/{id}`
- **Método**: `PUT`
- **Descrição**: Atualiza as informações do usuário com o ID especificado.
- **Parâmetro de Rota**: `id` - O ID do usuário a ser atualizado.
- **Corpo da Requisição**: Um objeto `Usuario` com as informações atualizadas.
- **Resposta de Sucesso**: Retorna um objeto `ServiceResponse<Usuario>` com as informações do usuário após a atualização.
- **Resposta de Erro**: Retorna um código de erro com uma mensagem em caso de falha.

## Modelos

### 1. Usuario

- **Propriedades**:
  - `Id` (int): O ID único do usuário.
  - `Nome` (string): O nome do usuário.
  - `Endereco` (string): O endereço do usuário.
  - `Telefone` (string): O número de telefone do usuário.
  - `Ocupacao` (string): A ocupação do usuário.

### 2. UsuarioDTO

- **Propriedades**:
  - `Id` (int): O ID único do usuário.
  - `Nome` (string): O nome do usuário.
  - `Endereco` (string): O endereço do usuário.

### 3. ServiceResponse<T>

- **Propriedades**:
  - `Dados` (T): Os dados da resposta.
  - `Mensagem` (string): Uma mensagem descritiva da resposta.

## Serviços

### 1. IUsuarioInterface

- **Métodos**:
  - `GetUsuarios()`: Retorna a lista de todos os usuários.
  - `CreateFuncionarios(modelCreate)`: Cria um novo usuário com as informações fornecidas.
  - `GetFuncionariosById(id)`: Retorna os detalhes do usuário com o ID especificado.
  - `UpdateFuncionarios(modelUpdate, id)`: Atualiza as informações do usuário com o ID especificado.
  - `DeleteFuncionarios(id)`: Exclui o usuário com o ID especificado.
