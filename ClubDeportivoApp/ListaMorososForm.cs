using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class ListaMorososForm : Form
    {
        public ListaMorososForm()
        {
            InitializeComponent();
        }

        internal DataTable? morosos;

        private void ListaMorososForm_Load(object sender, EventArgs e)
        {
            morososGridView.DataSource = morosos;

        }
    }
}
