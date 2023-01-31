# automate-tests-google-search-page


## Desafio Prático - Automatizar a Página de Busca do Google

* Criar um projeto de automação de testes utilizando o Selenium WebDriver com o Dotnet na
versão mais recente. Automatizar a página de busca do Google validando os pontos que
forem importantes para assegurar que a página está funcionando conforme o esperado. Crie
quantos cenários de automação achar necessário.
* Avaliar e criticar a usabilidade da página de buscas do Google.
* Documentar todo o processo para subir a aplicação, preferencialmente no arquivo
“README”


## Tecnologias utilizadas

* C#
* .NET
* Visual Studio Code Community
* Selenium WebDriver 
* Selenium Grid
* Docker


## Pacotes utilizados

* MSTest.TestAdapter.3.0.2
* MSTest.TestFramework.3.0.2
* NUnit.3.13.3
* NUnit3TestAdapter.4.3.1
* Selenium.Support.4.7.0
* Selenium.WebDriver.4.7.0
* Selenium.WebDriver.ChromeDriver.108.0.5359.7100
* Selenium.WebDriver.GeckoDriver.0.32.0


## Como executar

1. Crie uma pasta
2. Abra o terminal dentro dela e digite o comando "pull clone git@github.com:linogt/automate-tests-google-search-page.git" para clonar o repositório
3. Abra a pasta "BuscaGoogle"
4. Abra o arquivo "BuscaGoogle.csproj" no Visual Studio Community.
5. Execute os testes

## Processo

### 1º Etapa - Criação dos Cenários de Testes

Nessa etapa foi feita a avaliação para decidir quais seriam os cenários de testes. Assim, em vista das funcionalidades oferecidas pelo Google, foram selecionadas as de conversão de moeda, cálculo aritiméticos, informações de tabela nutriconal e buscas específicas. Ademais, o layout da página e os caminhos para os links também foram selecionados para teste. Por fim, foram definidas as entradas e saídas esperadas em cada cenário.

### 2º Etapa - Criação dos Testes Automatizados

Para a etapa de criação dos testes automatizados foi utilizado a tecnologia Selenium WebDriver na linguagem C# com o .NET mais recente.

Ordem de criação do código

Classe TestFixture: Classe onde ficará os atributos, métodos, asserts, setup, teardown de cada cenário.
Classe SetUp: Classe que define o comportamento do teste antes dele ser executado, como por exemplo o sistema operacional e navegador utilizado.
Classe TearDown: Classe que define o comportamento do teste após a execução, como por exemplo a função de fechar driver.
Classe Test: Classe que define o comportamento do teste ao longo da sua execução, como por exemplo os asserts e métodos.

### 3º Etapa - Criação dos Métodos

Após a criação dos testes é feito uma análise para converter todo comportamento repetitivo em método.

### 4º Etapa - Testes no ambiente da máquina local

Nessa etapa os cenários foram testados no ambiente da máquina local (Windows) nos navegadores Google Chrome, Microsoft Edge e Firefox. Os resultados dos testes foram salvos em tabelas que podem ser conferidas na seção "Resultados" e "Tempo dos Testes".

Exemplos

Teste de Tabela Nutricional - Ambiente Windows - Navegador Google






https://user-images.githubusercontent.com/75547468/213669666-753b4076-3905-4a1f-a4e5-b870b9a968b8.mp4





Teste de Layout - Ambiente Windows - Navegador Firefox



https://user-images.githubusercontent.com/75547468/213669073-56cfa46d-142d-4f33-bad3-176595a8c646.mp4


Teste de Conversão - Ambiente Windows - Navegador Edge



https://user-images.githubusercontent.com/75547468/213668903-76181006-8809-4908-9d27-4c6ccc9144c4.mp4


### 5º Etapa - Testes no ambiente Linux

Para testar no ambiente Linux foi utilizado o software Docker em conjunto com o Selenium Grid. Nessa etapa os cenarios foram testados nos navegadores Google Chrome, Microsoft Edge e Firefox. Os resultados dos testes foram salvos em tabelas que podem ser conferidas na seção "Resultados" e "Tempo dos Testes".

Exemplo

Teste de Conversão - Ambiente Linux - Navegador Google



https://user-images.githubusercontent.com/75547468/213668758-14f5c4db-7c07-48d9-8cb0-6d0c6310d361.mp4


### 6º Etapa - Disponibilização do Projeto

Após a conclusão dos testes o código e seus resultados foram disponibilizados no GitHub

## Resultados


### Cenário 1 -  Perguntas

<table>
  <tr>
    <td>Id</td>
    <td>Funcionalidade/Componentes</td>
    <td>Título</td>
    <td>Passo-a-passo para execução</td>
    <td>Resultado Esperado</td>
    <td>Status</td>
  </tr>
  <tr>
    <td>1</td>
    <td>Busca</td>
    <td>Astronauta Lua</td>
    <td>Escreva "Qual é o nome do primeiro astronauta que pisou na lua?" no campo de busca e aperte "Enter".</td>
    <td>Neil Armstrong</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Busca</td>
    <td>Beatles</td>
    <td>Escreva "Ano do fim dos Beatles" no campo de busca e aperte "Enter".</td>
    <td>1970</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Busca</td>
    <td>Clube da Luta</td>
    <td>Escreva ""Ano de lançamento do filme Clube da Luta" no campo de busca e aperte "Enter".</td>
    <td>29 de outubro de 1999</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Busca</td>
    <td>Coca-Cola</td>
    <td>Escreva "Ano e local que a Coca Cola foi fundada" no campo de busca e aperte "Enter".</td>
    <td>1892, Atlanta, Geórgia, EUA</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>5</td>
    <td>Busca</td>
    <td>Corinthians</td>
    <td>Escreva "Data em que o Corinthians foi fundado" no campo de busca e aperte "Enter".</td>
    <td>1 de setembro de 1910</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>6</td>
    <td>Busca</td>
    <td>Grecia</td>
    <td>Escreva "Qual continente fica a Grecia" no campo de busca e aperte "Enter".</td>
    <td>Europa</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Busca</td>
    <td>Japão</td>
    <td>Escreva "Qual é a capital do Japão?" no campo de busca e aperte "Enter".</td>
    <td>Tóquio</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>8</td>
    <td>Busca</td>
    <td>Marvel</td>
    <td>Escreva "Fundador da Marvel" no campo de busca e aperte "Enter".</td>
    <td>Martin Goodman</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>9</td>
    <td>Busca</td>
    <td>Rússia</td>
    <td>Escreva "Qual maior país do mundo em km" no campo de busca e aperte "Enter".</td>
    <td>Rússia</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>10</td>
    <td>Busca</td>
    <td>Jujutsu Kaisen</td>
    <td>Escreva "Nome do protagonista de Jujutsu Kaisen" no campo de busca e aperte "Enter".</td>
    <td>Yuji Itadori</td>
    <td>Ok</td>
  </tr>
</table>


### Cenário 2 -  Cálculos Aritméticos

<table>
  <tr>
    <td>Id</td>
    <td>Funcionalidade/Componentes</td>
    <td>Título</td>
    <td>Passo-a-passo para execução</td>
    <td>Resultado Esperado</td>
    <td>Status</td>
  </tr>
  <tr>
    <td>1</td>
    <td>Busca</td>
    <td>Matemática1</td>
    <td>Insira a equação "2+2" no campo de busca, e aperte "Enter". </td>
    <td>4</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Busca</td>
    <td>Matemática2</td>
    <td>Insira a equação "2-2" no campo de busca, e aperte "Enter". </td>
    <td>0</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Busca</td>
    <td>Matemática3</td>
    <td>Insira a equação "2/2" no campo de busca, e aperte "Enter". </td>
    <td>1</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Busca</td>
    <td>Matemática4</td>
    <td>Insira a equação "2*2" no campo de busca, e aperte "Enter". </td>
    <td>4</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>5</td>
    <td>Busca</td>
    <td>Matemática5</td>
    <td>Insira a equação "2-2" no campo de busca, e aperte "Enter". </td>
    <td>0</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>6</td>
    <td>Busca</td>
    <td>Matemática6</td>
    <td>Insira a equação "-2-2" no campo de busca, e aperte "Enter". </td>
    <td>-4</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Busca</td>
    <td>Matemática7</td>
    <td>Insira a equação "2*10" no campo de busca, e aperte "Enter". </td>
    <td>20</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>8</td>
    <td>Busca</td>
    <td>Matemática8</td>
    <td>Insira a equação "20-50" no campo de busca, e aperte "Enter". </td>
    <td>-30</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Busca</td>
    <td>Matemática5</td>
    <td>Insira a equação "2^2" no campo de busca, e aperte "Enter". </td>
    <td>4</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>9</td>
    <td>Busca</td>
    <td>Matemática9</td>
    <td>Insira a equação "10+10" no campo de busca, e aperte "Enter". </td>
    <td>20</td>
    <td>OK</td>
  </tr>
  <tr>
    <td>10</td>
    <td>Busca</td>
    <td>Matemática10</td>
    <td>Insira a equação "0+0" no campo de busca, e aperte "Enter". </td>
    <td>0</td>
    <td>OK</td>
  </tr>
  
</table>


### Cenário 3 - Layout

<table>
  <tr>
    <td>Id</td>
    <td>Funcionalidade/Componentes</td>
    <td>Título</td>
    <td>Passo-a-passo para execução</td>
    <td>Resultado Esperado</td>
    <td>Status</td>
  </tr>
  <tr>
    <td>1</td>
    <td>Layout</td>
    <td>Como Funciona a Pesquisa</td>
    <td>O teste certifica que o texto está na página.</td>
    <td>A presença do texto no rodapé da página</td>
    <td>Ok</td> 
  </tr>
  <tr>
    <td>2</td>
    <td>Layout</td>
    <td>Configurações</td>
    <td>O teste certifica que o texto está na página.</td>
    <td>A presença do texto no rodapé da página</td>
    <td>Ok</td> 
  </tr>
  <tr>
    <td>3</td>
    <td>Layout</td>
    <td>Negócios</td>
    <td>O teste certifica que o texto está na página.</td>
    <td>A presença do texto no rodapé da página</td>
    <td>Ok</td> 
  </tr>
  <tr>
    <td>4</td>
    <td>Layout</td>
    <td>Privacidade</td>
    <td>O teste certifica que o texto está na página.</td>
    <td>A presença do texto no rodapé da página</td>
    <td>Ok</td> 
  </tr>
  <tr>
    <td>5</td>
    <td>Layout</td>
    <td>Publicidade</td>
    <td>O teste certifica que o texto está na página.</td>
    <td>A presença do texto no rodapé da página</td>
    <td>Ok</td> 
  </tr>
  <tr>
    <td>6</td>
    <td>Layout</td>
    <td>Termos</td>
    <td>O teste certifica que o texto está na página.</td>
    <td>A presença do texto no rodapé da página</td>
    <td>Ok</td> 
  </tr>
  <tr>
    <td>7</td>
    <td>Layout</td>
    <td>Sobre</td>
    <td>O teste certifica que o texto está na página.</td>
    <td>A presença do texto no rodapé da página</td>
    <td>Ok</td> 
  </tr>
</table>


### Cenário 4 - Conversor

<table>
  <tr>
    <td>Id</td>
    <td>Funcionalidade/Componentes</td>
    <td>Título</td>
    <td>Passo-a-passo para execução</td>
    <td>Resultado Esperado</td>
    <td>Status</td>
  </tr>
  <tr>
    <td>1</td>
    <td>Busca</td>
    <td>Dolar Para Euro</td>
    <td>Escreva "100 usd to eur" no campo de busca e aperte "Enter".</td>
    <td>A conversão de dolár para euro.</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Busca</td>
    <td>Euro Para Dolar</td>
    <td>Escreva "100 eur to usd" no campo de busca e aperte "Enter".</td>
    <td>A conversão de euro para dolár.</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Busca</td>
    <td>Reais Para Dolar</td>
    <td>Escreva "100 brl to usd" no campo de busca e aperte "Enter".</td>
    <td>A conversão de real para dolár.</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Busca</td>
    <td>Reais Para Euro</td>
    <td>Escreva "100 eur to usd" no campo de busca e aperte "Enter".</td>
    <td>A conversão de real para dolár.</td>
    <td>Ok</td>
  </tr>
</table>


### Cenário 5 - Tabela Nutricional

<table>
  <tr>
    <td>Id</td>
    <td>Funcionalidade/Componentes</td>
    <td>Título</td>
    <td>Passo-a-passo para execução</td>
    <td>Resultado Esperado</td>
    <td>Status</td>
  </tr>
  <tr>
    <td>1</td>
    <td>Busca específica</td>
    <td>Chocolate Cafeína</td>
    <td>Escreva "chocolate cafeína em 100g" no campo de busca e aperte "Enter".</td>
    <td>43 mg</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Busca específica</td>
    <td>Chocolate Calorias</td>
    <td>Escreva "chocolate calorias em 100g" no campo de busca e aperte "Enter".</td>
    <td>546 calorias</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Busca específica</td>
    <td>Chocolate Carboidratos</td>
    <td>Escreva "chocolate carboidratos em 100g" no campo de busca e aperte "Enter".</td>
    <td>61 g</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Busca específica</td>
    <td>Chocolate Gordura</td>
    <td>Escreva "chocolate gordura em 100g" no campo de busca e aperte "Enter".</td>
    <td>31 g</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Busca específica</td>
    <td>Chocolate Proteína</td>
    <td>Escreva "chocolate proteína em 100g" no campo de busca e aperte "Enter".</td>
    <td>4,9 g</td>
    <td>Ok</td>
  </tr>
</table>


### Cenário 6 - Links
<table>
  <tr>
    <td>Id</td>
    <td>Funcionalidade/Componentes</td>
    <td>Título</td>
    <td>Passo-a-passo para execução</td>
    <td>Resultado Esperado</td>
    <td>Status</td>
  </tr>
  <tr>
    <td>1</td>
    <td>Links</td>
    <td>Pesquisa Google</td>
    <td>Clicar em "Pesquisa Google".</td>
    <td>Manter-se na página de busca pois nada foi escrito na caixa.</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>2</td>
    <td>Links</td>
    <td>Estou com sorte</td>
    <td>Clicar em "Estou com sorte".</td>
    <td>Redirecionar o usuário para a página "Estou com sorte".</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>3</td>
    <td>Links</td>
    <td>Imagem</td>
    <td>Clicar em "Imagem".</td>
    <td>Redirecionar o usuário para a página "Imagem".</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Links</td>
    <td>Sobre</td>
    <td>Clicar em "Sobre".</td>
    <td>Redirecionar o usuário para a página "Sobre".</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>4</td>
    <td>Links</td>
    <td>Publicidade</td>
    <td>Clicar em "Publicidade".</td>
    <td>Redirecionar o usuário para a página "Publicidade".</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>5</td>
    <td>Links</td>
    <td>Negócios</td>
    <td>Clicar em "Negócios".</td>
    <td>Redirecionar o usuário para a página "Negócios".</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>6</td>
    <td>Links</td>
    <td>Como funciona a Pesquisa</td>
    <td>Clicar em "Como funciona a Pesquisa".</td>
    <td>Redirecionar o usuário para a página "Como funciona a Pesquisa".</td>
    <td>Ok</td>
  </tr>
  <tr>
    <td>7</td>
    <td>Links</td>
    <td>Privacidade</td>
    <td>Clicar em "Privacidade".</td>
    <td>Redirecionar o usuário para a página "Privacidade".</td>
    <td>Ok</td>
  </tr>
   <tr>
    <td>7</td>
    <td>Links</td>
    <td>Termos</td>
    <td>Clicar em "Termos".</td>
    <td>Redirecionar o usuário para a página "Termos".</td>
    <td>Ok</td>
  </tr>
  </table>
  
  ### Observações
  
  * Os testes foram feitos em paralelo
  * Ao testar no navegador FireFox foi adicionada a função Thread.Sleep(3000) no método PesquisarPergunta(), para que o navegador tenha 3 segundos para carregar a página antes de fazer a comparação.
  * O teste de Links não respondem bem no navegador Microsoft Edge. Apesar de possuir links diferentes e isso dificultar a automatização de testes, após uma análise manual é possível notar que todos os links estão funcionando como esperado. 
  
  ## Tempo dos Testes
  
  
  
  ### Sistema Operacional: Windows
  
  <table>
    <tr>
      <td>Navegador</td>
      <td>Cenário 1 - Perguntas</td>
      <td>Cenário 2 - Cálculos Aritméticos</td>
      <td>Cenário 3 - Layout</td>
      <td>Cenário 4 - Conversor</td>
      <td>Cenário 5 - Tabela Nutricional</td>
      <td>Cenário 6 - Links</td>
    </tr>
    <tr>
      <td>Google Chrome</td>
      <td>43,9 s</td>
      <td>50,4 s</td>
      <td>15,6 s</td>
      <td>30,6 s</td>
      <td>32,7 s</td>
      <td>31,9 s</td>
    </tr>
    <tr>
      <td>Microsoft Edge</td>
      <td>46,9 s</td>
      <td>49,1 s</td>
      <td>30,4 s</td>
      <td>39,6 s</td>
      <td>40,1 s</td>
      <td>33,1 s</td>
    </tr>
    <tr>
      <td>Firefox</td>
      <td>55,6 s</td>
      <td>54,9 s</td>
      <td>19,7 s</td>
      <td>41,6 s</td>
      <td>36,6 s</td>
      <td>1,2 min</td>
    </tr>
  </table>
  
  ### Sistema Operacional: Linux
  
  <table>
    <tr>
      <td>Navegador</td>
      <td>Cenário 1 - Perguntas</td>
      <td>Cenário 2 - Cálculos Aritméticos</td>
      <td>Cenário 3 - Layout</td>
      <td>Cenário 4 - Conversor</td>
      <td>Cenário 5 - Tabela Nutricional</td>
      <td>Cenário 6 - Links</td>
    </tr>
    <tr>
      <td>Google Chrome</td>
      <td>3,3 min</td>
      <td>3,6 min</td>
      <td>40 s</td>
      <td>1,4 min</td>
      <td>1,1 min</td>
      <td>1 min</td>
    </tr>
    <tr>
      <td>Microsoft Edge</td>
      <td>3,8 min</td>
      <td>4 min</td>
      <td>36,7 s</td>
      <td>2,2 min</td>
      <td>1,1 min</td>
      <td>3,5 min</td>
    </tr>
    <tr>
      <td>Firefox</td>
      <td>4,8 min</td>
      <td>5,6 min</td>
      <td>46 s</td>
      <td>2,4 min</td>
      <td>59,1 s</td>
      <td>4,2 min</td>
    </tr>
  </table>
  
  
  
  ## Avaliação Final
  
  A Página de Busca do Google passou em todos dos testes mostrando-se uma ferramente altamente eficaz com diversas utilidades. 
  
  ## Autor
  
  Gabriel Lino Topa Garcia
