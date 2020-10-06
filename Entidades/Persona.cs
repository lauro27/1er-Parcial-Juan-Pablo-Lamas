using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        int dni;
        string nombre, apellido;
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona(int dni, string nombre, string apellido)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public override string ToString()
        {
            return this.Apellido + " " + this.Nombre + " - " + this.Dni;
        }
    }
}
