using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone cel1 = new Nokia(numero: "11995631052", modelo: "a350", iMEI: "123456", memoria: 256);
cel1.Ligar();
cel1.ReceberLigacao();
cel1.InstalarAplicativo("Telegram");

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Smartphone Iphone");
Smartphone cel2 = new Iphone(numero: "12985637456", modelo: "16", iMEI: "456789", memoria: 128) ;
cel2.Ligar();
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Instagram");