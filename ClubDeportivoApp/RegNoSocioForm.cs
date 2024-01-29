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
    public partial class RegNoSocioForm : Form
    {
        public RegNoSocioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "" || textApellido.Text == "" || textDni.Text == "")
            {
                MessageBox.Show("Debe completar los datos requeridos ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;

                MessageBox.Show("CREANDO OBJETO CLIENTE");

                E_NoSocio cliente = new E_NoSocio();
                cliente.nombre = textNombre.Text;
                cliente.apellido = textApellido.Text;
                cliente.dni = textDni.Text;
                cliente.habilitado = checkHabilitado.Checked;

                Datos.Registro registro = new Datos.Registro();

                respuesta = registro.RegistrarNoSocio(cliente);

                MessageBox.Show("REGISTRO COMPLETADO: " + respuesta);

                bool esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("NoSocio YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almacenó con éxito con el código Nº " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }

                textNombre.Text = "";
                textApellido.Text = "";
                textDni.Text = "";
                checkHabilitado.Checked = false;
            }
        }
    }
}
