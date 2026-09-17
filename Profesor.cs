namespace Sistema_alumnos;

public class Profesor : Persona
{
    public string Materia { get; set; }

    public Profesor(string nombre, string documento, string materia)
        : base(nombre, documento)
    {
        Materia = materia;
    }

    public override string ToString()
    {
        return $"Prof. {Nombre} (DNI: {Documento}) - Materia: {Materia}";
    }
}
