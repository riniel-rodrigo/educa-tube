# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas nas Figuras seguintes.
|(img/Monalisa.png)| **Mona Lisa**              |
|--------------------|------------------------------------|
|**idade**:28 **Ocupação**:Modelo vivo de referência artística e influenciadora digital| Aplicativos: * Instagram* TikTok* YouTube* Pinterest          | 
| | |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |

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

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades de interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais
A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site permite cadastrar o usuário. | ALTA | 
|RF-002| O site deve oferecer ao usuário a página de Login para ser efetuado o acesso ao site.   | ALTA  |
|RF-003| O site deve oferecer ao usuário ferramentas de criação, edição, adição e remoção de playlists do perfil do usuário(CRUD).   | ALTA  |
|RF-004| O site deve oferecer ao usuário uma área de comentários abaixo dos vídeos.   | MÉDIA  |
|RF-005| O site deve oferecer ao usuário um sistema onde ele possa fazer anotações e salvá-las.    | ALTA  |
|RF-006| O site deve permitir visualizar o histórico de vídeos assistidos.   | BAIXO  |
|RF-007| O site deve oferecer ao usuário ferramentas de busca local de vídeos ou playlists.   | ALTA  |
|RF-008| O site deve permitir salvar conteúdos preferidos  | BAIXO  |
|RF-009| O site deve oferecer ao usuário agenda pessoal editável e compartilhável(CRUD).   | MÉDIA  |
|RF-010| O site deve oferecer ao usuário pomodorometro para ajudar a organizar o tempo de estudo.  | BAIXO  |
|RF-011| O site deve permitir ao usuário assistir vídeos  | BAIXO  |

### Requisitos não Funcionais
A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-002| O site deverá ser responsivo, permitindo a visualização em um celular de forma adequada |  ALTA | 
|RNF-003| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 
|RNF-004| O sistema de identificação do usuário deve permitir recuperar senha em caso de esquecimento, mudar senha quando necessário e identificar quando o usuário está logado. |  ALTA | 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 04/07/2024.|
|RE-02| O aplicativo deve utilizar as tecnologias básicas da Web no Frontend e Backend.      |
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.     |


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
