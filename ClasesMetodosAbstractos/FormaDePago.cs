abstract class FormaDePago
{
    public decimal Monto { get; set; }

    public FormaDePago(decimal monto)
    {
        Monto = monto;
    }

    // Método abstracto
    public abstract void ProcesarPago();

    // Método concreto
    public void MostrarMonto()
    {
        Console.WriteLine($"Procesando un pago de: {Monto:C}");
    }
}
