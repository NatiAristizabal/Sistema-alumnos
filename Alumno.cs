namespace Sistema_alumnos;

public class Alumno
{
    public string Nombre { get; set; }
    public int Legajo { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Alumno(string nombre, int legajo)
    {
        Nombre = nombre;
        Legajo = legajo;
    }

    public double CalcularPromedio()
    {
        return (Nota1 + Nota2) / 2.0;
    }

    // Sobrescribimos el método ToString original de la clase object
    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {CalcularPromedio()})";
    }
}

// NOTA ETAPA 4:
// Si se elimina la palabra reservada 'override', el compilador emite la advertencia,
// "'Alumno.ToString()' hides inherited member 'object.ToString()'. Use the new keyword if hiding was intended."
// Esto ocurre porque 'ToString()' ya existe en la clase base 'Object'. Sin 'override',
// C# no sabe si la intención es reemplazar el método base o declarar uno completamente independiente.
