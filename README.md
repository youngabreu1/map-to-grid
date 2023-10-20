<h1 align="center"> Map to Grid Converter </h1>


Esta é uma aplicação simples que utiliza como base a pasta “Mapas” do Playlist Digital e gera um arquivo “Relógio” para a pasta “Grades”.

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=flat)
## Entendendo o projeto

Com esta aplicação, fica fácil criar um arquivo do tipo “Relógio” para a pasta Grades do Playlist a partir dos horários dos seus comerciais.

“Mapas” é a pasta que representa a programação comercial do Playlist Digital, enquanto a pasta “Grades” representa a programação musical. Tendo isso em mente, esta aplicação tem como objetivo simplificar o uso do Playlist, realizando essa interação entre as duas pastas, de modo que os horários da programação musical sejam gerados levando em consideração os intervalos entre os blocos comerciais.


## Como funciona


O programa obtém o horário e a duração dos seus blocos comerciais e executa ações para criar um novo arquivo de texto que será usado como relógio na pasta “Grades”. 

Este arquivo é totalmente formatado e de fácil utilização. Basta indicar o caminho do arquivo comercial do qual você deseja criar um “Relógio”.



## Requisitos Funcionais

 - Leitura de mapa comercial: Ler um arquivo de mapa do bloco comercial;

 - Exportar relógio musical: Salvar um arquivo com os horários do bloco comercial.

## Requisitos não Funcionais

 - Interface para facilitar a utilização do usuário


## Como usar


1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
2. Abra o arquivo map-to-grid.sln, e modifique a variável path na classe Program.cs com o caminho do arquivo que deseja obter um Relógio musical.

3. Execute o aplicativo:

4. Certifique-se de ter um arquivo de entrada no formato adequado no diretório Mapas. Os resultados serão salvos no diretório Grades.



## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas e enviar pull requests.
