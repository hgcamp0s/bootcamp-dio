using DesafioPOO.Models;

class DesafioAbsCelular
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia(numero: "11111111", modelo: "modelo 1", imei: "111111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iPhone:");
        Iphone iphone = new Iphone(numero: "22222222", modelo: "modelo 2", imei: "222222222", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}