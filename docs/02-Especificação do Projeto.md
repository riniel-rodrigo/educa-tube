# Especificações do Projeto

A partir da participação dos usuários descritos abaixo, através de entrevista, conseguimos definir os problemas e os pontos mais relevantes a serem tratados no projeto. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas nas Figuras seguintes.
<table>
     <tbody>
        <tr>
            <td colspan=1 rowspan=2><img src='img/Monalisa.png'  width="160" height="200"></td>
            <td colspan=2 rowspan=1><b>Mona Lisa</b></td>
        </tr>
       <tr>
            <td><b>idade: 28</b><br> <b>Ocupação</b>:<br> Modelo vivo de referência artística e influenciadora digital</td>
            <td><b>Aplicativos</b>:<br>  * Instagram<br> * TikTok<br> * YouTube<br> * Pinterest<br></td>
        </tr>
        <tr>
            <td><b>Motivações</b>:<br>  * Deixar uma marca no mundo das artes<br>  * Sorrir de forma ambígua<br>  * Causar questionamentos existenciais em filósofos de boteco<br></td>
          <td><b>Frustrações</b>: <br> * O Bourjois<br> * O patriarcado<br> * Cobrança de 8 USD  para ter perfil premium no X<br> * Não ser levada a sério<br></td>
          <td><b>Hobbies, História</b>: <br> * Posar de modelo vivo para grandes pintores renascentistas<br> * Foi a musa de um dos mais relevantes mestres da pintura, arquitetura e matemática de seu tempo<br> </td>
        </tr>
    </tbody>
</table>
<br>
<table>
     <tbody>
        <tr>
            <td colspan=1 rowspan=2 style="margin: auto;"><img src='img/Jasuscristo.png' width="160px" height="200px" ></td>
            <td colspan=2 rowspan=1><b>Jesus Cristo</b></td>
        </tr>
       <tr>
            <td><b>idade: 32</b><br> <b>Ocupação</b>:<br> Profeta, messias e milagreiro</td>
            <td><b>Aplicativos</b>:<br>  * Facebook<br> * LinkedIn<br> * TikTok<br> * Tinder<br></td>
        </tr>
        <tr>
            <td><b>Motivações</b>:<br>  * Salvar a vida de todos os irmãos<br>  * Paz no mundo<br>  * Espalhar a boa nova<br></td>
          <td><b>Frustrações</b>: <br> * Um cara chamado Judas Iscariot<br> * Mercados dentro de templos<br> * Gente que joga pedra<br> * Lepra?<br></td>
          <td><b>Hobbies, História</b>: <br> * Conversar<br> * Mágica de rua<br> * Lavar pés de gente desconhecida<br> * Debates a céu aberto<br> * Acampar<br>  * Trilha pelo deserto<br> * Escalada<br>
 </td>
        </tr>
    </tbody>
</table>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Mona Lisa | visualizar os conteúdos mais relevantes do momento | acessar conteúdos das áreas que me interessam |
|Mona Lisa | visualizar conteúdos mais alinhadas com minha área de atuação | gastar menos tempo vendo conteúdos aleatórios e dar foco naqueles que estão relacionados com o meu trabalho |
|Mona Lisa | Fazer anotações relevantes aos conteúdos que estou acessando | Ajuda a manter uma linha de raciocínio coesa   |
|Jesus Cristo | fazer comentários em conteúdos e reportar minha opinião | discutir com grupos de interesse comum |
|Jesus Cristo | compartilhar conteúdos para amigos e conhecidos | poder compartilhar com os amigos e colegas de trabalhos sobre temas de interesse |
|Mona Lisa | poder realizar uma pesquisa acerca de um tema específico | localizar tópicos específicos e conseguir maior objetividade em alguns conteúdos |
|Jesus Cristo | acessar conteúdos tanto no desktop quanto no celular | Acessar de forma conveniente, indiferente da situação o conteúdo que me interessa |
|Mona Lisa | Quero organizar minha agenda de estudos | Organizar uma agenda de estudos direcionada para meus objetivos|



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
