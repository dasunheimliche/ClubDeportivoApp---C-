using ClubDeportivoApp.Datos;
using ClubDeportivoApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class PagarActForm : Form
    {
        public PagarActForm()
        {
            InitializeComponent();
        }

        private void pagarActButton_Click(object sender, EventArgs e)
        {
            DataTable tablaSocio = new DataTable();
            Datos.Registro dato = new Datos.Registro();

            tablaSocio = dato.BuscarNoSocio(textDni.Text);

            E_Pago pago = new E_Pago();
            Caja caja = new Caja();


            if (tablaSocio.Rows.Count > 0)
            {
                pago.socio = Convert.ToInt16(tablaSocio.Rows[0][0]);
                pago.fecha = DateTime.Today;
                pago.monto = Convert.ToInt16(textMonto.Text);
                pago.tipo = "Actividad";
                if (efectivoButton.Checked)
                {
                    pago.modalidad = "Efectivo";
                    caja.GuardarPago(pago);
                    this.Hide();
                }
                else if (tarjetaButton.Checked)
                {
                    pago.modalidad = "Tarjeta";
                    caja.GuardarPago(pago);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DEBES ELEGIR UNA FORMA DE PAGO");
                }
            }
            else
            {
                MessageBox.Show("EL USUARIO NO EXISTE");
            }
        }
    }
}
