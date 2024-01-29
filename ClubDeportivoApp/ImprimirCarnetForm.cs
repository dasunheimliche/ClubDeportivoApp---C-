using ClubDeportivoApp.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class ImprimirCarnetForm : Form
    {
        public ImprimirCarnetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Registro dato = new Datos.Registro();

            tablaLogin = dato.BuscarSocio(textDni.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                Carnet carnet = new Carnet();
                carnet.nombre = Convert.ToString(tablaLogin.Rows[0][1]);
                carnet.apellido = Convert.ToString(tablaLogin.Rows[0][2]);
                carnet.dni = Convert.ToString(tablaLogin.Rows[0][3]);
                carnet.codigo = Convert.ToString(tablaLogin.Rows[0][0]);

                if (Convert.ToString(tablaLogin.Rows[0][4]) == "1")
                {
                    carnet.ShowDialog();
                }
                else
                {
                    MessageBox.Show("USUARIO NO HABILITADO: DEBE ENTREGAR CERTIFICADO DE APTITUD FISICA");
                }

            }
            else
            {
                MessageBox.Show("EL SOCIO NO EXISTE");
            }
        }
    }
}
