using System.Runtime.CompilerServices;

namespace Requerimiento_1;

class Principal
{
    static void Main(String[] args)
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>();

        Profesor profe = new Profesor();

        Console.WriteLine("\n" + "Binvenido... Ingresa tu nombre: ");
        profe.NombreP = Console.ReadLine();
        profe.capturarDatosAlumno();
        profe.capturarMaterias();
        profe.capturarCalificaciones();


        Console.WriteLine("..... DATOS PROFESOR ..... ");
        Console.WriteLine("Nombre del profesor: " + profe.NombreP + "\n");

        Console.WriteLine("..... DATOS ALUMNO .....");
        Console.WriteLine("Nombre del Alumno: " + profe.Alumno.NombreA + "\n");
        Console.WriteLine("Numero de Lista: " + profe.Alumno.NumeroDeLista + "\n");

        Console.WriteLine("..... MATERIAS .....");

        for (int i = 0; i < profe.Alumno.Materias.Count; i++)
        {
            diccionario.Add(profe.Alumno.Materias[i].ToString(), profe.Alumno.Calificaciones[i].ToString());

        }

        foreach(var i in diccionario)
        {
            Console.WriteLine( i.Key + " , " + i.Value );
        }



    }
}

