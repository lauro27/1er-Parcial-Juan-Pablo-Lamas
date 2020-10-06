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
    public partial class FormLista : Form
    {
        List<Producto> productos;
        List<Venta> ventas;
        List<Cliente> clientes;
        public FormLista()
        {
            InitializeComponent();
        }

        public FormLista(List<Producto> lista)
        {
            this.productos = lista;
            InitializeComponent();
        }

        public FormLista(List<Venta> lista)
        {
            this.ventas = lista;
            InitializeComponent();
        }
        public FormLista(List<Cliente> lista)
        {
            this.clientes = lista;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            if (ventas != null)
            {
                dataLista.DataSource = ventas;
                this.Text += " ventas";
            }
            else if (productos != null)
            {
                dataLista.DataSource = productos;
                this.Text += " productos";
            }
            else if(clientes != null)
            {
                dataLista.DataSource = clientes;
                this.Text += " clientes";
            }
        }

        private void dataLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataLista.CurrentRow.DataBoundItem.ToString());
        }
    }
}
