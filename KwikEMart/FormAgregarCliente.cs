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
    public partial class FormAgregarCliente : Form
    {
        string nombre, apellido;
        int dni;

        public FormAgregarCliente()
        {
            InitializeComponent();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool attempt = true;
            try
            {
                lblDni.ForeColor = Color.Black;
                Dni = int.Parse(txtDni.Text);
            }
            catch (Exception)
            {
                lblDni.ForeColor = Color.Red;
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
                Nombre = txtNombre.Text.Trim();
            }
            lblApellido.ForeColor = Color.Black;
            if (txtApellido.Text.Trim() == "")
            {
                lblApellido.ForeColor = Color.Red;
                attempt = false;
            }
            else 
            {
                Apellido = txtApellido.Text.Trim();
            }
            if(attempt)
            { 
                DialogResult = DialogResult.OK;
            }
        }
    }
}
