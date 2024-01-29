using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivoApp
{
    public partial class Carnet : Form
    {
        public Carnet()
        {
            InitializeComponent();
        }

        internal string? nombre;
        internal string? apellido;
        internal string? dni;
        internal string? codigo;

        private void Carnet_Load(object sender, EventArgs e)
        {
            nom.Text = nombre;
            ape.Text = apellido;
            doc.Text = dni;
            cod.Text = codigo;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printButton.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintCarnet);
            pd.Print();

            printButton.Visible = true;

            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void PrintCarnet(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
