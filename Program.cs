using DesafioPOO.Models;
Iphone iphone = new Iphone("8199998888", "Iphone 14", "1234", 256);
Nokia nokia = new Nokia("8166663333", "Nokia tijolão", "5678", 128);

iphone.Ligar();
nokia.Ligar();

iphone.ReceberLigacao();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Instagram");
