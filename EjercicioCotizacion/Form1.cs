using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCotizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = $"Cotizació de Auto para {txtNombre.Text}\r\n ";
            //obtener el costo inicial-
            costo = Convert.ToDouble(txtCosto.Text);

            //verificar seguros
            if(rbnBasico.Checked==true)
            {
                costo = costo + 500.0;
                cotizacion += "Llevar seguro básico de Q500.00 \r\n";
            }
            if(rbnTerceros.Checked==true)
            {
                costo += 700.0;
                cotizacion = "Lleva seguro a terceros de Q700.00 \r\n";
            }
            if(rbnTotal.Checked==true)
            {
                costo += 1000.0;
                cotizacion = "Lleva seguro Total de Q1000.00 \r\n";
            }

            //verificar equipo
            if(chkAire.Checked==true)
            {
                costo +=500.0;
                cotizacion += "Con aire acondicionado de Q500.00 \r\n";
            }
            if(chkAudio.Checked==true)
            {
                costo += 700.0;
                cotizacion += "Con Sistema de Audio de Q700.00 \r\n";
            }
            //mostramos el total
            cotizacion += "El total a pagar es de: "+costo.ToString();

            txtCotizacion.Text = cotizacion;
        }
        //estamos realizando una prueba para git
    }
}
