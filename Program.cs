using Sistema_alumnos;

Alumno alumno1 = new Alumno("Carlos", 1001);
alumno1.Nota1 = 7.5;
alumno1.Nota2 = 8.0;

Alumno alumno2 = new Alumno("Lucía", 1002);
alumno2.Nota1 = 4.0;
alumno2.Nota2 = 5.0;

Console.WriteLine($"Alumno: {alumno1.Nombre} | Legajo: {alumno1.Legajo}");
Console.WriteLine($"Promedio: {alumno1.CalcularPromedio()} | Condición: {alumno1.ObtenerCondicion()}");
Console.WriteLine("----------------------------------------");

Console.WriteLine($"Alumno: {alumno2.Nombre} | Legajo: {alumno2.Legajo}");
Console.WriteLine($"Promedio: {alumno2.CalcularPromedio()} | Condición: {alumno2.ObtenerCondicion()}");