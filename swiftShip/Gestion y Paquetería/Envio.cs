using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_y_Paquetería
{
        public class Envio
        {
            public string CodigoSeguimiento { get; set; }
            public string Destinatario { get; set; }
            public string Direccion { get; set; }
            public double Peso { get; set; }
            public string Zona { get; set; }
            public string Estado { get; set; }
            public DateTime FechaRegistro { get; set; }
        }
}
