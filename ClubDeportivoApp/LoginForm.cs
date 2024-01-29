using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivoApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}



        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Admins dato = new Datos.Admins();

            tablaLogin = dato.Log_Admin(textUsuario.Text, textPass.Text);

            if(tablaLogin.Rows.Count > 0)
            {
                MainForm FormPrincipal = new MainForm();

                FormPrincipal.usuario = Convert.ToString(textUsuario.Text);

                FormPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
}
