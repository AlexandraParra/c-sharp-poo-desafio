using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("=== Nokia ===");
Nokia nokia = new Nokia("12345", "Modelo 1", "111111111", 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n=== Iphone ===");
Iphone iphone = new Iphone("4987", "Modelo 2", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");