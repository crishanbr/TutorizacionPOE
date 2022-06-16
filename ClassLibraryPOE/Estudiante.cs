using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPOE
{
    public class Estudiante : Persona
    {
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public Estudiante(int cedula, string nombre, string apellido, string carrera) : base(cedula, nombre, apellido)
        {
            this.carrera = carrera;
        }
    }
}