class Usuario
{
    public string Nombre { get; set; }

    public Usuario(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void Acceso()
    {
        Console.WriteLine($"{Nombre} tiene acceso limitado.");
    }
}
