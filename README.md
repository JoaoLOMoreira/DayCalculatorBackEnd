# DayCalculatorBackEnd

Este projeto tem como objetivo servir como a camada de processamento para o projeto de frontend [DayCalculatorFrontEnd](https://github.com/JoaoLOMoreira/DayCalculatorFrontEnd).

## Visão Geral

Essa API é construída usando .NET Core e C#. Ela fornece um endpoint que aceita duas datas e retorna a diferença entre elas em várias unidades de tempo. Este projeto serve como um exemplo de como construir uma API simples com .NET Core e utilizar boas práticas de design.

### Tecnologias Utilizadas

- **.NET Core 6**: Framework para desenvolvimento da API.
- **C#**: Linguagem de programação usada no projeto.
- **ASP.NET Core**: Framework para construção de APIs RESTful.
- **Design Patterns**: Implementações básicas de padrão de projeto como separação de camadas, injeção de dependência e serviços.

### Padrões e Arquitetura

Este projeto segue uma estrutura de arquitetura simples, onde a lógica de negócio é separada do controlador. Os principais padrões e conceitos aplicados são:

- **Injeção de Dependência**: Facilita o gerenciamento e a injeção de dependências entre os componentes.
- **Separation of Concerns (SoC)**: A lógica de negócio é isolada no serviço, promovendo a separação clara entre as responsabilidades das camadas.
- **DTO (Data Transfer Object)**: Um padrão utilizado para encapsular os dados de entrada e saída da API.

## Aviso

Os conceitos e a implementação presentes neste projeto são exemplos básicos e podem não refletir a viabilidade ou detalhes corretos para uma aplicação em produção. O foco está em demonstrar o uso fundamental das tecnologias envolvidas. Para uma aplicação em produção, recomenda-se uma análise detalhada dos requisitos e a aplicação de práticas de desenvolvimento robustas.

## Planejamento Futuro

O próximo passo para este projeto é publicar a aplicação na Azure, permitindo que o frontend possa consumir essa API a partir de qualquer lugar, garantindo escalabilidade e disponibilidade.

## Contribuições

Contribuições são bem-vindas! Se você tem sugestões para melhorias ou deseja corrigir algum problema, fique à vontade para abrir uma issue ou fazer um pull request.

## Contato
Para mais informações ou para entrar em contato, você pode me encontrar no Instagram: @joaomoreira.exe.

## Como Executar

1. Clone o repositório:

    ```bash
    git clone https://github.com/SeuUsuario/DateDifferenceAPI.git
    cd DateDifferenceAPI
    ```

2. Restaure as dependências e execute a aplicação:

    ```bash
    dotnet restore
    dotnet run
    ```

3. Acesse o endpoint da API em `https://localhost:5001/api/datedifference?startDate=YYYY-MM-DD&endDate=YYYY-MM-DD`.



