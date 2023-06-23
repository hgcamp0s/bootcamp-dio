namespace DesafioPOO.Models
{
    // "Iphone" herda da classe "Smartphone"
    public class Iphone : Smartphone
    { 
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // Sobrescreve o método "InstalarAplicativo" da classe "Smartphone"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo \""+ nomeApp +"\" no iPhone");
        }
    }
}