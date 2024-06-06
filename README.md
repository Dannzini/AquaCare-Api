## Enterprise Application Development
### Professor: Caio Halbert Jacinto

### Grupo:

| Nome                             | RM    | Turma   |
| -------------------------------- | ----- | ------- |
| Bruno Barbosa Braga dos Santos   | 96685 | 2TDSPT  |
| Igor Augusto Takeshigue Lemos    | 97012 | 2TDSPT  |
| Joederson Oliveira Pereira       | 97192 | 2TDSPT  |
| Mário Ito Bocchini               | 96950 | 2TDSPT  |

# Aquacare - Monitoramento da Qualidade da Água

A Aquacare é uma solução inovadora para o monitoramento da qualidade da água, utilizando dispositivos de IoT (Internet das Coisas) e tecnologia de nuvem. Com a capacidade de armazenar e acessar dados em tempo real por meio de um aplicativo móvel, a Aquacare oferece uma maneira conveniente e acessível para empresas, governos e organizações monitorarem a qualidade da água em diversos ambientes.

## Apresentação

A Aquacare atende a uma variedade de casos de uso, incluindo:

- **Concessionárias de portos:** para garantir o cumprimento de normas ambientais.
- **Empresas ou governos:** para monitorar a qualidade e potabilidade da água em represas, reservatórios e corpos d'água.
- **Monitoramento de desastres:** como vazamentos de produtos tóxicos em corpos d'água e tragédias naturais como enchentes.

Os casos de uso são diversos, e a solução pode ser aplicada em qualquer ambiente que necessite de monitoramento da qualidade da água.

## Tecnologia

A Aquacare utiliza tecnologias modernas e emergentes, incluindo:

- **Dispositivos de IoT:** para coletar dados em tempo real sobre a qualidade da água.
- **Tecnologia de nuvem:** para armazenar e processar grandes volumes de dados de maneira eficiente e acessível.
- **Aplicativo móvel:** para acessar e visualizar os dados de forma conveniente e intuitiva.

## Importância Ambiental

A qualidade da água é uma questão significativa na área ambiental, afetando diretamente a saúde humana, a vida selvagem e os ecossistemas aquáticos. Em um contexto global de mudanças climáticas, o monitoramento da qualidade da água torna-se ainda mais crucial.

## Viabilidade

O uso de dispositivos de IoT para monitoramento ambiental é uma abordagem comprovada e amplamente adotada. Além disso, os sensores de qualidade da água estão comercialmente disponíveis e são capazes de medir uma ampla variedade de parâmetros. A tecnologia de nuvem torna o armazenamento e processamento de dados eficiente e acessível.

## Facilidade de Uso

A Aquacare oferece facilidade de uso por meio de seu aplicativo móvel, com vantagens como:

- **Interface intuitiva:** para uma experiência de usuário amigável.
- **Acesso remoto:** permitindo o acesso aos dados de qualquer lugar com conexão à internet.
- **Notificações em tempo real:** possibilitando alertas sobre eventos importantes (funcionalidade futura).
- **Personalização:** os usuários podem personalizar as configurações e alertas de acordo com suas preferências individuais (funcionalidade futura).

- # Sequência de Endpoints para Teste:

## Cadastro de Usuário (POST /api/usuarios):

- Cria um novo usuário no sistema.
- Parâmetros: Nome, E-mail, Senha.
- Respostas:
  - 201 Created: Usuário criado com sucesso.
  - 400 Bad Request: Dados de entrada inválidos.

## Consulta de Usuários (GET /api/usuarios):

- Retorna a lista de todos os usuários cadastrados.
- Respostas:
  - 200 OK: Lista de usuários retornada com sucesso.

## Consulta de Usuário por ID (GET /api/usuarios/{id}):

- Retorna os detalhes de um usuário específico com base no ID fornecido.
- Respostas:
  - 200 OK: Usuário encontrado e detalhes retornados.
  - 404 Not Found: Usuário não encontrado.

## Atualização de Usuário (PUT /api/usuarios/{id}):

- Atualiza as informações de um usuário existente com base no ID fornecido.
- Parâmetros: Nome, E-mail, Senha.
- Respostas:
  - 204 No Content: Usuário atualizado com sucesso.
  - 400 Bad Request: Dados de entrada inválidos.
  - 404 Not Found: Usuário não encontrado.

## Exclusão de Usuário (DELETE /api/usuarios/{id}):

- Remove um usuário existente com base no ID fornecido.
- Respostas:
  - 204 No Content: Usuário excluído com sucesso.
  - 404 Not Found: Usuário não encontrado.

## Cadastro de Cidade (POST /api/cidades):

- Cria uma nova cidade no sistema.
- Parâmetros: Nome, Estado.
- Respostas:
  - 201 Created: Cidade criada com sucesso.
  - 400 Bad Request: Dados de entrada inválidos.

## Cadastro de Local (POST /api/locais):

- Cria um novo local de monitoramento da qualidade da água.
- Parâmetros: Código da Cidade, Nome, Descrição, Latitude, Longitude.
- Respostas:
  - 201 Created: Local criado com sucesso.
  - 400 Bad Request: Dados de entrada inválidos.

## Cadastro de Indicador (POST /api/indicadores):

- Cria um novo indicador de qualidade da água para um determinado local.
- Parâmetros: Código do Local, Data/Hora de Medição, Níveis de Coliformes, PH, Oxigênio Dissolvido, Turbidez, Temperatura.
- Respostas:
  - 201 Created: Indicador criado com sucesso.
  - 400 Bad Request: Dados de entrada inválidos.

Essa sequência de endpoints permite o teste completo das funcionalidades oferecidas pela Aquacare, desde o cadastro e gerenciamento de usuários até o monitoramento e registro de indicadores de qualidade da água.

