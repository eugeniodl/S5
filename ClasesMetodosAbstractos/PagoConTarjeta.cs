class PagoConTarjeta : FormaDePago
{
    public string NumeroDeTarjeta { get; set; }

    public PagoConTarjeta(decimal monto, string numeroDeTarjeta)
        : base(monto)
    {
        NumeroDeTarjeta = numeroDeTarjeta;
    }

    public override void ProcesarPago()
    {
        MostrarMonto();
        Console.WriteLine($"Pago con tarjeta: {NumeroDeTarjeta}. Transacción completada.");
    }
}
