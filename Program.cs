using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Usando o smartphone NOKIA");
Smartphone nokia = new Nokia("1111","flip","3333", 5555);
nokia.InstalarAplicativo("watsap");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("Usando o smartphone IPHONE");
Smartphone Iphone = new Iphone("222","telapequena","7777", 8888);
Iphone.InstalarAplicativo("calculadora");
Iphone.Ligar();
Iphone.ReceberLigacao();


