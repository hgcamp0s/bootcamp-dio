using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


/* DICTIONARY */

// É uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica

// Declarando um tipo 'Dictionary' .. passando seus elementos 1 (sua chave) e elemento 2 (seu tipo), nesse caso, passando a chave como string, e o valor como string
// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);


// Alternativa do 'var' para declarar o tipo que você está trabalhando
// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-----------------------");

// estados.Remove("BA"); // Removendo "BA" passando a chave
// estados["SP"] = "São Paulo - valor alterado";

// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave)) // Esse método verifica se uma chave já foi adicionada ou não
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else 
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

























/* DECLARANDO UMA PILHA */

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4); // Metodo 'Push' insere um elemento no topo da pilha
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// // pilha.Pop(); // Metodo 'Pop' remove e retorna o objeto no topo da pilha
// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }





















/* ADICIONANDO E REMOVENDO UM ELEMENTO DA FILA */

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2); // Vai adicionar um elemento ao fim da fila.
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


// fila.Dequeue(); // Remove um elemento da sua fila, sempre vai remover o primeiro elemento




















// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/d/arquivoLeitura.txt"); // Classe 'File' - lê um tipo arquivo , método 'ReadAllLines' - lê todas as linhas desse arquivo

//     foreach (string linha in linhas)
//     {
//         Console.Write(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. " + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally // Sempre no final do processamento vai executar independente de ter acontecido um erro ou não.
// {
//     Console.WriteLine("Chegou até aqui");
// }














// string dataString = "2022-04-17 18:00"; // objeto estanciado para verificar se é um data válida no método a baixo

// bool sucesso = DateTime.TryParseExact(dataString, // 'TryParseExact' vai retornar verdadeiro caso consiga converter
//                        "yyyy-MM-dd HH:mm", // Representação de Ano/Mes/dia Hora:Minuto
//                        CultureInfo.InvariantCulture, // Busca a localização da sua região
//                        DateTimeStyles.None, out DateTime data); // 'out DateTime' se ele conseguir converter , ele vai jogar numa variável chamada 'data'

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// DateTime data = DateTime.Parse(dataString);
















// Converte uma data válida para o tipo 'DateTime'

// DateTime data = DateTime.Parse("17/04/2023 18:00");
// Console.WriteLine(data);













//DateTime data = DateTime.Now;

// Método para imprimir apenas a hora
//Console.WriteLine(data.ToShortTimeString());

// Método para imprimir apenas a data
//Console.WriteLine(data.ToShortDateString());


// Representando data e hora no formato normal, você pode formatar da maneira que lhe atender
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));















// // Altera a locaização de região que o código vai buscar o apontamento
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1582.40M;

// // Obs: Pega as informações de acordo com as configurações do seu sistema local
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// // Console.WriteLine($"{valorMonetario:C}"); // 'C:' significa currence, moeda, ou seja eu quero formatar esse meu valor em uma moeda



// // 'C8' signifca curse e o '8' o numero de casas decimais a serem exibidos no resultado impresso
// // Console.WriteLine(valorMonetario.ToString("C8"));



// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P")); // Representa a porcentagem de um número

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##")); // ALtera o formato onde '#' representa digitos , e o traço o '-'














// INSTANCIANDO DUAS NOVAS "PESSOA"

// Pessoa p1 = new Pessoa("Hugo","Campos");
// // p1.Nome = "Hugo";
// // p1.Sobrenome = "Campos";

// Pessoa p2 = new Pessoa("Bianca", "Oliveira");
// // p2.Nome = "Bianca";
// // // p2.Sobrenome = "Oliveira";

// INSTANCIANDO UM NOVO "CURSO"

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();















// INSTANCIANDO UMA "PESSOA"

// Pessoa p1 = new Pessoa();

// Console.WriteLine("Digite seu nome:");
// p1.Nome = Console.ReadLine();
// Console.WriteLine("Digite seu sobrenome:");
// p1.Sobrenome = Console.ReadLine();
// Console.WriteLine("Digite sua idade:");
// p1.Idade = Convert.ToInt32(Console.ReadLine());

// p1.Apresentar();











/* EXEMPLO DE TIPOS DE REFERÊNCIA */

// int a = 10;

// // Tipos simples, apenas fazem uma cópia
// int b = a;
// b = 60;

// Console.WriteLine($"Valor de A: {a}");
// Console.WriteLine($"Valor de B: {b}");

// // Está fazendo um apontamento pra mesma referência do objeto, se você alterar um, você está alterando o outro
// Pessoa p1 = new Pessoa();
// Pessoa p2 = p1;
