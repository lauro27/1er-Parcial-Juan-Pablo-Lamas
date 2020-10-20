using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class FormPrincipal : Form
    {
        List<Venta> ventas = new List<Venta>();
        List<Cliente> clientes = new List<Cliente>();
        List<Producto> productos = new List<Producto>();
        List<Empleado> empleados = new List<Empleado>();
        List<Venta> debugVentas = new List<Venta>();
        List<Cliente> debugClientes = new List<Cliente>();
        List<Producto> debugProductos = new List<Producto>();
        List<Empleado> debugEmpleados = new List<Empleado>();
        BindingList<Producto> caja = new BindingList<Producto>();
        double precioTotal = 0;
        public FormPrincipal()
        {
            debugProductos += (Producto)"LI0094,Cif Lavandina en gel,50,55";
            debugProductos += (Producto)"LA0063,Leche Ilolay,20,44";
            debugProductos += (Producto)"HI0041,Papel Higienico,30.25,5";
            debugProductos += (Producto)"LA0089,Manteca La Paulina, 20.50, 76";
            debugProductos += (Producto)"HO0097,Juego de Toallas, 300.46, 11";
            debugProductos += (Producto)"TE0077,Secador de pelo Philips, 1999.99, 3";
            debugProductos += (Producto)"CO0053,Gaseosa 1.5L Pepsi, 90.15, 30";
            debugProductos += (Producto)"AL0071,Papas Lays 150g, 100, 30";
            debugProductos += (Producto)"AL0069,Fideos Matarazo Spagetti, 45, 89";
            debugProductos += (Producto)"AL0057,Galletitas rellenas OREO, 73, 59";
            debugProductos += (Producto)"AL0052,Salsa lista Knorr, 23, 29";
            debugProductos += (Producto)"AL0043,Pure de papa Maggi, 73, 42";
            debugProductos += (Producto)"CO0046,Sopa instantanea Maruchan, 41, 12";
            debugProductos += (Producto)"AL0048,Choclo enlatado Arcor, 72, 15";
            debugProductos += (Producto)"AL0040,Jugo de Naranja Cepita, 48, 22";
            debugProductos += (Producto)"HI0008,Toallitas diurnas Kotex, 25, 33";
            debugProductos += (Producto)"HI0006,Rexona Antitranspirante, 32, 61";
            debugProductos += (Producto)"LI0004,Jabon liquido Magistral, 42.64, 4";
            debugProductos += (Producto)"AL0028,Agua mineral 2L Villa del Sur, 110, 20";
            debugProductos += (Producto)"CO0017,Pechuga de Pollo, 99, 6";
            debugProductos += (Producto)"CO0015,Empanada de Carne, 37, 122";
            debugProductos += (Producto)"HI0014,Curitas pack 12u, 105, 15";
            debugProductos += (Producto)"ES0013,Lapicera Bic 6u, 40, 99";
            debugProductos += (Producto)"AL0003,Galletas saladas x3, 150, 24";
            debugProductos += (Producto)"AL0009,Nachos 200g, 5, 6";
            debugProductos += (Producto)"AL0010,Caldo en cubos Knor, 5, 6";
            debugProductos += (Producto)"AL0011,Arroz Gallo ORO, 5, 6";
            debugProductos += (Producto)"LI0021,Limpia pisos Poett, 5, 6";
            debugProductos += (Producto)"LI0022,Lavandina Ayudin, 5, 6";
            debugProductos += (Producto)"AL0030,Salchichas Vienisima pack 12u, 5, 6";
            debugProductos += (Producto)"HI0025,Jabon para baño Lux, 5, 6";

            debugEmpleados += new Empleado(11111111, "Apu", "Nahasapeemapetilon", "Paul Mc Cartney");
            debugEmpleados += new Empleado(22222222, "James", "Woods", "tu eres tu y yo soy yo");
            
            debugClientes += new Cliente(11111121, "Bart", "Simpson");
            debugClientes += new Cliente(45819528, "Roy", "Snyder");
            debugClientes += new Cliente(11111121, "Artie", "Ziff");
            debugClientes += new Cliente(11111121, "Waylon", "Smithers");


            Random rand = new Random();
            int debugIndex= 0;
            while(debugIndex <= 50)
            {
                List<Producto> ventaAleatoria = new List<Producto>();
                int randomVentas = rand.Next(1, 3), ventasIndex = 0;
                while (ventasIndex<= randomVentas) 
                {
                    ventaAleatoria.Add(debugProductos[rand.Next(30)]);
                    ventasIndex++;
                }
                debugVentas.Add(new Venta(ventaAleatoria, debugEmpleados[rand.Next(0,2)],debugClientes[rand.Next(0,3)]));
                debugIndex++;
            }
            InitializeComponent();
        }

        private void ActualizarTodo()
        {
            //renovar comboboxes y caja
            cboxCliente.Refresh();
            cboxEmpleado.Refresh();
            cboxNuevoProducto.Refresh();
            dataCaja.Refresh();

            cboxCliente.Update();
            cboxEmpleado.Update();
            cboxNuevoProducto.Update();
            dataCaja.Update();

            //nuevo total
            precioTotal = 0;
            foreach (Producto producto in caja)
            {
                precioTotal += producto.Precio * producto.Cantidad;
            }
            if (clientes.Count > 0 & cboxCliente.SelectedIndex != -1)
            {
                if (clientes[cboxCliente.SelectedIndex].Apellido.ToLower() == "simpson")
                {
                    lblTotal.Text = "Total: $" + Math.Round(precioTotal * 0.87, 2).ToString() + " - Descuento Simpson!";
                }
                else
                {
                    lblTotal.Text = "Total: $" + Math.Round(precioTotal, 2).ToString();
                }
            }
            else
            {
                lblTotal.Text = "Total: $" + Math.Round(precioTotal, 2).ToString();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            dataCaja.DataSource = caja;
            foreach (Producto p in productos)
            {
                cboxNuevoProducto.Items.Add(p.ToString());
            }

            foreach (Empleado empleado in empleados)
            {
                cboxEmpleado.Items.Add(empleado.ToString());
            }

            foreach (Cliente cliente in clientes)
            {
                cboxCliente.Items.Add(cliente.ToString());
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //si hay un producto seleccionado y por ende algo que agregar
            if (cboxNuevoProducto.SelectedIndex != -1)
            {
                Producto agregado = new Producto(productos[cboxNuevoProducto.SelectedIndex]);
                //si el producto a agregar ya existe en la caja 
                if (Producto.comparaCodigos(caja.ToList(), productos[cboxNuevoProducto.SelectedIndex]) != -1 & productos[cboxNuevoProducto.SelectedIndex].Cantidad > 0)
                {
                    Producto productoDeCaja = caja[Producto.comparaCodigos(caja.ToList(), productos[cboxNuevoProducto.SelectedIndex])];

                    //entonces fijarse si agregarle los extras supera el stock
                    int aSumar = Convert.ToInt32(Math.Round(numCantidadProducto.Value, 0));
                    if (agregado.Cantidad < productoDeCaja.Cantidad + aSumar)
                    {
                        MessageBox.Show("ERROR: Ingreso supera el inventario");
                    }
                    else
                    {
                        caja[Producto.comparaCodigos(caja.ToList(), productos[cboxNuevoProducto.SelectedIndex])].Cantidad += Convert.ToInt32(Math.Round(numCantidadProducto.Value, 0));
                    }
                }
                else
                {
                    if (productos[cboxNuevoProducto.SelectedIndex].Cantidad > 0)
                    {
                        agregado.Cantidad = Convert.ToInt32(Math.Round(numCantidadProducto.Value, 0));
                        caja.Add(agregado);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Ingreso supera el inventario");
                    }
                }
                ActualizarTodo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            caja.Clear();
            precioTotal = 0;
            ActualizarTodo();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataCaja.CurrentRow != null & dataCaja.SelectedCells != null)
            {
                caja.RemoveAt(dataCaja.CurrentRow.Index);
                ActualizarTodo();
            }
        }


        #region MUESTRAS DE LISTAS
        private void MenuItemInventario_Click(object sender, EventArgs e)
        {
            FormLista frmProductos = new FormLista(productos);
            frmProductos.ShowDialog();
        }
        private void MenuItemInventarioUrgente_Click(object sender, EventArgs e)
        {
            FormLista frmUrgentes = new FormLista(Producto.listarUrgentes(productos));
            frmUrgentes.ShowDialog();
        }
        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLista frmClientes = new FormLista(clientes);
            frmClientes.ShowDialog();
        }
        private void listadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLista frmVentas = new FormLista(ventas);
            frmVentas.ShowDialog();
        }

        #endregion

        private void generarDatosMockupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos = debugProductos;
            clientes = debugClientes;
            empleados = debugEmpleados;
            ventas = debugVentas;
            foreach (Producto p in productos)
            {
                cboxNuevoProducto.Items.Add(p);
            }

            foreach (Empleado empleado in empleados)
            {
                cboxEmpleado.Items.Add(empleado);
            }

            foreach (Cliente cliente in clientes)
            {
                cboxCliente.Items.Add(cliente);
            }
            ActualizarTodo();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCliente frmAgregar = new FormAgregarCliente();
            frmAgregar.ShowDialog();
            if (frmAgregar.DialogResult == DialogResult.OK)
            {
                string cliente = frmAgregar.Dni.ToString() + ',' + frmAgregar.Nombre + ',' + frmAgregar.Apellido;
                Cliente c = cliente;
                clientes.Add(c);
                cboxCliente.Items.Add(c);
                cboxCliente.SelectedIndex = 0;
            }
            ActualizarTodo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (caja.Count > 0 & cboxEmpleado.SelectedIndex != -1)
            {
                Venta venta;
                foreach (Producto p in caja)
                {
                    int index = Producto.comparaCodigos(productos, p);

                    productos[index].Cantidad -= p.Cantidad;
                    //////////////////////////////////////////////
                }
                if (cboxCliente.SelectedIndex != -1)
                {
                    venta = new Venta(caja.ToList(), empleados[cboxEmpleado.SelectedIndex], clientes[cboxCliente.SelectedIndex], precioTotal);
                }
                else
                {
                    venta = new Venta(caja.ToList(), empleados[cboxEmpleado.SelectedIndex], new Cliente(0, "N/A", "N/A"), precioTotal);
                }
                MessageBox.Show(venta.ToString());
                ventas.Add(venta);
                caja.Clear();
            }
        }

        private void MenuItemAgregarProducto_Click(object sender, EventArgs e)
        {
            FormProducto frmProducto = new FormProducto();
            frmProducto.ShowDialog();
            if (frmProducto.DialogResult == DialogResult.OK)
            {
                Producto p = new Producto(frmProducto.CodigoDeBarras, frmProducto.Nombre, frmProducto.Precio, frmProducto.Cantidad);
                productos.Add(p);
                cboxNuevoProducto.Items.Add(p);
                cboxNuevoProducto.SelectedIndex = 0;
            }
            ActualizarTodo();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (cboxNuevoProducto.SelectedItem != null)
            {

                FormProducto frmProducto = new FormProducto(productos[cboxNuevoProducto.SelectedIndex]);
                frmProducto.ShowDialog();
                if (frmProducto.DialogResult == DialogResult.OK)
                {
                    Producto p = new Producto(frmProducto.CodigoDeBarras, frmProducto.Nombre, frmProducto.Precio, frmProducto.Cantidad);
                    productos[cboxNuevoProducto.SelectedIndex] = p;
                    cboxNuevoProducto.SelectedIndex = 0;
                }
            }
            ActualizarTodo();
        }

        private void cboxCliente_ContextMenuStripChanged(object sender, EventArgs e)
        {
            ActualizarTodo();
        }
    }
}
