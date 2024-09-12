class Administrador : Usuario
{
    public Administrador(string nombre)
        : base(nombre)
    {
    }

    public sealed override void Acceso()
    {
        Console.WriteLine($"{Nombre} tiene acceso completo al sistema.");
    }

    public void GestionarUsuarios()
    {
        Console.WriteLine($"{Nombre} está gestionando usuarios.");
    }
}
