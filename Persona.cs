namespace Sistema_alumnos;

    public class Persona
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }

        public Persona(string nombre, string documento)
        {
            Nombre = nombre;
            Documento = documento;
        }
    }


