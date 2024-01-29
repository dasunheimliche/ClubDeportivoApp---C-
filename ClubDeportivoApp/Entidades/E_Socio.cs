using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubDeportivoApp.Entidades
{
    internal class E_Socio
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public bool habilitado { get; set; }
        public DateTime vencimiento { get; set; } 

    }
}
