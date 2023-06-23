using System;

class Teste2
{
    static void Main()
    {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double dividir = X / Y;

                if (dividir < 0 && dividir > 0.5)
                {
                    Console.WriteLine("-0.0");
                }
                else
                {
                    Console.WriteLine(Math.Round(dividir, 1).ToString("N1"));
                }
            }
        }
    }
}