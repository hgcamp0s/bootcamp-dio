using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Venda
{
    public int Id { get; set; }

    // Está adicionando uma informação adicional a minha propriedade 'Produto'
    [JsonProperty("Nome_Produto")] // Mantem a nomenclatura original do arquivo json origem
    public string Produto { get; set; } // Meu objeto tem o nome 'Produto' mas vai vir de 'Nome_Produto'
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
    public decimal? Desconto { get; set; }
}