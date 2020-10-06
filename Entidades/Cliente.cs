﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        
        public Cliente(int dni, string nombre, string apellido):base(dni,nombre,apellido)
        {
        }

        
        
        public static List<Cliente> operator +(List<Cliente> listaC, Cliente c)
        {
            listaC.Add(c);
            return listaC;
        }
    }
}
