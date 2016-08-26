using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Simulador.Properties;

namespace Simulador
{
    class Equipo
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int fuerza
        {
            get
              {
                  int suma = 0;
                  foreach (Jugador jug in Jugadores)
                  {
                      suma = suma + jug.fuerza;                      
                  }
                  suma /= Jugadores.Count;
                  return suma;
              }
        }
        public List<Jugador> Jugadores { get; set; }


        public static List<Equipo> ObtenerEquipos(List<Equipo> ListaEq)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = Settings.Default.Conexion;
            conn.Open();
            OleDbCommand Consulta = conn.CreateCommand();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "Consulta1";
            OleDbDataReader drEquipo = Consulta.ExecuteReader();
            int iii = 0;
            while (drEquipo.Read())
            {
                Equipo Eq = new Equipo();
                Eq.Id = Convert.ToInt32(drEquipo["Id"]);
                Eq.nombre = drEquipo["Equipo"].ToString();
                OleDbCommand Consulta2 = conn.CreateCommand();
                Consulta2.CommandType = CommandType.StoredProcedure;
                Consulta2.CommandText = "Consulta2";
                Consulta2.Parameters.AddWithValue("w",Eq.Id);
                OleDbDataReader drJugadores = Consulta2.ExecuteReader();
                Eq.Jugadores = new List<Jugador>();
                while (drJugadores.Read())
                {
                    Jugador NuevoJug = new Jugador();
                    NuevoJug.ID = Convert.ToInt16(drJugadores["j.Id"]);
                    NuevoJug.nombre = drJugadores["Nombre"].ToString();
                    NuevoJug.apellido = drJugadores["Apellido"].ToString();
                    NuevoJug.fuerza = Convert.ToInt16(drJugadores["Puntaje"]);
                    NuevoJug.posicion = drJugadores["Posicion"].ToString();
                    Eq.Jugadores.Add(NuevoJug);
                }
                ListaEq.Add(Eq);
                iii++;

            }
            conn.Close();
            return ListaEq;            
            //buscar equipo
            //llenar equipo
            //asignar las propiedades del equipo menos los jugaodres "nombre = el nombre de la base de datos"            
        }
    }
}
