using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntermodular
{
    public class Guardia
    {
        public int Id { get ; set; }
        public int ProfesorFalta { get; set; }
        public int? ProfesorGuardia { get; set; }
        public EstadoEnum Estado { get; set; }
        public DateTime Fecha { get; set; }
        public int Horario { get; set; }
        public int DiaSemana { get; set; }
        public int Hora { get; set; }
        public int? Aviso { get; set; }
        public string Grupo { get; set; }
        public string Aula { get; set; }
        public string Observaciones { get; set; }
    }
}
