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
            //Revisión DNI
            lblDni.ForeColor = Color.Black;
            int Dni = Persona.validacionNum(txtDni.Text);
            if (Dni <= 0)
            {
                attempt = false;
                lblDni.ForeColor = Color.Red;
            }
            //Revision nombre
            lblNombre.ForeColor = Color.Black;
            if (!Persona.validacionString(txtNombre.Text))
            {
                lblNombre.ForeColor = Color.Red;
                attempt = false;
            }
            else 
            {
                Nombre = txtNombre.Text.Trim();
            }
            //Revision apellido
            lblApellido.ForeColor = Color.Black;
            if (!Persona.validacionString(txtApellido.Text))
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
