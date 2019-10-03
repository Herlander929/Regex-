Gerenciador de Aut�matos Finitos
================================

Este programa � resultado de um trabalho acad�mico de linguagens formais escrito em 2007-2008. Pode ser �til para quem precisa de uma ferramenta b�sica para trabalhar com aut�matos finitos. \
O programa foi escrito em C#, na �poca foi utilizado o Visual Studio 2005, agora j� est� convertido para VS2015, fique livre para melhor�-la.

![alt text](https://raw.githubusercontent.com/GustavoHennig/AutoMan/master/automan_screenshot.jpg "AutoMan")

## Comen�ando

Para iniciar um aut�mato, � necess�rio seguir a seguinte ordem:
- Inserir o alfabeto.
- Inserir os estados.
- Definir as transi��es.
- Definir estado inicial e estados finais.

## Alfabeto
##### Adicionar S�mbolo:
Clique em 'Adicionar S�mbolo'.

##### Remover S�mbolo:
Clique em 'Remover S�mbolo' e escreva o nome do s�mbolo a ser removido, n�o se preocupe com mai�sculas e min�sculas.


## Estados
##### Adicionar Estado:
Clique em 'Adicionar Estado' e escreva o nome do novo estado.

##### Remover Estado:
Clique em 'Remover Estado' e escreva o nome do estado a ser removido.

##### Definir Estado Inicial:
Clique com o bot�o direito do mouse em cima da linha que representa o Estado desejado, depois clique em 'Definir como Estado Inicial'.

##### Definir Estado Final:
Clique com o bot�o direito do mouse em cima da linha que representa o Estado desejado, depois clique em 'Trocar: Final / N�o Final'. Caso o estado seja n�o final ele passar� a ser final e vice-versa.


## Transi��es
##### Adicionar Transi��o:
Para adicionar uma transi��o, clique com o bot�o direito do mouse sobre a c�lula que a transi��o deve ser adicionada, clique em 'Editar Transi��o', selecione o Estado destino, e clique em adicionar.

##### Remover Transi��o:
Para remover uma transi��o, repita o passo anterior e clique no bot�o 'Excluir'.
Para remover todas transi��es da c�lula, basta clicar com o bot�o direito do mouse sobre a mesmo e clicar em 'Excluir Transi��o'


## Fun��es do menu:
No menu 'Arquivo', � poss�vel criar um novo aut�mato, salvar ou abrir um salvo anteriormente.
O Automato � gravado em um arquivo de formato XML, para facilitar a sua utiliza��o em outros programas.

No menu 'Aut�mato', existem as memas op��es da barra de ferramentas.

## Opera��es:
##### Valida Aut�mato:
Atualiza as informa��es exibidas em 'Erros Aut�mato' onde s�o exibidas todas as inconsist�ncias encontradas no aut�mato atual.

##### AFND -> AFD:
Determiniza o aut�mato atual, caso seja necess�rio.

##### AFND-E -> AFND:
Remove as transi��es vazias do automato atual, caso elas existam.

##### Minimizar Aut�mato:
Minimza o aut�mato atual, removendo os estados mortos, inacess�veis e redundantes(na pr�xima vers�o).

##### Analisar Senten�a:
Analisa qualquer senten�a, exibindo uma mensagem se o automato atual foi reconhecido ou n�o.


*Gustavo Augusto Hennig*
