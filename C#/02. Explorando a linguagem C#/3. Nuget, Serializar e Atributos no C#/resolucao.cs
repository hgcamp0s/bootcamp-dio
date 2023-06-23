using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;



// 'Dynamic' - assume o valor que eu desejar
// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");















// TIPOS ANONIMOS EM COLEÇÃO

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// 'Select' - seleciona um novo tipo de dado
// 'x' - representa um elemento da sua lista
// E através dele você obtém os campos 'Produto' e 'Preco
// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
// }


















// DESERIALIZANDO UM OBJETO
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +  
//                       $"Preco: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//                       $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }












// SERIALIZANDO UM OBJETO

// DateTime dataAtual = DateTime.Now;

// // Uma nova lista de vendas(listaVendas) para agrupar minhas vendas(v1,v2)
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de software", 125.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// // 'SerializeObject' - serializa um objeto em uma string JSON, ou seja ele retorna uma string
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// // escreve um novo arquivo com o conteúdo deste objeto serializado
// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);