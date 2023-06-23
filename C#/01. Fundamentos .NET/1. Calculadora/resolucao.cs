using Calculadora.Models;

namespace Calculadora.Models
{
    class Calc
    {
        static void Main(string[] args)
        {
            ExemploCalculadora calc = new ExemploCalculadora();

            string opcao = string.Empty;
            bool exibirMenu = true;


            // Realiza o loop do Menu
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("1 - SOMAR");
                Console.WriteLine("2 - SUBTRAIR");
                Console.WriteLine("3 - MULTIPLICAR");
                Console.WriteLine("4 - DIVIDIR");
                Console.WriteLine("5 - POTENCIA");
                Console.WriteLine("6 - SENO");
                Console.WriteLine("7 - COSENO");
                Console.WriteLine("8 - TANGENTE");
                Console.WriteLine("9 - RAIZ QUADRADA");
                Console.WriteLine("0 - ENCERRAR");

                switch (Console.ReadLine())
                {
                    case "1":
                        calc.Somar();
                        break;

                    case "2":
                        calc.Subtrair();
                        break;

                    case "3":
                        calc.Multiplicar();
                        break;

                    case "4":
                        calc.Dividir();
                        break;

                    case "5":
                        calc.Potencia();
                        break;

                    case "6":
                        calc.Seno();
                        break;

                    case "7":
                        calc.Coseno();
                        break;

                    case "8":
                        calc.Tangente();
                        break;

                    case "9":
                        calc.RaizQuadrada();
                        break;

                    case "0":
                        exibirMenu = false;
                        break;

                    default:
                        Console.Write("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar ...");
                Console.ReadLine();
            }
        }
    }
}