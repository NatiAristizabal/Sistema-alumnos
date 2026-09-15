using Sistema_alumnos;

Alumno alumno1 = new Alumno();
alumno1.Nombre = "Carlos";
alumno1.Legajo = 1001;
alumno1.Nota1 = 7.5;
alumno1.Nota2 = 8.0;

Alumno alumno2 = new Alumno();
alumno2.Nombre = "Lucía";
alumno2.Legajo = 1002;
alumno2.Nota1 = 6.0;
alumno2.Nota2 = 9.0;

Console.WriteLine($"Alumno 1: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
Console.WriteLine($"Alumno 2: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

alumno1.Nombre = "Carlos Alberto";

Console.WriteLine("\n--- Modificacion en el alumno1 ---");
Console.WriteLine($"Alumno 1: {alumno1.Nombre}");
Console.WriteLine($"Alumno 2: {alumno2.Nombre}");