using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwikEMart
{
    public partial class FormProducto : Form
    {
        string codigoDeBarras, nombre;
        double precio;
        int cantidad;
        bool editar = false;
        Producto editable;
        
        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(Producto p):this()
        {
            editable = p;
            txtCodigo.Text = p.CodigoDeBarras;
            txtCodigo.Enabled = false;
            txtNombre.Text = p.Nombre;
            txtNombre.Enabled = false;
            txtPrecio.Text = p.Precio.ToString();
            txtPrecio.Enabled = false;
            numCantidad.Value = p.Cantidad;
        }

        public string CodigoDeBarras { get => codigoDeBarras; set => codigoDeBarras = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool attempt = true;
                try
                {
                    lblPrecio.ForeColor = Color.Black;
                    Precio = double.Parse(txtPrecio.Text);
                    
                }
                catch (Exception)
                {
                    lblPrecio.ForeColor = Color.Red;
                    attempt = false;
                }

                lblNombre.ForeColor = Color.Black;
                if (txtNombre.Text.Trim() == "")
                {
                    lblNombre.ForeColor = Color.Red;
                    attempt = false;
                }
                else
                {
                    Nombre = txtNombre.Text;
                }

                lblCodigo.ForeColor = Color.Black;
                if (txtCodigo.Text.Trim() == "")
                {
                    lblCodigo.ForeColor = Color.Red;
                    attempt = false;
                }
                else
                {
                    CodigoDeBarras = txtCodigo.Text;
                }
            Cantidad = Convert.ToInt32(numCantidad.Value);
            if (attempt)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}