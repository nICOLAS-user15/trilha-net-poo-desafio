using DesafioPOO.Models;

//OK TODO: Realizar os testes com as classes Nokia e Iphone

//TESTE NOKIA
Smartphone nokia = new Nokia("");
nokia.Modelo = "Nokia 3310";
nokia.IMEI = "123456789012345";
nokia.Memoria = 16;
Console.WriteLine($"Nokia - Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

//TESTE IPHONE
Smartphone iphone = new Iphone("");
iphone.Modelo = "iPhone 13";
iphone.IMEI = "987654321098765";
iphone.Memoria = 128;
Console.WriteLine($"iPhone - Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
