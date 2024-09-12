class Practicante : Empleado
{
    public Practicante(string nombre, decimal salarioBase)
        : base(nombre, salarioBase)
    {
    }

    // Ocultamiento de métodos
    public new void MostrarDetalles()
    {
        Console.WriteLine($"Practicante: {Nombre}, Salario de aprendiz.");
    }
}
