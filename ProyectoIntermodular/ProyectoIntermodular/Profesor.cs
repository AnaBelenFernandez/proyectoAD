using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular
{
    public class Profesor
    {
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string ape1 { get; set; }
        public string ape2 { get; set; }
        public string tfno { get; set; }
        public bool baja { get; set; }
        public bool activo { get; set; }
        public string dept_cod { get; set; }
        public int id_sustituye { get; set; }

    }
}
