using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        string contrasena;

        public string Contrasena { get => contrasena; }

        public Empleado(int dni, string nombre, string apellido, string contrasena):base(dni,nombre,apellido)
        {
            this.contrasena = contrasena;
        }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }

        public static List<Empleado> operator +(List<Empleado> listaE, Empleado e) 
        {
            listaE.Add(e);
            return listaE;
        }
    }
}
