using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp.Datos
{
    internal class Caja
    {
        public int PrecioCuota { get; private set; }

        public Caja()
        {
            PrecioCuota = 1500;
        }

        public void PagarCuota(string dni)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("PagarCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("doc", MySqlDbType.VarChar).Value = dni;
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("PAGO EXITOSO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GuardarPago(E_Pago pago)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("InsertarPago", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("socio", MySqlDbType.VarChar).Value = pago.socio;
                comando.Parameters.Add("ven", MySqlDbType.DateTime).Value = pago.vencimiento;
                comando.Parameters.Add("proxVen", MySqlDbType.DateTime).Value = pago.proxVencimiento;
                comando.Parameters.Add("fechaPago", MySqlDbType.DateTime).Value = pago.fecha;
                comando.Parameters.Add("mon", MySqlDbType.VarChar).Value = pago.monto;
                comando.Parameters.Add("modal", MySqlDbType.VarChar).Value = pago.modalidad;
                comando.Parameters.Add("type", MySqlDbType.VarChar).Value = pago.tipo;


                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("PAGO GUARDADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ListarMorosos()
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("ListarSociosVencidos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

        }
    }
}
