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

     public string ObtenerCondicion()
    {
        double promedio = CalcularPromedio();
        if (promedio >= 6.0)
        {
            return "Aprobado";
        }
        else
        {
            return "Desaprobado";
        }
    }
}
