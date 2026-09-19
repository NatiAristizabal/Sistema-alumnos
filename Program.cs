using System;
using System.Collections.Generic;


namespace SistemaAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Materia> materiasCatedra = new List<Materia>
            {
                new Materia("PROG1", "Programación I", 128),
                new Materia("BD1", "Bases de Datos I", 96)
            };

            List<IExportable> exportables = new List<IExportable>
            {
                new Alumno("Ana Pérez", 1234),
                new Profesor("Marta Díaz", "Programación"),
                materiasCatedra[0] 
            };

            Console.WriteLine("--- EXPORTACIÓN A TEXTO ---");
            foreach (IExportable item in exportables)
            {
                Console.WriteLine(item.ExportarLinea());
            }

            Console.ReadKey();
        }
    }
}

/*
 
 Al agregar 'string ExportarEncabezado();' a IExportable sin implementarlo en las clases,
 aparecen 3 ERRORES de compilación (uno por cada clase que implementa la interfaz):

 1. Error CS0535: 'Alumno' no implementa el miembro de interfaz 'IExportable.ExportarEncabezado()'.
 2. Error CS0535: 'Profesor' no implementa el miembro de interfaz 'IExportable.ExportarEncabezado()'.
 3. Error CS0535: 'Materia' no implementa el miembro de interfaz 'IExportable.ExportarEncabezado()'.

 Esto ocurre porque las interfaces son CONTRATOS OBLIGATORIOS: si una clase dice que implementa 
 una interfaz, está obligada a darles cuerpo a TODOS los métodos declarados en ella.
*/