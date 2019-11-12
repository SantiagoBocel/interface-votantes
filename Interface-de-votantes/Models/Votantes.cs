using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_de_votantes.Models
{
    public class Votantes
    {
        public int id { get; set; }
        public int depto { get; set; }
        public string dpi { get; set; }
        public int boleta_presidente { get; set; }
        public int boleta_diputado_nacional { get; set; }
        public int boleta_diputados_distrito { get; set; }
        public int boleta_alcalde { get; set; }
        public string fecha_hora { get; set; }
    }
}
