namespace Sistema_alumnos;

public class Alumno
{
    public string Nombre { get; set; }

    public int Legajo { get; private set; }
    public double Nota1 { get; private set; }
    public double Nota2 { get; private set; }

    public Alumno(string nombre, int legajo)
    {
        Nombre = nombre;
        Legajo = legajo;
    }

    public bool CargarNotas(double nota1, double nota2)
    {
        if (nota1 >= 0.0 && nota1 <= 10.0 && nota2 >= 0.0 && nota2 <= 10.0)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            return true;
        }

        return false; 
    }

    public double CalcularPromedio()
    {
        return (Nota1 + Nota2) / 2.0;
    }

    public string ObtenerCondicion()
    {
        double promedio = CalcularPromedio();
        return promedio >= 6.0 ? "Aprobado" : "Desaprobado";
    }

    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {CalcularPromedio()})";
    }
}
