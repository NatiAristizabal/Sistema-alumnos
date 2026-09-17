using Sistema_alumnos;

Alumno alumno1 = new Alumno("Carlos", 1001);

if (!alumno1.CargarNotas(7.5, 8.0))
{
    Console.WriteLine($"Error: Las notas ingresadas para {alumno1.Nombre} son inválidas.");
}

Alumno alumno2 = new Alumno("Lucía", 1002);

if (!alumno2.CargarNotas(47.0, 5.0))
{
    Console.WriteLine($"Error: Las notas ingresadas para {alumno2.Nombre} son inválidas.");
}

Alumno alumno = new Alumno("Carlos", 1001);
alumno.Nota1 = 47;

Console.WriteLine(alumno1);
Console.WriteLine(alumno2);