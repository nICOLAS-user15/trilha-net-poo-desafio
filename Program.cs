using DesafioPOO.Models;

//OK TODO: Realizar os testes com as classes Nokia e Iphone

//TESTE NOKIA
Smartphone nokia = new Nokia("123456789");
nokia.SetModelo("Nokia 2780 Flip");
nokia.SetIMEI("ABC123456");
nokia.SetMemoria(16);

Console.WriteLine($"Celular modelo {nokia.GetModelo()} com IMEI {nokia.GetIMEI()} e {nokia.GetMemoria()}GB de memória.");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

//TESTE IPHONE
Smartphone iphone = new Iphone("987654321");
iphone.SetModelo("Iphone 14 Pro Max");
iphone.SetIMEI("DEFG78910");
iphone.SetMemoria(256);

Console.WriteLine($"Celular modelo {iphone.GetModelo()} com IMEI {iphone.GetIMEI()} e {iphone.GetMemoria()}GB de memória.");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
