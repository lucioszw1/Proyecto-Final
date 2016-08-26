using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using Simulador.Properties;

namespace Simulador
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        Random rand = new Random();
        List<Equipo> ListaEqLocal = new List<Equipo>();
        List<Equipo> ListaEqVisitante = new List<Equipo>();
        int tiempopart;
        int minutogol;
        String NombreDelantero1;
        String NombreDelantero2;
        String NombreDelantero3;
        String NombreArquero1;
        String NombreMediocampuista1;
        String NombreMediocampuista2;
        String NombreMediocampuista3;
        String NombreMediocampuista4;
        String NombreMediocampuista5;
        String Defensor1;
        String Defensor2;
        String Defensor3;
        String Defensor4;
        String Defensor5;
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = Settings.Default.Conexion;
            conn.Open();
            OleDbCommand Consulta = conn.CreateCommand();
            Consulta.CommandType = CommandType.StoredProcedure;
            Equipo.ObtenerEquipos(ListaEqLocal);
            Equipo.ObtenerEquipos(ListaEqVisitante);
            comboBox1.DataSource = ListaEqLocal;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = ListaEqVisitante;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Id";
            if (comboBox1.Items.Count > 0)
            {
                this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if (comboBox2.Items.Count > 0)
            {
                this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void BTNJugar_Click_1(object sender, EventArgs e)
        {
            Equipo Loc = new Equipo();            
            Equipo Vis = new Equipo();            
            Loc = (Equipo)comboBox1.SelectedItem;
            Vis = (Equipo)comboBox2.SelectedItem;
            EquipoPartido Local = new EquipoPartido();
            EquipoPartido Visitante = new EquipoPartido();
            Local.equipo = Loc;
            Visitante.equipo = Vis;
            Local.Titulares = Equipopart;
            EquipoPartido.AsignarTitularesRandom(Visitante);
            if (Local.equipo.nombre == Visitante.equipo.nombre || Local.equipo.nombre == "" || Visitante.equipo.nombre == "")
            {
                MessageBox.Show("Por favor ingrese correctamente los equipos");
            }
            else
            {
                if (Local.Titulares.Count != 11)
                {
                    EquipoPartido.AsignarTitularesRandom(Local);
                    MessageBox.Show("Al no poner 11 titulares, irá con formación al azar");
                }
                string formacion = "";
                foreach (Jugador j in Local.Titulares)
                {
                    formacion += j.apellido + ", ";
                }
                string formacion2 = "";
                foreach (Jugador j in Visitante.Titulares)
                {
                    formacion2 += j.apellido + ", ";
                }
                MessageBox.Show("Titulares de " + Local.equipo.nombre + ":" + Environment.NewLine + formacion + Environment.NewLine + "Titulares de " + Visitante.equipo.nombre + ":" + Environment.NewLine + formacion2);
                int gol1 = 0;
                int gol2 = 0;
                int num1 = 0;
                int num2 = 0;
                int fuerzalocal = Local.fuerza;
                int fuerzavisitante = Visitante.fuerza;
                int periodo = 0;
                int golanterior = 0;
                int golanterior2 = 0;
                int IDgol = 0;
                string goleador = "";
                for (int i = 0; i < 6; i++)
                {
                    periodo++;
                    Estado.CalcularFuerza(ref num1, ref num2, rand, fuerzalocal, fuerzavisitante);
                    Gol.CalcularGoles(num1, num2, rand, ref gol1, ref gol2);
                    //timer1.Start();
                    if (gol1 != golanterior)
                    {
                        for (int l = 0; l < gol1 - golanterior; l++)
                        {
                            Gol.AsignarGol(rand, IDgol, ref goleador, Local);
                            Gol.AsignarMinuto(periodo, ref minutogol);
                            this.dgvLocal.Rows.Add(goleador, Convert.ToString(minutogol) + "'");
                            IDgol = 0;
                            goleador = "";
                        }
                        
                    }
                    if (gol2 != golanterior2)
                    {
                        for (int m = 0; m < gol2 - golanterior2; m++)
                        {
                            Gol.AsignarGol(rand, IDgol, ref goleador, Visitante);
                            Gol.AsignarMinuto(periodo, ref minutogol);
                            this.dgvVisitante.Rows.Add(goleador, Convert.ToString(minutogol) + "'");
                            IDgol = 0;
                            goleador = "";
                        }
                    }
                    tiempopart += Settings.Default.MinutoPeriodo;
                    lblminutos.Text = Convert.ToString(tiempopart) + "'";
                    lblgolloc.Text = Convert.ToString(gol1);
                    lblgolvis.Text = Convert.ToString(gol2);
                    golanterior = gol1;
                    golanterior2 = gol2;
                    MessageBox.Show("Avanzar");
                    Thread.Sleep(200);
                }
                
            }
            int amarillas = 0;
            int rojas = 0;
            int amarillaslocal = 0;
            int rojaslocal = 0;
            int amarillasvisitante = 0;
            int rojasvisitante = 0;
            Tarjeta.AsignacionTarjetas(rand, amarillas, rojas, ref amarillaslocal, ref amarillasvisitante, ref rojaslocal, ref rojasvisitante);
            MessageBox.Show("Cantidad de amarillas del local: " + amarillaslocal + Environment.NewLine + "Cantidad de rojas del local: " + rojaslocal);
            MessageBox.Show("Cantidad de amarillas del visitante: " + amarillasvisitante + Environment.NewLine + "Cantidad de rojas del visitante: " + rojasvisitante);
            //dgvLocal.Sort(dgvLocal.Columns(1), ListSortDirection.Ascending);
            BTNJugar.Enabled = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvLocal.Rows.Clear();
            dgvVisitante.Rows.Clear();
            BTNJugar.Enabled = true;
            lblgolloc.Text = "0";
            lblgolvis.Text = "0";
            tiempopart = 0;
            lblminutos.Text = Convert.ToString(tiempopart) +"'";
            Application.Restart();         
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 formaSiguiente = new Form2();
            this.Hide();
            formaSiguiente.Show();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArq.Items.Clear();
            cmbDef.Items.Clear();
            cmbVol.Items.Clear();
            cmbDel.Items.Clear();
            List<Jugador> jugeq = new List<Jugador>();
            foreach (Equipo equi in ListaEqLocal)
            {
                if (equi == (Equipo)comboBox1.SelectedItem)
                {
                    jugeq = equi.Jugadores;
                }
            }
            foreach (Jugador jugad in jugeq)
            {
                if (jugad.posicion == "Arquero")
                {
                    cmbArq.Items.Add(jugad);
                    cmbArq.DisplayMember = "Apellido";
                    cmbArq.ValueMember = "Id";
                }
                if (jugad.posicion == "Defensor")
                {
                    cmbDef.Items.Add(jugad);
                    cmbDef.DisplayMember = "Apellido";
                    cmbDef.ValueMember = "Id";
                }
                if (jugad.posicion == "Mediocampista")
                {
                    cmbVol.Items.Add(jugad);
                    cmbVol.DisplayMember = "Apellido";
                    cmbVol.ValueMember = "Id";
                }
                if (jugad.posicion == "Delantero")
                {
                    cmbDel.Items.Add(jugad);
                    cmbDel.DisplayMember = "Apellido";
                    cmbDel.ValueMember = "Id";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        bool arqueros;
        bool defensores;
        bool mediocampistas;
        bool delanteros;
        List<Jugador> Equipopart = new List<Jugador>();
        Jugador seleccionado = new Jugador();
        private void btnArquero_Click_1(object sender, EventArgs e)
       
        {
            if (lblArquero.Text == "Arquero")
            {
                seleccionado = (Jugador)cmbArq.SelectedItem;
                NombreArquero1 = seleccionado.apellido;
                lblArquero.Text = NombreArquero1;
                Equipopart.Add(seleccionado);
                cmbArq.Items.Remove(seleccionado);
            }

            else
            {
                if (lblArquero2.Text == "Arquero")
                {
                    if (lblArquero.Text == NombreArquero1 && Convert.ToString(cmbArq.SelectedItem) == NombreArquero1)
                    {
                        lblArquero2.Text = "Arquero";
                    }
                    else
                    {
                        seleccionado = (Jugador)cmbArq.SelectedItem;
                        string NombreArquero2 = seleccionado.apellido;
                        lblArquero2.Text = NombreArquero2;
                        cmbArq.Items.Remove(seleccionado);
                        //Equipopart.Add(seleccionado);
                    }
                }
            }
        }

        private void btnDefensor_Click_1(object sender, EventArgs e)
        {
            if (lblDefensor1.Text == "Defensor")
            {
                seleccionado = (Jugador)cmbDef.SelectedItem;
                Defensor1 = seleccionado.apellido;
                lblDefensor1.Text = Defensor1;
                Equipopart.Add(seleccionado);
                cmbDef.Items.Remove(seleccionado);

            }
            else
            {
                if (lblDefensor2.Text == "Defensor")
                {
                    if (lblDefensor1.Text == Defensor1 && Convert.ToString(cmbDef.SelectedItem) == Defensor1)
                    {

                        lblDefensor2.Text = "Defensor";
                    }
                    else
                    {
                        seleccionado = (Jugador)cmbDef.SelectedItem;
                        Defensor2 = seleccionado.apellido;
                        lblDefensor2.Text = Defensor2;
                        Equipopart.Add(seleccionado);
                        cmbDef.Items.Remove(seleccionado);


                    }
                }
                else
                {
                    if (lblDefensor3.Text == "Defensor")
                    {
                        if (lblDefensor1.Text == Defensor1 && Convert.ToString(cmbDef.SelectedItem) == Defensor1 || lblDefensor2.Text == Defensor2 && Convert.ToString(cmbDef.SelectedItem) == Defensor2)
                        {

                            lblDefensor3.Text = "Defensor";
                        }
                        else
                        {
                            seleccionado = (Jugador)cmbDef.SelectedItem;
                            Defensor3 = seleccionado.apellido;
                            lblDefensor3.Text = Defensor3;
                            Equipopart.Add(seleccionado);
                            cmbDef.Items.Remove(seleccionado);

                        }
                    }
                    else
                    {
                        if (lblDefensor4.Text == "Defensor")
                        {
                            if ((lblDefensor1.Text == Defensor1 && Convert.ToString(cmbDef.SelectedItem) == Defensor1 || lblDefensor2.Text == Defensor2 && Convert.ToString(cmbDef.SelectedItem)
                                == Defensor2 || lblDefensor3.Text == Defensor3 && Convert.ToString(cmbDef.SelectedItem) == Defensor3))
                            {
                                lblDefensor4.Text = "Defensor";
                            }
                            else
                            {
                                seleccionado = (Jugador)cmbDef.SelectedItem;
                                Defensor4 = seleccionado.apellido;
                                lblDefensor4.Text = Defensor4;
                                Equipopart.Add(seleccionado);
                                cmbDef.Items.Remove(seleccionado);

                            }
                        }
                        else
                        {
                            if (lblDefensor5.Text == "Defensor")
                            {
                                if ((lblDefensor1.Text == Defensor1 && Convert.ToString(cmbDef.SelectedItem) == Defensor1 || lblDefensor2.Text == Defensor2 && Convert.ToString(cmbDef.SelectedItem)
                                    == Defensor2 || lblDefensor3.Text == Defensor3 && Convert.ToString(cmbDef.SelectedItem) == Defensor3 || lblDefensor4.Text == Defensor4 && Convert.ToString(cmbDef.SelectedItem) == Defensor4))
                                {
                                    lblDefensor5.Text = "Defensor";
                                }
                                else
                                {
                                    seleccionado = (Jugador)cmbDef.SelectedItem;
                                    lblDefensor5.Text = seleccionado.apellido;
                                    Equipopart.Add(seleccionado);
                                    cmbDef.Items.Remove(seleccionado);
                                }
                            }
                            else
                            {
                                if (lblDefensor6.Text == "Defensor")
                                {
                                    if ((lblDefensor1.Text == Defensor1 && Convert.ToString(cmbDef.SelectedItem) == Defensor1 || lblDefensor2.Text == Defensor2 && Convert.ToString(cmbDef.SelectedItem)
                                        == Defensor2 || lblDefensor3.Text == Defensor3 && Convert.ToString(cmbDef.SelectedItem) == Defensor3 || lblDefensor4.Text == Defensor4 && Convert.ToString(cmbDef.SelectedItem) == Defensor4
                                        || lblDefensor5.Text == Defensor5 && Convert.ToString(cmbDef.SelectedItem) == Defensor5))
                                    {
                                        lblDefensor6.Text = "Defensor";
                                    }
                                    else
                                    {
                                        seleccionado = (Jugador)cmbDef.SelectedItem;
                                        lblDefensor6.Text = seleccionado.apellido;
                                        Equipopart.Add(seleccionado);
                                        cmbDef.Items.Remove(seleccionado);
                                    }
                                }
                            }                            
                        }                        
                    }                    
                }   
            }
        }
        
        private void btnMedio_Click_1(object sender, EventArgs e)
           {
            if (lblVolante1.Text == "Mediocampista")
            {
                seleccionado = (Jugador)cmbVol.SelectedItem;
                NombreMediocampuista1 = seleccionado.apellido;
                lblVolante1.Text = NombreMediocampuista1;
                Equipopart.Add(seleccionado);
                cmbVol.Items.Remove(seleccionado);

            }
            else
            {
                if (lblVolante2.Text == "Mediocampista")
                {
                    if (lblVolante1.Text == NombreMediocampuista1 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista1)
                    {

                        lblVolante2.Text = "Mediocampista";
                    }
                    else
                    {
                        seleccionado = (Jugador)cmbVol.SelectedItem;
                        NombreMediocampuista2 = seleccionado.apellido;
                        lblVolante2.Text = NombreMediocampuista2;
                        Equipopart.Add(seleccionado);
                        cmbVol.Items.Remove(seleccionado);

                    }
                }
                else
                {
                    if (lblVolante3.Text == "Mediocampista")
                    {
                        if (lblVolante1.Text == NombreMediocampuista1 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista1 || lblVolante2.Text == NombreMediocampuista2 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista2)
                        {

                            lblVolante3.Text = "Mediocampista";
                        }
                        else
                        {
                            seleccionado = (Jugador)cmbVol.SelectedItem;
                            NombreMediocampuista3 = seleccionado.apellido;
                            lblVolante3.Text = NombreMediocampuista3;
                            Equipopart.Add(seleccionado);
                            cmbVol.Items.Remove(seleccionado);

                        }
                    }

                    else
                    {
                        if (lblVolante4.Text == "Mediocampista")
                        {
                            if ((lblVolante1.Text == NombreMediocampuista1 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista1 || lblVolante2.Text == NombreMediocampuista2 && Convert.ToString(cmbVol.SelectedItem)
                                == NombreMediocampuista2 || lblVolante3.Text == NombreMediocampuista3 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista3))
                            {
                                lblVolante4.Text = "Mediocampista";
                            }
                            else
                            {
                                seleccionado = (Jugador)cmbVol.SelectedItem;
                                NombreMediocampuista4 = seleccionado.apellido;
                                lblVolante4.Text = NombreMediocampuista4;
                                Equipopart.Add(seleccionado);
                                cmbVol.Items.Remove(seleccionado);

                            }

                        }
                        else
                        {
                            if (lblVolante5.Text == "Mediocampista")
                            {
                                if ((lblVolante1.Text == NombreMediocampuista1 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista1 || lblVolante2.Text == NombreMediocampuista2 && Convert.ToString(cmbVol.SelectedItem)
                                    == NombreMediocampuista2 || lblVolante3.Text == NombreMediocampuista3 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista3
                                   || lblVolante4.Text == NombreMediocampuista4 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista4))
                                {
                                    lblVolante5.Text = "Mediocampista";
                                }
                                else
                                {
                                    seleccionado = (Jugador)cmbVol.SelectedItem;
                                    NombreMediocampuista5 = seleccionado.apellido;
                                    lblVolante5.Text = NombreMediocampuista5;
                                    Equipopart.Add(seleccionado);
                                    cmbVol.Items.Remove(seleccionado);

                                }
                            }
                            else
                            {
                                if (lblVolante6.Text == "Mediocampista")
                                {
                                    if ((lblVolante1.Text == NombreMediocampuista1 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista1 || lblVolante2.Text == NombreMediocampuista2 && Convert.ToString(cmbVol.SelectedItem)
                                        == NombreMediocampuista2 || lblVolante3.Text == NombreMediocampuista3 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista3
                                       || lblVolante4.Text == NombreMediocampuista4 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista4 || lblVolante5.Text == NombreMediocampuista5 && Convert.ToString(cmbVol.SelectedItem) == NombreMediocampuista5))
                                    {
                                        lblVolante6.Text = "Mediocampista";
                                    }
                                    else
                                    {
                                        seleccionado = (Jugador)cmbVol.SelectedItem;
                                        lblVolante6.Text = seleccionado.apellido;
                                        Equipopart.Add(seleccionado);
                                        cmbVol.Items.Remove(seleccionado);

                                    }
                                }
                            }                            
                        }                        
                    }                    
                }
            }
        }

        private void btnDelantero_Click_1(object sender, EventArgs e)
         {


            if (lblDelantero1.Text == "Delantero")
            {
                seleccionado = (Jugador)cmbDel.SelectedItem;
                NombreDelantero1 = seleccionado.apellido;
                lblDelantero1.Text = NombreDelantero1;
                Equipopart.Add(seleccionado);
                cmbDel.Items.Remove(seleccionado);

            }
            else
            {
                if (lblDelantero2.Text == "Delantero")
                {
                    if (lblDelantero1.Text == NombreDelantero1 && Convert.ToString(cmbDel.SelectedItem) == NombreDelantero1)
                    {

                        lblDelantero2.Text = "Delantero";
                    }
                    else
                    {
                        seleccionado = (Jugador)cmbDel.SelectedItem;
                        NombreDelantero2 = seleccionado.apellido;
                        lblDelantero2.Text = NombreDelantero2;
                        Equipopart.Add(seleccionado);
                        cmbDel.Items.Remove(seleccionado);
                    }

                }
                else
                {
                    if (lblDelantero3.Text == "Delantero")
                    {
                        if (lblDelantero1.Text == NombreDelantero1 && Convert.ToString(cmbDel.SelectedItem) == NombreDelantero1 || lblDelantero2.Text == NombreDelantero2 && Convert.ToString(cmbDel.SelectedItem) == NombreDelantero2)
                        {

                            lblDelantero3.Text = "Delantero";
                        }
                        else
                        {
                            seleccionado = (Jugador)cmbDel.SelectedItem;
                            lblDelantero3.Text = seleccionado.apellido;
                            Equipopart.Add(seleccionado);
                            cmbDel.Items.Remove(seleccionado);

                        }

                    }

                    else
                    {
                        if (lblDelantero4.Text == "Delantero")
                        {
                            if (lblDelantero1.Text == NombreDelantero1 && Convert.ToString(cmbDel.SelectedItem) == NombreDelantero1 || lblDelantero2.Text == NombreDelantero2 && Convert.ToString(cmbDel.SelectedItem) == NombreDelantero2
                                || lblDelantero3.Text == NombreDelantero3 && Convert.ToString(cmbDel.SelectedItem) == NombreDelantero3)
                            {

                                lblDelantero4.Text = "Delantero";
                            }
                            else
                            {
                                seleccionado = (Jugador)cmbDel.SelectedItem;
                                lblDelantero4.Text = seleccionado.apellido;
                                Equipopart.Add(seleccionado);
                                cmbDel.Items.Remove(seleccionado);

                            }

                        }
                    }                    
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        public static void Sleep(int millisecondsTimeout) { }
    }
}
