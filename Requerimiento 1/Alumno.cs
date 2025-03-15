using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requerimiento_1
{
    internal class Alumno
    {
        private int numeroDeLista;
        private string nombreA;
        private ArrayList materias=new ArrayList();
        private ArrayList calificaciones=new ArrayList();

        public int NumeroDeLista { get => numeroDeLista; set => numeroDeLista = value; }
        public string NombreA { get => nombreA; set => nombreA = value; }
        public ArrayList Materias { get => materias; set => materias = value; }
        public ArrayList Calificaciones { get => calificaciones; set => calificaciones = value; }

        public void agregarMaterias(string asignatura)
        {
            materias.Add(asignatura);
        }
        public void agregarCalificaciones(int calificacion)
        {
            calificaciones.Add(calificacion);
        }
    }
}
