# Metodologia

Após observar que várias plataformas de estudo, por mais que tenham bons conteúdos, existiam vários estímulos para “desfocar” o usuário. A partir desta identificação, o entendemos que poderia ser criado um site onde a metodologia proposta é que, após o cadastro do usuário, os vídeos que o usuário tenha interesse possam ser organizados e assistidos em único local sem interferência de estímulos externos. Além disso, com o intuito de facilitar o foco do usuário, será disponibilizado um calendário onde ele possa criar os eventos de estudo, um “pomodorometro” para gestão do tempo de estudo e um bloco de anotações para facilitar a notação dos pontos que o usuário achar necessário registrar.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Padrões de commits:

- `feat`- Commits do tipo feat indicam que seu trecho de código está incluindo um **novo recurso** (se relaciona com o MINOR do versionamento semântico).

- `fix` - Commits do tipo fix indicam que seu trecho de código commitado está **solucionando um problema** (bug fix), (se relaciona com o PATCH do versionamento semântico).

- `docs` - Commits do tipo docs indicam que houveram **mudanças na documentação**, como por exemplo no Readme do seu repositório. (Não inclui alterações em código).

- `test` - Commits do tipo test são utilizados quando são realizadas **alterações em testes**, seja criando, alterando ou excluindo testes unitários. (Não inclui alterações em código)

- `build` - Commits do tipo build são utilizados quando são realizadas modificações em **arquivos de build e dependências**.

- `perf` - Commits do tipo perf servem para identificar quaisquer alterações de código que estejam relacionadas a **performance**.

- `style` - Commits do tipo style indicam que houveram alterações referentes a **formatações de código**, semicolons, trailing spaces, lint... (Não inclui alterações em código).

- `refactor` - Commits do tipo refactor referem-se a mudanças devido a **refatorações que não alterem sua funcionalidade**, como por exemplo, uma alteração no formato como é processada determinada parte da tela, mas que manteve a mesma funcionalidade, ou melhorias de performance devido a um code review.

- `chore` - Commits do tipo chore indicam **atualizações de tarefas** de build, configurações de administrador, pacotes... como por exemplo adicionar um pacote no gitignore. (Não inclui alterações em código)

- `ci` - Commits do tipo ci indicam mudanças relacionadas a **integração contínua** (_continuous integration_).

- `raw` - Commits to tipo raw indicam mudanças relacionadas a arquivos de configurações, dados, features, parametros.

- `cleanup` - Commits do tipo cleanup são utilizados para remover código comentado, trechos desnecessários ou qualquer outra forma de limpeza do código-fonte, visando aprimorar sua legibilidade e manutenibilidade.

- `remove` - Commits do tipo remove indicam a exclusão de arquivos, diretórios ou funcionalidades obsoletas ou não utilizadas, reduzindo o tamanho e a complexidade do projeto e mantendo-o mais organizado.

## Gerenciamento de Projeto
A metodologia ágil escolhida para o desenvolvimento deste projeto foi o SCRUM. O Scrum foi escolhido por sua capacidade de proporcionar uma visão clara dos resultados, ritmo de execução, definição clara de papéis e responsabilidades, empowerment da equipe, compartilhamento de conhecimento e ambiente propício para críticas construtivas. 

### Divisão de Papéis

A equipe está organizada da seguinte maneira:
- Scrum Master: <b>Leticia Mateus</b>
- Product Owner: <b>Pedro Rosas</b>
- Equipe de Desenvolvimento:<br>
  - <b>Allan Antônio</b>
  - <b>Leticia Mateus</b><br>
  - <b>Marcus Vinícius</b><br>
  - <b>Pedro Rosas</b><br>
  - <b>Riniel Santos</b><br>


### Processo
Para a organização e distribuição das tarefas do projeto, a equipe está utilizando o Trello, estruturado com listas para cada etapa de desenvolvimento do projeto. Cada tarefa é representada por um cartão, e etiquetas são utilizadas para definir o estado atual de cada tarefa. Essa abordagem permite que a equipe acompanhe o progresso de forma eficiente e mantenha todos os membros informados sobre o status das atividades.
<figure> 
  <img src="img/trello.png"
</figure>

### Etiquetas
- To Do: Recebe essa etiqueta as tarefas que ainda não foram iniciadas. 
- Doing: Quando uma tarefa tiver sido iniciada, ela é marcada com essa etiqueta. 
- Done: Estas etiquetas são colocadas nas tarefas que passaram pelos testes e controle de qualidade e estão prontos para ser entregues ao usuário. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação.
<figure> 
  <img src="img/etiquetas-trello.png"
</figure>

### Ferramentas

Para o desenvolvimento do projeto, utilizamos um conjunto de ferramentas cuidadosamente selecionados para otimizar a colaboração e o gerenciamento de tarefas. Nossa equipe empregou as seguintes:

- Repositório de Código Fonte - [GitHub](https://github.com/)
- Documentos do Projeto - [GitHub](https://github.com/)
- Projeto de Interface - [Figma](https://www.figma.com/)
- Arquitetura e diagramas - [LucidChart](https://www.lucidchart.com/pages/pt)
- Gerenciamento do Projeto - [GitHub](https://github.com/)
- Hospedagem - [GitHub Pages](https://pages.github.com/)
- Editor de código - [Visual Studio Code](https://code.visualstudio.com/)
- Ferramentas de comunicação - [Microsoft Teams](https://teams.microsoft.com/) [Discord](https://discord.com/)

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela que se segue.

| AMBIENTE                            | PLATAFORMA                         | LINK DE ACESSO                         |
|-------------------------------------|------------------------------------|----------------------------------------|
| Repositório de código fonte         | GitHub                             |[EducaTube](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-educatube)|
| Documentos do projeto               | GitHub                             |[EducaTube/docs](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-educatube/tree/main/docs)|
| Projeto de Interface                | Figma                              |[Figma-EducaTube](https://www.figma.com/file/Q5QKGgUfDiAj1rEpmTljW9/Untitled?type=design&node-id=0-1&mode=design&t=5EBQxa6pY8AHGVh5-0)|
| Gerenciamento do Projeto            | GitHub                             |[Trello-EducaTube](https://trello.com/pt-BR)|
