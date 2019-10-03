Gerenciador de Autômatos Finitos
================================

Este programa é resultado de um trabalho acadêmico de linguagens formais escrito em 2007-2008. Pode ser útil para quem precisa de uma ferramenta básica para trabalhar com autômatos finitos. \
O programa foi escrito em C#, na época foi utilizado o Visual Studio 2005, agora já está convertido para VS2015, fique livre para melhorá-la.

![alt text](https://raw.githubusercontent.com/GustavoHennig/AutoMan/master/automan_screenshot.jpg "AutoMan")

## Començando

Para iniciar um autômato, é necessário seguir a seguinte ordem:
- Inserir o alfabeto.
- Inserir os estados.
- Definir as transições.
- Definir estado inicial e estados finais.

## Alfabeto
##### Adicionar Símbolo:
Clique em 'Adicionar Símbolo'.

##### Remover Símbolo:
Clique em 'Remover Símbolo' e escreva o nome do símbolo a ser removido, não se preocupe com maiúsculas e minúsculas.


## Estados
##### Adicionar Estado:
Clique em 'Adicionar Estado' e escreva o nome do novo estado.

##### Remover Estado:
Clique em 'Remover Estado' e escreva o nome do estado a ser removido.

##### Definir Estado Inicial:
Clique com o botão direito do mouse em cima da linha que representa o Estado desejado, depois clique em 'Definir como Estado Inicial'.

##### Definir Estado Final:
Clique com o botão direito do mouse em cima da linha que representa o Estado desejado, depois clique em 'Trocar: Final / Não Final'. Caso o estado seja não final ele passará a ser final e vice-versa.


## Transições
##### Adicionar Transição:
Para adicionar uma transição, clique com o botão direito do mouse sobre a célula que a transição deve ser adicionada, clique em 'Editar Transição', selecione o Estado destino, e clique em adicionar.

##### Remover Transição:
Para remover uma transição, repita o passo anterior e clique no botão 'Excluir'.
Para remover todas transições da célula, basta clicar com o botão direito do mouse sobre a mesmo e clicar em 'Excluir Transição'


## Funções do menu:
No menu 'Arquivo', é possível criar um novo autômato, salvar ou abrir um salvo anteriormente.
O Automato é gravado em um arquivo de formato XML, para facilitar a sua utilização em outros programas.

No menu 'Autômato', existem as memas opções da barra de ferramentas.

## Operações:
##### Valida Autômato:
Atualiza as informações exibidas em 'Erros Autômato' onde são exibidas todas as inconsistências encontradas no autômato atual.

##### AFND -> AFD:
Determiniza o autômato atual, caso seja necessário.

##### AFND-E -> AFND:
Remove as transições vazias do automato atual, caso elas existam.

##### Minimizar Autômato:
Minimza o autômato atual, removendo os estados mortos, inacessíveis e redundantes(na próxima versão).

##### Analisar Sentença:
Analisa qualquer sentença, exibindo uma mensagem se o automato atual foi reconhecido ou não.


*Gustavo Augusto Hennig*
