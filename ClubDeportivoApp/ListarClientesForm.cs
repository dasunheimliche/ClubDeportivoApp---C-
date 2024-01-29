using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class ListarClientesForm : Form
    {
        public ListarClientesForm()
        {
            InitializeComponent();
        }

        internal DataTable? clientes;

        private void ListarClientesForm_Load(object sender, EventArgs e)
        {
            clientesGridView.DataSource = clientes;
        }
    }
}
