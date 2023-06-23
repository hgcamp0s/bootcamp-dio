using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class LeituraArquivo
{
    // Metodo 'LerArquivo' , com tipo de retorno tupla, consiste de 3 informações, uma bool, um array de string e um inteiro
    public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
    {
        try // Pra ele ler as linhas do arquivo
        {
            string[] linhas = File.ReadAllLines(caminho); // Se ele conseguiu ler com sucesso, vai armazenar as linhas do arquivo
            return (true, linhas, linhas.Count()); // Vai retornar true pra 'Sucesso', linhas para o retorno do tipo 'Linhas' e 'Linhas.Count' pra contar quantas linhas tem e vai retornar pra 'QuantidadeLinhas'
        }
        catch(Exception)
        {
            return (false, new string[0], 0); // Caso falhe, vai retornar false para 'Sucesso', um array vazio para 'Linhas' e '0' para 'QuantidadeLinhas' 
        }     
    }
}