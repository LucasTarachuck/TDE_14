public class Carro : Veiculo, IFeavel, IAceleravel
{
    public Carro(string marca, string modelo):base(marca, modelo)
    {

    }
    public override void Ligar()
    {
        Console.WriteLine($"O carro da marca {Marca} e modelo {Modelo} está ligado");
    }
    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando");
    }
    public void Frear()
    {
        Console.WriteLine("O carro freou");
    }
}