using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulador
{
    class Gol
    {
        public Jugador jugador { get; set; }
        public int minuto { get; set; }
        public static void CalcularGoles(int num1, int num2, Random rand, ref int gol1, ref int gol2)
        {
            //recibir partido y modificar variables (num y probabilidad) segun el estado
            int minimorand = 50;
            int maximorand = 70;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    gol1 += num1 / rand.Next(minimorand, maximorand);
                }
                if (i == 1)
                {
                    gol2 += num2 / rand.Next(minimorand, maximorand);
                }
            }
        }
        public static void AsignarGol(Random ran, int PosRandom, ref string goleador, EquipoPartido equipo)
        {
                List<Jugador> jug = new List<Jugador>();
                jug.Clear();
                PosRandom = ran.Next(0, 100);
                if (PosRandom <= 1)
                {
                    foreach (Jugador juga in equipo.Titulares)
                    {
                        if (juga.posicion == "Arquero")
                        {
                            jug.Add(juga);
                        }
                    }

                }

                if (PosRandom >= 2 && PosRandom <= 15)
                {
                    foreach (Jugador juga in equipo.Titulares)
                    {
                        if (juga.posicion == "Defensor")
                        {
                            jug.Add(juga);
                        }
                    }
                }

                if (PosRandom >= 16 && PosRandom <= 45)
                {
                    foreach (Jugador juga in equipo.Titulares)
                    {
                        if (juga.posicion == "Mediocampista")
                        {
                            jug.Add(juga);
                        }
                    }
                }


                if (PosRandom >= 46 && PosRandom <= 100)
                {
                    foreach (Jugador juga in equipo.Titulares)
                    {
                        if (juga.posicion == "Delantero")
                        {
                            jug.Add(juga);
                        }
                    }

                }
                PosRandom = ran.Next(0, jug.Count());
                goleador = jug[PosRandom].nombre + " " + jug[PosRandom].apellido;                  
        }
        public static void AsignarMinuto(int periodo, ref int minutogol)
        {
            int minutomin = 0;
            int minutomax = 15;
            Random rand = new Random();
            for (int i = 1; i < 7; i++)
            {
                if (i != periodo)
                {
                    minutomin += 15;
                    minutomax += 15;
                }
                else
                {
                    minutogol = rand.Next(minutomin, minutomax);
                }
            }
        }
    }
}
