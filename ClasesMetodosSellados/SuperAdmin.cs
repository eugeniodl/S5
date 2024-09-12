class SuperAdmin : Administrador
{
    public SuperAdmin(string nombre)
        : base(nombre)
    {
    }

    // Este método no puede sobrescribirse debido al sello en Administrador
    // public override void Acceso() { }

    public new void GestionarUsuarios()
    {
        Console.WriteLine($"{Nombre} tiene privilegios adicionales para gestionar usuarios.");
    }
}
