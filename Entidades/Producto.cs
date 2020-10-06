using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string nombre;
        double precio;
        int cantidad;
        string codigoDeBarras;

        public string CodigoDeBarras { get => codigoDeBarras; }
        public string Nombre { get => nombre; }
        public double Precio { get => precio; }
        public int Cantidad {
            get => cantidad;
            set
            {
                if (value <= 0)
                {
                    cantidad = 0;
                }
                else 
                {
                    cantidad = value;
                }
            } 
        }

        public Producto(string codigoDeBarras, string nombre, double precio, int cantidad)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public Producto(Producto p)
        {
            this.codigoDeBarras = p.CodigoDeBarras;
            this.nombre = p.Nombre;
            this.precio = p.Precio;
            this.cantidad = p.Cantidad;
        }

        public Producto(Producto p, int cantidad):this(p)
        {
            this.cantidad = cantidad;
        }

        public static List<Producto> operator +(List<Producto> listaP, Producto p)
        {
            listaP.Add(p);
            return listaP;
        }
        public static Producto operator + (Producto p, int agregar)
        {
            p.Cantidad = p.Cantidad + agregar;
            return p;
        }
        public override string ToString()
        {
            return this.codigoDeBarras + "-" + this.Nombre + " - $" + this.precio;
        }

        public static int comparaCodigos(List<Producto> lista, Producto p)
        {
            int index = 0;
            foreach (Producto producto in lista)
            {
                if(producto.codigoDeBarras == p.codigoDeBarras)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
