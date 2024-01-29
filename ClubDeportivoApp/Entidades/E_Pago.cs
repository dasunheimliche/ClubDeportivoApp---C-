using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivoApp.Entidades
{
    internal class E_Pago
    {
        public int socio { get; set; }
        public DateTime vencimiento { get; set; }
        public DateTime proxVencimiento { get; set; }
        public DateTime fecha { get; set; }
        public int monto { get; set; }
        public string modalidad { get; set; }
        public string tipo { get; set; }

    }
}
