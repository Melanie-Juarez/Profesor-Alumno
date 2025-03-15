using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requerimiento_1
{
    internal class Profesor
    {
        private string nombreP;
        private Alumno alumno=new Alumno();

        public string NombreP { get => nombreP; set => nombreP = value; }
        internal Alumno Alumno { get => alumno; set => alumno = value; }

        public void capturarDatosAlumno()
        {
            Profesor cap=new Profesor();
            int numL;

            Console.WriteLine("Nombre del alumno: ");
            this.alumno.NombreA = Console.ReadLine();
            Console.WriteLine("Numero de Lista: ");
            this.Alumno.NumeroDeLista=Convert.ToInt32(Console.ReadLine());
        }
        public void capturarMaterias()
        {
            string asig;

          for (int i = 0; i < 7; i++) { 
                Console.WriteLine("Ingrese las materias: ");
                asig = Console.ReadLine();
                alumno.agregarMaterias(asig);
          }
        }


        public void capturarCalificaciones()
        {
            int cal;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingrese calificacion de: " + alumno.Materias[i]);
                cal = Convert.ToInt32(Console.ReadLine());
                alumno.agregarCalificaciones(cal);
            } 
        }
    }
}
