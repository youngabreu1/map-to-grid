# Map to Grid Converter

Este é um utilitário simples para converter um arquivo da pasta Mapas para objetos DateTime e, em seguida, salvar os horários para a programação musical em um arquivo.

## Como funciona

- A classe Program contém o caminho do arquivo da pasta Mapas do playlist a ser lido, e ao instanciar um objeto da classe ToGrid e chamar a função GetData e passar esse caminho como parâmetro,
o arquivo é lido com o comando File.ReadAllLines, que armazena cada linha do arquivo em um array.

- Após obter um array com cada linha do arquivo de Mapas, é utilizado um .ToList neste array para transformá-lo em uma lista, e é passado um foreach nessa lista para obter dois valores específicos e os armazenando em listas de string separadas,
time e dur, que seriam a hora e a duração dos blocos comerciais.
- Em seguida, é utilizado outro laço de repetição para alimentar a lista gridTime do tipo TimeSpan, para somar as informações da lista time<string> e dur<string> com o intuito de obter a hora exata de término da programação comercial.
- Com essas informações, já é possível escrever um arquivo com o comando File.WriteAllLines, mas a função não aceita como parâmetro TimeSpan, apenas Strings, então foi necessário criar uma nova lista do tipo DateTime, tendo em vista que não é possível utilizar o .ToString em objetos TimeSpan.
- Então o programa percorre a lista gridTime<TimeSpan> e adiciona à lista toDateTime<DateTime> apenas o item.Ticks que representa o valor do item do tipo TimeSpan em Ticks.
- Com isso, é possível utilizar uma nova lista de strings doc<string> receber a lista toDateTime e utilizar o .ToString e receber apenas o formato de horário desejado.
- Em fim, é possível utilizar o File.WriteAllLines e passar como parâmetro o diretório desejado para realizar a criação ou a sobrescrita do novo arquivo Relógio da pasta grades e a lista doc<string> para escrever as informações desejadas no arquivo.

  
## Requisitos

- .NET Core SDK [Instalar](https://dotnet.microsoft.com/download)

## Como usar

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio

2. Execute o aplicativo:

3. Certifique-se de ter um arquivo de entrada no formato adequado no diretório Mapas. Os resultados serão salvos no diretório Grades.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas e enviar pull requests.
