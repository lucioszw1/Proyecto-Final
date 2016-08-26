using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Simulador.Properties;
using System.Data;

namespace Simulador
{   
    class Jugador
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int fuerza { get; set; }
        public string posicion { get; set; }
        public int ID { get; set; }
        public bool amonestado { get; set; }
    }
}
