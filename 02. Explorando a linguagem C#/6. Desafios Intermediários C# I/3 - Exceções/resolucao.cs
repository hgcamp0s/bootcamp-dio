using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class ExemploExcecoes
{
    static void Main(string[] args)
    {
        try
        {
            string[] linhas = File.ReadAllLines("Arquivos/d/arquivoLeitura.txt"); // Classe 'File' - lê um tipo arquivo , método 'ReadAllLines' - lê todas as linhas desse arquivo

            foreach (string linha in linhas)
            {
                Console.Write(linha);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
        }
        finally // Sempre no final do processamento vai executar independente de ter acontecido um erro ou não.
        {
            Console.WriteLine("Chegou até aqui");
        }
    }
}