class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Velocidad { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Velocidad = 0;
    }

    public virtual void Acelerar(int incremento)
    {
        Velocidad += incremento;
        Console.WriteLine($"{Marca} {Modelo} aceleró a {Velocidad} km/h.");
    }

    public virtual void Frenar()
    {
        Velocidad = 0;
        Console.WriteLine($"{Marca} {Modelo} frenó y está detenido.");
    }
}
