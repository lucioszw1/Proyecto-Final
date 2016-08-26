using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulador
{
    class Partido
    {
        public EquipoPartido Local { get; set; }
        public EquipoPartido Visitante { get; set; }
        public int Minuto { get; set; }
        public Estado EstadoActual { get; set; }
    }
}
