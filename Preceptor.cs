namespace SistemaAlumnos
{
    public class Preceptor : Persona
    {
        public string Turno { get; set; }

        public Preceptor(string nombre, string turno) : base(nombre)
        {
            Turno = turno;
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre}, preceptor del turno {Turno}.";
        }
    }
}
