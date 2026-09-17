using Sistema_alumnos;

List<Alumno> listaAlumnos = new List<Alumno>();
bool salir = false;

do
{
    Console.WriteLine("\n=== SISTEMA DE GESTIÓN DE ALUMNOS ===");
    Console.WriteLine("1. Agregar un alumno");
    Console.WriteLine("2. Listar todos los alumnos");
    Console.WriteLine("3. Buscar un alumno por legajo");
    Console.WriteLine("4. Mostrar el promedio general del curso");
    Console.WriteLine("5. Mostrar cuántos alumnos están aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine() ?? "";
    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            AgregarAlumno(listaAlumnos);
            break;
        case "2":
            ListarAlumnos(listaAlumnos);
            break;
        case "3":
            BuscarAlumnoPorLegajo(listaAlumnos);
            break;
        case "4":
            MostrarPromedioGeneral(listaAlumnos);
            break;
        case "5":
            MostrarCantidadAprobados(listaAlumnos);
            break;
        case "6":
            salir = true;
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }

} while (!salir);


// --- MÉTODOS AUXILIARES ---

static void AgregarAlumno(List<Alumno> lista)
{
    Console.Write("Ingrese el nombre del alumno: ");
    string nombre = Console.ReadLine() ?? "";

    Console.Write("Ingrese el documento del alumno: ");
    string documento = Console.ReadLine() ?? "";

    Console.Write("Ingrese el legajo del alumno: ");
    if (!int.TryParse(Console.ReadLine(), out int legajo))
    {
        Console.WriteLine("Error: El legajo debe ser un número entero.");
        return;
    }

    Alumno nuevoAlumno = new Alumno(nombre, documento, legajo);

    Console.Write("Ingrese la Nota 1: ");
    double.TryParse(Console.ReadLine(), out double nota1);

    Console.Write("Ingrese la Nota 2: ");
    double.TryParse(Console.ReadLine(), out double nota2);

    if (nuevoAlumno.CargarNotas(nota1, nota2))
    {
        lista.Add(nuevoAlumno);
        Console.WriteLine("¡Alumno cargado correctamente!");
    }
    else
    {
        Console.WriteLine("Error: Las notas deben estar entre 0 y 10. No se guardó el alumno.");
    }
}

static void ListarAlumnos(List<Alumno> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("No hay alumnos registrados.");
        return;
    }

    Console.WriteLine("--- LISTADO DE ALUMNOS ---");
    foreach (var alumno in lista)
    {
        Console.WriteLine(alumno);
    }
}

static void BuscarAlumnoPorLegajo(List<Alumno> lista)
{
    Console.Write("Ingrese el legajo a buscar: ");
    if (!int.TryParse(Console.ReadLine(), out int legajo))
    {
        Console.WriteLine("Error: Debe ingresar un número de legajo válido.");
        return;
    }

    Alumno alumnoEncontrado = lista.Find(a => a.Legajo == legajo);

    if (alumnoEncontrado != null)
    {
        Console.WriteLine($"Alumno encontrado: {alumnoEncontrado} | Condición: {alumnoEncontrado.ObtenerCondicion()}");
    }
    else
    {
        Console.WriteLine($"No existe ningún alumno con el legajo {legajo}.");
    }
}

static void MostrarPromedioGeneral(List<Alumno> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("Todavía no hay alumnos para calcular el promedio general.");
        return;
    }

    double sumaPromedios = 0;
    foreach (var alumno in lista)
    {
        sumaPromedios += alumno.CalcularPromedio();
    }

    double promedioGeneral = sumaPromedios / lista.Count;
    Console.WriteLine($"Promedio general del curso: {promedioGeneral:F2}");
}

static void MostrarCantidadAprobados(List<Alumno> lista)
{
    int aprobados = 0;
    foreach (var alumno in lista)
    {
        if (alumno.ObtenerCondicion() == "Aprobado")
        {
            aprobados++;
        }
    }

    Console.WriteLine($"Cantidad de alumnos aprobados: {aprobados} de {lista.Count}");
}