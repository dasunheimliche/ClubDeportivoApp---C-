using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class HabilitarForm : Form
    {
        public HabilitarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablaSocio = new DataTable();
            DataTable tablaNoSocio = new DataTable();
            DataTable tablaCliente = new DataTable();

            Datos.Registro dato = new Datos.Registro();

            tablaSocio = dato.BuscarSocio(textDni.Text);
            tablaNoSocio = dato.BuscarNoSocio(textDni.Text);

            tablaCliente = (tablaSocio.Rows.Count > 0)? tablaSocio : tablaNoSocio ;

            if (tablaCliente.Rows.Count > 0)
            {
                dato.HabilitarCliente(textDni.Text);
                this.Hide();
            } else
            {
                MessageBox.Show("EL USUARIO NO EXISTE");
            }
        }
    }
}
