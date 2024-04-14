# Plano de Testes de Software


### Critérios de Início do Plano de Teste
A execução do teste começará logo após a finalização da implementação do primeiro requisito indicado no documento de requisitos. Após cada implementação de um requisito, os testes específicos serão conduzidos.

### Critérios de Término do Plano de Teste
Os testes de um requisito serão considerados completos quando a lista de testes for executada sem encontrar erros ou quando um erro for encontrado e impedir a continuação da lista de testes do requisito. Após a conclusão dos testes de todos os requisitos, se nenhum problema for detectado, o plano de teste será finalizado. Caso contrário, será suspenso até que os problemas sejam resolvidos.

### Critérios de Suspensão e Retomada
Se ocorrer um problema de desenvolvimento que interrompa os testes do requisito, eles serão suspensos até que o problema seja resolvido. Após a resolução, os testes serão retomados para validar o requisito. Se surgir um problema durante os testes e for possível continuar, a lista de testes será executada novamente após a resolução do problema. Quando os testes de um requisito forem concluídos sem erros, serão considerados finalizados. Esse processo será repetido até que todos os requisitos sejam testados com sucesso.

Por exemplo:
 
| **Caso de Teste** | **CT-001 - Cadastro de Usuário** |
|:---:|:---:|
| Requisito Associado | RF-001 - O site permite cadastrar o usuário. |
| Objetivo do Teste | Verificar se o usuário consegue se cadastrar no site. |
| Passos | 1. Acessar a página de registro do site. <br> 2. Preencher o formulário de registro com informações válidas. <br> 3. Submeter o formulário de registro. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-002 - Login do Usuário** |
| Requisito Associado | RF-002 - O site deve oferecer ao usuário a página de Login para ser efetuado o acesso ao site. |
| Objetivo do Teste | Verificar se o usuário consegue realizar o login no site. |
| Passos | 1. Acessar a página de login do site. <br> 2. Preencher o formulário de login com credenciais válidas. <br> 3. Submeter o formulário de login. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-003 - Gerenciar Playlists** |
| Requisito Associado | RF-003 - O site deve oferecer ao usuário ferramentas de criação, edição, adição e remoção de playlists do perfil do usuário (CRUD). |
| Objetivo do Teste | Verificar se o usuário consegue gerenciar suas playlists (criar, editar, adicionar e remover) corretamente. |
| Passos | 1. Acessar o perfil do usuário. <br> 2. Navegar até a seção de playlists. <br> 3. Criar uma nova playlist. <br> 4. Editar uma playlist existente. <br> 5. Adicionar vídeos à playlist. <br> 6. Remover vídeos da playlist. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-004 - Comentários em Vídeos** |
| Requisito Associado | RF-004 - O site deve oferecer ao usuário uma área de comentários abaixo dos vídeos. |
| Objetivo do Teste | Verificar se existe uma área de comentários disponível abaixo dos vídeos assistidos. |
| Passos | 1. Assistir a um vídeo no site. <br> 2. Verificar se há uma seção de comentários abaixo do vídeo. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-005 - Sistema de Anotações** |
| Requisito Associado | RF-005 - O site deve oferecer ao usuário um sistema onde ele possa fazer anotações e salvá-las. |
| Objetivo do Teste | Verificar se o usuário pode fazer anotações e salvá-las corretamente no sistema. |
| Passos | 1. Acessar a funcionalidade de anotações no site. <br> 2. Criar uma nova anotação. <br> 3. Salvar a anotação. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-006 - Visualizar Histórico de Vídeos Assistidos** |
| Requisito Associado | RF-006 - O site deve permitir visualizar o histórico de vídeos assistidos. |
| Objetivo do Teste | Verificar se o usuário consegue visualizar seu histórico de vídeos assistidos no site. |
| Passos | 1. Acessar o perfil do usuário. <br> 2. Navegar até a seção de histórico de vídeos assistidos. |
| Critério de Êxito | O histórico de vídeos assistidos é exibido corretamente para o usuário. |
|   |   |
| **Caso de Teste** | **CT-007 - Busca Local de Vídeos ou Playlists** |
| Requisito Associado | RF-007 - O site deve oferecer ao usuário ferramentas de busca local de vídeos ou playlists. |
| Objetivo do Teste | Verificar se o usuário pode realizar uma busca local de vídeos ou playlists no site. |
| Passos | 1. Utilizar a ferramenta de busca no site. <br> 2. Digitar o termo de busca na barra de pesquisa. <br> 3. Analisar os resultados da busca. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-008 - Salvar Conteúdos Preferidos** |
| Requisito Associado | RF-008 - O site deve permitir salvar conteúdos preferidos. |
| Objetivo do Teste | Verificar se o usuário pode salvar conteúdos preferidos no site. |
| Passos | 1. Navegar até o conteúdo desejado. <br> 2. Clicar no botão "Salvar" ou equivalente. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-009 - Gerenciar Agenda Pessoal** |
| Requisito Associado | RF-009 - O site deve oferecer ao usuário agenda pessoal editável e compartilhável (CRUD). |
| Objetivo do Teste | Verificar se o usuário pode criar, editar, visualizar e excluir eventos na sua agenda pessoal. |
| Passos | 1. Acessar a seção da agenda pessoal. <br> 2. Criar um novo evento. <br> 3. Editar um evento existente. <br> 4. Visualizar os eventos na agenda. <br> 5. Excluir um evento. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-010 - Utilizar Pomodoro para Organizar Tempo de Estudo** |
| Requisito Associado | RF-010 - O site deve oferecer ao usuário pomodoro para ajudar a organizar o tempo de estudo. |
| Objetivo do Teste | Verificar se o usuário consegue utilizar a técnica de pomodoro para organizar seu tempo de estudo. |
| Passos | 1. Acessar a ferramenta de pomodoro no site. <br> 2. Configurar o tempo de estudo e de pausa. <br> 3. Iniciar a sessão de estudo. |
| Critério de Êxito | Em Análise. |
|   |   |
| **Caso de Teste** | **CT-011 - Assistir Vídeos no Site** |
| Requisito Associado | RF-011 - O site deve permitir ao usuário assistir vídeos. |
| Objetivo do Teste | Verificar se o usuário consegue assistir vídeos no site. |
| Passos | 1. Navegar até a página de vídeos. <br> 2. Selecionar um vídeo para assistir. <br> 3. Reproduzir o vídeo. |
| Critério de Êxito | Em Análise. |
