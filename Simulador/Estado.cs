using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulador
{
    class Estado
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public List<Tarjeta> AmarillasLocal { get; set; }
        public List<Tarjeta> AmarillasVisitante { get; set; }
        public List<Tarjeta> RojasLocal { get; set; }
        public List<Tarjeta> RojasVisitante { get; set; }
        public List<Gol> GolesLocal { get; set; }
        public List<Gol> GolesVisitante { get; set; }
        public bool Entretiempo { get; set; }
        public bool Terminado { get; set; }
        public bool ConvirtioLocal { get; set; }
        public bool ConvirtioVisitante { get; set; }

        public static void CalcularFuerza(ref int num1, ref int num2, Random rand, int fuerzalocal, int fuerzavisitante)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    num1 = rand.Next(0, fuerzalocal);
                }
                if (i == 1)
                {
                    num2 = rand.Next(0, fuerzavisitante);
                }
            }
        }
    }
}
