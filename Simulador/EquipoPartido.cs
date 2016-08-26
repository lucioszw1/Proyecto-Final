using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulador
{
    class EquipoPartido
    {
        public Equipo equipo { get; set; }
        public int fuerza
        {
            get
            {
                int suma = 0;
                foreach (Jugador jug in Titulares)
                {
                    suma = suma + jug.fuerza;
                }
                suma /= 11;
                return suma;
            }
        }
        public List<Jugador> Titulares { get; set; }
        public List<Jugador> Suplentes { get; set; }
        public bool Local { get; set; }

        public static void AsignarTitularesRandom(EquipoPartido eq)
        {
            Random rand = new Random();
            List<Jugador> jug = new List<Jugador>();
            eq.Titulares = new List<Jugador>();
            int id;
            //eq.Titulares.Clear();
            foreach (Jugador juga in eq.equipo.Jugadores)
            {
                if (juga.posicion == "Arquero")
                {
                    jug.Add(juga);
                }
            }
            id = rand.Next(0, jug.Count-1);
            eq.Titulares.Add(jug[id]);
            jug.Clear();

            foreach (Jugador juga in eq.equipo.Jugadores)
            {
                if (juga.posicion == "Defensor")
                {
                    jug.Add(juga);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                id = rand.Next(0, jug.Count - 1);
                eq.Titulares.Add(jug[id]);
                jug.Remove(jug[id]);
            }
            jug.Clear();

            foreach (Jugador juga in eq.equipo.Jugadores)
            {
                if (juga.posicion == "Mediocampista")
                {
                    jug.Add(juga);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                id = rand.Next(0, jug.Count - 1);
                eq.Titulares.Add(jug[id]);
                jug.Remove(jug[id]);
            }
            jug.Clear();

            foreach (Jugador juga in eq.equipo.Jugadores)
            {
                if (juga.posicion == "Delantero")
                {
                    jug.Add(juga);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                id = rand.Next(0, jug.Count - 1);
                eq.Titulares.Add(jug[id]);
                jug.Remove(jug[id]);
            }
            jug.Clear();
        }
        //metodo que asigna titulares y suplentes
        //metodo para modificar titulares y suplentes (sacas jugadores que sale de ambas listas), realizar el cambio
    }
}
