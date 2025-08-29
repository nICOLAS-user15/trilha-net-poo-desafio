namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama (falta proteger as propriedades Modelo, IMEI e Memoria com o protected)
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        //Métodos públicos para acesso externo
        public string GetModelo() => Modelo;
        public void SetModelo(string modelo) => Modelo = modelo;

        public string GetIMEI() => IMEI;
        public void SetIMEI(string imei) => IMEI = imei;

        public int GetMemoria() => Memoria;
        public void SetMemoria(int memoria) => Memoria = memoria;   

        public Smartphone(string numero)
        {
            Numero = numero;
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