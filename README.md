# ClientFileManager
Esse código é um exemplo básico de como criar um sistema de cadastro de clientes em C#, utilizando conceitos como classes, métodos, tratamento de exceções e manipulação de arquivos.

## Estrutura do projeto
O projeto está organizado em três partes principais:
Entidade (Cliente): Representa a estrutura de dados do cliente.
Repositório (ClienteRepository): Responsável por gravar os dados do cliente em um arquivo.
Programa Principal (Program): Responsável por interagir com o usuário e coordenar a execução do programa.

### Entidade (Cliente)

![image](https://github.com/user-attachments/assets/3a560686-ed2e-451e-8222-7d4bb879d7a1)

A classe Cliente é uma entidade que representa um cliente com os seguintes atributos:

- Id: Um identificador único do tipo Guid.

- Nome: O nome do cliente, do tipo string.

- Email: O email do cliente, do tipo string.

- Cpf: O CPF do cliente, do tipo string.

- DataNascimento: A data de nascimento do cliente, do tipo DateTime.

#

### Repositório (ClienteRepository)
![image](https://github.com/user-attachments/assets/b6787236-5993-436b-a163-f5277a0ec7a3)

A classe ClienteRepository é responsável por gravar os dados do cliente em um arquivo de texto. Ela contém um método chamado GravarArquivo, que recebe um objeto Cliente como parâmetro e grava suas informações em um arquivo.

#

### Programa principal (Program)
![image](https://github.com/user-attachments/assets/95a3c5a3-7616-4b61-921c-7d617919119e)

A classe Program contém o método Main, que é o ponto de entrada do programa. Ele interage com o usuário para coletar os dados do cliente e, em seguida, usa o ClienteRepository para gravar esses dados em um arquivo.


## Fluxo de execução

1 - Inicialização: O programa começa exibindo uma mensagem de boas-vindas.

2 - Coleta de Dados: O programa solicita ao usuário que insira o nome, CPF, email e data de nascimento do cliente.

3 - Gravação dos Dados: Os dados coletados são gravados em um arquivo de texto usando o método GravarArquivo da classe ClienteRepository.

4 - Feedback: Se o cadastro for bem-sucedido, o programa exibe uma mensagem de sucesso e os dados do cliente. Caso contrário, exibe uma mensagem de erro.

5 - Finalização: O programa pausa para que o usuário possa visualizar os resultados antes de fechar.
