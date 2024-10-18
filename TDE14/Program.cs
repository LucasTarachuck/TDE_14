using System.Collections.Concurrent;

var carro = new Carro("Hyundai", "HB20");
carro.Ligar();
carro.Acelerar();
carro.Frear();
carro.Desligar();
Console.WriteLine("");
var bicicleta = new Bicicleta("Monark", "Tigre");
bicicleta.Ligar();
bicicleta.Acelerar();
bicicleta.Desligar();
