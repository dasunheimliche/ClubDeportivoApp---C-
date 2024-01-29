using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainInfoLabel.Text = "USUARIO: " + usuario + " " + "(ADMINISTRADOR/A)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegSocioForm registerForm = new RegSocioForm();

            registerForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegNoSocioForm registerForm = new RegNoSocioForm();

            registerForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PagarCuotaForm pagarCuotaForm = new PagarCuotaForm();

            pagarCuotaForm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ImprimirCarnetForm imprimirCarnetForm = new ImprimirCarnetForm(); 
            imprimirCarnetForm.ShowDialog();
        }

        private void morososButton_Click(object sender, EventArgs e)
        {
            DataTable tablaMorosos = new DataTable();
            Datos.Caja dato = new Datos.Caja();

            tablaMorosos = dato.ListarMorosos();

            if (tablaMorosos.Rows.Count > 0)
            {
                ListaMorososForm listaMorososForm = new ListaMorososForm();

                listaMorososForm.morosos = tablaMorosos;

                listaMorososForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("NO HAY SOCIOS MOROSOS A LA FECHA");
            }
    
        }

        private void pagarActButton_Click(object sender, EventArgs e)
        {
            PagarActForm pagarActForm = new PagarActForm();
            pagarActForm.ShowDialog();
        }

        private void habilitarButton_Click(object sender, EventArgs e)
        {
            HabilitarForm habilitarForm = new HabilitarForm();
            habilitarForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable tablaClientes = new DataTable();
            Datos.Registro dato = new Datos.Registro();

            tablaClientes = dato.ListarClientes();

            if (tablaClientes.Rows.Count > 0)
            {
                ListarClientesForm listaClientesForm = new ListarClientesForm();

                listaClientesForm.clientes = tablaClientes;

                listaClientesForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("NO HAY SOCIOS MOROSOS A LA FECHA");
            }
        }
    }
}
