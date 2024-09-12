class Automovil : Vehiculo
{
    public int NumeroDePuertas { get; set; }

    public Automovil(string marca, string modelo, int numeroDePuertas)
        : base(marca, modelo)
    {
        NumeroDePuertas = numeroDePuertas;
    }

    public override void Acelerar(int incremento)
    {
        base.Acelerar(incremento);
        Console.WriteLine($"{Marca} {Modelo} (automóvil) tiene {NumeroDePuertas} puertas.");
    }
}
