namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama (falta proteger as propriedades Modelo, IMEI e Memoria com o protected)
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }


        public Smartphone(string numero)
        {
            Numero = numero;
            //OK TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = "";
            IMEI = "";
            Memoria = 0;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}