class Gerente : Empleado
{
    public decimal Bono { get; set; }

    public Gerente(string nombre, decimal salarioBase, decimal bono)
        : base(nombre, salarioBase)
    {
        Bono = bono;
    }

    // Sobrescritura del método CalcularSalario
    public override decimal CalcularSalario()
    {
        return SalarioBase + Bono;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Gerente: {Nombre}, Salario Total: {CalcularSalario():C}");
    }
}
