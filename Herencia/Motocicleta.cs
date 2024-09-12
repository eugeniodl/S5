class Motocicleta : Vehiculo
{
    public bool TieneSidecar { get; set; }

    public Motocicleta(string marca, string modelo, bool tieneSidecar)
        : base(marca, modelo)
    {
        TieneSidecar = tieneSidecar;
    }

    public override void Acelerar(int incremento)
    {
        base.Acelerar(incremento);
        if (TieneSidecar)
        {
            Console.WriteLine($"{Marca} {Modelo} con sidecar aceleró.");
        }
    }
}
