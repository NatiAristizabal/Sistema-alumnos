namespace SistemaAlumnos
{
    public class Alumno : Persona, IExportable
    {
        public int Legajo { get; set; }

        public Alumno(string nombre, int legajo) : base(nombre)
        {
            Legajo = legajo;
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre}, alumno con legajo {Legajo}.";
        }

        public string ExportarLinea()
        {
            return $"ALUMNO;{Legajo};{Nombre};7";
        }
    }
}
