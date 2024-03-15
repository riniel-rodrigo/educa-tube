# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário gerencie suas tarefas | ALTA | 
|RF-002| A aplicação deve emitir um relatório de tarefas realizadas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos.

![Exemplo de Diagrama de Fluxo](img/Diagrama-de-Caso-de-Uso-EducaTube.png)

|**Nome de caso de uso**|   Cadastro de Usuário              |
|-----------------------|------------------------------------|
|**Ator primário**      | Usuário - qualquer pessoa que interage com o sistema |
|**Descrição**          | Este caso de uso permite que novos usuários se cadastrem no site, fornecendo as informações necessárias para criar uma conta. O cadastro de usuário é o primeiro passo para acessar todas as funcionalidades oferecidas pelo site.                                 |
|**Fluxo Principal**    | 1 O usuário acessa a página de cadastro.<br/> 2 O usuário preenche as informações necessárias.<br/> 3 O usuário envia as informações para registro.
|**Fluxo Alternativo**  | Se o usuário já possui uma conta, ele pode optar por fazer login em vez de se cadastrar.

| **Nome de caso de uso** | Login no Site |
|-------------------------|---------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que usuários existentes façam login no site, fornecendo suas credenciais (nome de usuário/e-mail e senha). O login é necessário para acessar as funcionalidades personalizadas do site, como gerenciamento de playlists e histórico de vídeos assistidos. |
| **Fluxo Principal**     | 1. O usuário acessa a página de login.<br/> 2. O usuário insere suas credenciais (nome de usuário/e-mail e senha).<br/> 3. O sistema verifica as credenciais e permite o acesso se forem válidas. |

| **Nome de caso de uso** | Gerenciamento de Playlists |
|-------------------------|----------------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que o usuário crie, edite, adicione e remova playlists do seu perfil. O usuário pode organizar seus vídeos favoritos em playlists personalizadas para facilitar o acesso e a reprodução. |
| **Fluxo Principal**     | 1. O usuário acessa a área de gerenciamento de playlists.<br/> 2. O usuário pode criar, editar, adicionar ou remover playlists do seu perfil. |

| **Nome de caso de uso** | Comentários em Vídeos |
|-------------------------|-----------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários deixem comentários abaixo dos vídeos. Os comentários permitem interação entre os usuários e podem ser usados para discussão, feedback ou esclarecimento de dúvidas relacionadas ao conteúdo do vídeo. |
| **Fluxo Principal**     | 1. O usuário visualiza um vídeo.<br/> 2. Abaixo do vídeo, o usuário pode adicionar um comentário. |

| **Nome de caso de uso** | Anotações em Vídeos |
|-------------------------|---------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários façam anotações enquanto assistem a vídeos. As anotações permitem que os usuários capturem insights, marquem pontos importantes ou tomem notas relevantes durante a reprodução do vídeo. |
| **Fluxo Principal**     | 1. O usuário assiste a um vídeo.<br/> 2. O usuário pode fazer anotações enquanto assiste.<br/> 3. As anotações são salvas automaticamente ou quando o usuário optar por salvar. |

| **Nome de caso de uso** | Histórico de Vídeos Assistidos |
|-------------------------|---------------------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários visualizem o histórico de vídeos assistidos. O histórico mantém um registro dos vídeos que o usuário já assistiu, facilitando o acesso a conteúdos previamente visualizados. |
| **Fluxo Principal**     | 1. O sistema registra automaticamente os vídeos assistidos pelo usuário.<br/> 2. O usuário pode acessar o histórico de vídeos assistidos a qualquer momento. |

| **Nome de caso de uso** | Busca de Vídeos ou Playlists |
|-------------------------|--------------------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários pesquisem vídeos ou playlists específicas. A busca facilita a descoberta de conteúdos relevantes com base em palavras-chave ou termos de pesquisa fornecidos pelo usuário. |
| **Fluxo Principal**     | 1. O usuário acessa a ferramenta de busca.<br/> 2. O usuário insere termos de busca para encontrar vídeos ou playlists específicas. |

| **Nome de caso de uso** | Salvar Conteúdos Preferidos |
|-------------------------|------------------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários salvem conteúdos favoritos para acesso posterior. Os conteúdos salvos podem incluir vídeos específicos ou playlists inteiras que o usuário deseja acessar novamente no futuro. |
| **Fluxo Principal**     | 1. O usuário encontra um conteúdo que deseja salvar.<br/> 2. O usuário seleciona a opção de salvar ou adicionar aos favoritos. |

| **Nome de caso de uso** | Gerenciamento de Agenda Pessoal |
|-------------------------|----------------------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários criem, editem, adicionem e removam eventos na sua agenda pessoal. A agenda pessoal pode ser usada para planejar e organizar atividades, compromissos ou lembretes importantes. |
| **Fluxo Principal**     | 1. O usuário acessa a sua agenda pessoal.<br/> 2. O usuário pode criar, editar, adicionar ou remover eventos na agenda. |

| **Nome de caso de uso** | Pomodoro para Organização de Tempo de Estudo |
|-------------------------|------------------------------------------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários utilizem a técnica de Pomodoro para organizar seu tempo de estudo. O Pomodoro divide o tempo de estudo em intervalos de trabalho e pausa, ajudando os usuários a manterem o foco e a produtividade durante suas sessões de estudo. |
| **Fluxo Principal**     | 1. O usuário acessa a ferramenta Pomodoro.<br/> 2. O usuário configura o tempo desejado para o estudo e a pausa.<br/> 3. O usuário inicia o temporizador e segue o ciclo de estudo/pausa. |

| **Nome de caso de uso** | Assistir Vídeos |
|-------------------------|-----------------|
| **Ator primário**       | Usuário - qualquer pessoa que interage com o sistema |
| **Descrição**           | Este caso de uso permite que os usuários assistam a vídeos disponíveis no site. Os usuários podem navegar pelo catálogo de vídeos, selecionar o vídeo desejado e reproduzi-lo na tela do dispositivo. |
| **Fluxo Principal**     | 1. O usuário navega até um vídeo de sua escolha.<br/> 2. O usuário clica no vídeo para iniciar a reprodução.<br/> 3. O vídeo é reproduzido na tela do usuário. |
