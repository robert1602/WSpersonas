using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarPersonas.Persona persona = new ConsultarPersonas.Persona();
            //vamos a agregar una referencia de nuestro WS en nuestro cliente
            //vamos a instanciar una clase y atraves de la clase vamos a utilizar los metodos de web services
            ConsultarPersonas.WSpersonasClient client = new ConsultarPersonas.WSpersonasClient();
            persona = client.ObtenerPersona(txtIdentificacion.Text);
            if (persona.Resultado.Mensaje != null )
            {
                MessageBox.Show("No existe el usuario");
            }
            else
            {

                MessageBox.Show("Hola soy " +persona.nombre , "y tengo "+persona.edad);
            }
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            //esto es el texto que el usuario a agragado en la identificacion
            // var identificacion = txtIdentificacion.Text;          
        }
    }
}
