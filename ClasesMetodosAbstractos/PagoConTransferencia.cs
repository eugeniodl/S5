class PagoConTransferencia : FormaDePago
{
    public string NumeroDeCuenta { get; set; }

    public PagoConTransferencia(decimal monto, string numeroDeCuenta)
        : base(monto)
    {
        NumeroDeCuenta = numeroDeCuenta;
    }

    public override void ProcesarPago()
    {
        MostrarMonto();
        Console.WriteLine($"Pago con transferencia bancaria a la cuenta: {NumeroDeCuenta}. Transacción completada.");
    }
}
