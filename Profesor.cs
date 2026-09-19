namespace SistemaAlumnos
{
    public class Profesor : Persona, IExportable
    {
        public string Materia { get; set; }

        public Profesor(string nombre, string materia) : base(nombre)
        {
            Materia = materia;
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre} y dicto {Materia}.";
        }

        public string ExportarLinea()
        {
            return $"PROFESOR;{Nombre};{Materia}";
        }
    }
}
