using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulador
{
    public enum TipoTarjeta { Amarilla = 1, Roja = 2 }
    class Tarjeta
    {
        public TipoTarjeta Tipo { get; set; }
        public Jugador jugador { get; set; }
        public int minuto { get; set; }
        public static void AsignacionTarjetas(Random Tarjetas, int amarillas, int rojas, ref int amarillaslocal, ref int amarillasvisitante, ref int rojaslocal, ref int rojasvisitante)
        {
            //recibe partido, calcula tarjetas según el período, modifica el EquipoPartido según la tarjeta que le saca
            for (int am = 0; am < 2; am++)
            {
                amarillas = Tarjetas.Next(0, 100);
                if (amarillas <= 10)
                {
                    amarillas = 0;
                }
                if (amarillas > 10 && amarillas <= 20)
                {
                    amarillas = 1;
                }
                if (amarillas > 20 && amarillas <= 30)
                {
                    amarillas = 2;
                }
                if (amarillas > 30 && amarillas <= 50)
                {
                    amarillas = 3;
                }
                if (amarillas > 50 && amarillas <= 70)
                {
                    amarillas = 4;
                }
                if (amarillas > 70 && amarillas <= 85)
                {
                    amarillas = 5;
                }
                if (amarillas > 85 && amarillas <= 100)
                {
                    amarillas = 6;
                }
                rojas = Tarjetas.Next(0, 100);
                if (rojas < 60)
                {
                    rojas = 0;
                }
                if (rojas >= 60 && rojas < 80)
                {
                    rojas = 1;
                }
                if (rojas >= 80 && rojas < 98)
                {
                    rojas = 2;
                }
                if (rojas >= 98)
                {
                    rojas = 3;
                }
                if (am == 0)
                {
                    amarillaslocal = amarillas;
                    rojaslocal = rojas;
                }
                else
                {
                    amarillasvisitante = amarillas;
                    rojasvisitante = rojas;
                }
            }
        }
        public static void AsignarTarjetaPosicion(Random ran, int PosRandom, Equipo equipo)
        {
            List<Jugador> jug = new List<Jugador>();
            jug.Clear();
            PosRandom = ran.Next(0, 100);
            if (PosRandom <= 3)
            {
                foreach (Jugador juga in equipo.Jugadores)
                {
                    if (juga.posicion == "Arquero")
                    {
                        jug.Add(juga);
                    }
                }

            }

            if (PosRandom >= 4 && PosRandom <= 45)
            {
                foreach (Jugador juga in equipo.Jugadores)
                {
                    if (juga.posicion == "Defensor")
                    {
                        jug.Add(juga);
                    }
                }
            }

            if (PosRandom >= 46 && PosRandom <= 75)
            {
                foreach (Jugador juga in equipo.Jugadores)
                {
                    if (juga.posicion == "Mediocampista")
                    {
                        jug.Add(juga);
                    }
                }
            }


            if (PosRandom >= 76 && PosRandom <= 100)
            {
                foreach (Jugador juga in equipo.Jugadores)
                {
                    if (juga.posicion == "Delantero")
                    {
                        jug.Add(juga);
                    }
                }
            }
            PosRandom = ran.Next(0, jug.Count());
        }
    }
}
