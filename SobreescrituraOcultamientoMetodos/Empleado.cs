class Empleado
{
    public string Nombre { get; set; }
    public decimal SalarioBase { get; set; }

    public Empleado(string nombre, decimal salarioBase)
    {
        Nombre = nombre;
        SalarioBase = salarioBase;
    }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Empleado: {Nombre}, Salario Base: {SalarioBase:C}");
    }
}
