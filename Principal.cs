using TestePratico;
internal class Principal
{
    private static void Main(string[] args)
    {
        ConsumoCombustivel carro1 = new ConsumoCombustivel(50, "Gilmar");
        ConsumoCombustivel carro2 = new ConsumoCombustivel(55, "Juliana");
        ConsumoCombustivel carro3 = new ConsumoCombustivel(40, "Maria");

        carro1.Incluir(carro1);
        carro1.Incluir(carro2);
        carro1.Incluir(carro3);
        carro1.MostrarCarros();
    }
}