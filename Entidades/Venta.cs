using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        List<Producto> productos;
        Empleado empleado;
        Cliente cliente;
        double total = 0;
        DateTime fecha;

        public Venta(List<Producto> productos, Empleado empleado, Cliente cliente) 
        {
            this.productos = productos;
            this.empleado = empleado;
            this.cliente = cliente;
            foreach (Producto p in productos)
            {
                this.total += (p.Precio * p.Cantidad);
            }
            this.total = Math.Round(this.total, 2);
            this.fecha = DateTime.Now;
        }
        public Venta(List<Producto> productos, Empleado empleado, Cliente cliente, double total):this(productos,empleado,cliente)
        {
            this.total = total;
        }

        private List<Producto> Productos { get => productos; }
        public Empleado Empleado { get => empleado; }
        public Cliente Cliente { get => cliente; }
        public double Total { get => total; }
        public DateTime Fecha { get => fecha; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fecha: " + this.fecha.ToString());
            sb.AppendLine("Cliente: " + Cliente.Apellido + ", " + Cliente.Nombre + " - DNI: " + Cliente.Dni.ToString());
            sb.AppendLine("Empleado: " + Empleado.ToString());
            sb.AppendLine("Productos:");
            foreach (Producto p in Productos)
            {
                sb.AppendLine(" + " + p.ToString());
            }
            if(Cliente.Apellido.ToLower() == "simpson")
            {
                sb.AppendLine("*Descuento Simpson! -13%*");
            }
            sb.AppendLine("Total: $" + (total * 0.87).ToString());
            sb.AppendLine("\nGracias!! Vuelva prontosss");
            return sb.ToString();
        }
    }
}
