public class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }
    public virtual string Presentarse()
    {
        return $"Hola, soy {Nombre}.";
    }
}


