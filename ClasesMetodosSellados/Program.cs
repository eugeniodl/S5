Usuario user = new Usuario("Carlos");
user.Acceso();  // Acceso limitado

Administrador admin = new Administrador("Ana");
admin.Acceso();  // Acceso completo

SuperAdmin superAdmin = new SuperAdmin("Luis");
superAdmin.GestionarUsuarios();  // Método ocultado en SuperAdmin
