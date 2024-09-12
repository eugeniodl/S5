Empleado emp1 = new Empleado("Juan", 3000);
Empleado emp2 = new Gerente("Lucía", 4000, 1000);
Empleado emp3 = new Practicante("Carlos", 1200);

emp1.MostrarDetalles();  // Muestra detalles básicos
emp2.MostrarDetalles();  // Muestra detalles del gerente con bono
emp3.MostrarDetalles();  // Muestra detalles de empleado, no de practicante

// Ocultamiento explícito usando referencia a Practicante
((Practicante)emp3).MostrarDetalles();  // Muestra detalles del practicante
