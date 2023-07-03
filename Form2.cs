using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoNET
{
    public partial class Form2 : Form
    {
        private string nombreJugador;
        
        private int numeroGenerado;
        private int [,] tableroJugador=new int [4,4];
        private bool[,] tableroMarcados = new bool[4, 4];
        public Form2(string nombreJugador)
        {
            InitializeComponent();
            NombreJugador = nombreJugador;
            nombreLabel.Text= nombreJugador;
            llenarTablero();

            //Dibujado de la matriz
            button1.Text=Convert.ToString(tableroJugador[0,0]);
            button2.Text = Convert.ToString(tableroJugador[0, 1]);
            button3.Text = Convert.ToString(tableroJugador[0, 2]);
            button4.Text = Convert.ToString(tableroJugador[0,3]);
            button5.Text = Convert.ToString(tableroJugador[1,0]);
            button6.Text = Convert.ToString(tableroJugador[1, 1]);
            button7.Text = Convert.ToString(tableroJugador[1, 2]);
            button8.Text = Convert.ToString(tableroJugador[1, 3]);
            button9.Text = Convert.ToString(tableroJugador[2, 0]);
            button10.Text = Convert.ToString(tableroJugador[2, 1]);
            button11.Text = Convert.ToString(tableroJugador[2, 2]);
            button12.Text = Convert.ToString(tableroJugador[2, 3]);
            button13.Text = Convert.ToString(tableroJugador[3, 0]);
            button14.Text = Convert.ToString(tableroJugador[3, 1]);
            button15.Text = Convert.ToString(tableroJugador[3, 2]);
            button16.Text = Convert.ToString(tableroJugador[3, 3]);

        }

        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPedir_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            numeroGenerado = rnd.Next(1, 76);
            labelNumeroGenerado.Text = Convert.ToString(numeroGenerado);
        }

        private void llenarTablero()
        {
            Random rand=new Random();

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    tableroJugador[i, j] = rand.Next(1, 76);
                }
            }
            
        }

        private void marcarNumero(Button btn,int fila, int columna)
        {
            if (numeroGenerado == tableroJugador[fila, columna])
            {
                btn.BackColor = Color.LightSteelBlue;
                tableroMarcados[fila, columna] = true;
                chequearResultado();
            }
            else
            {
                MessageBox.Show("No se puede marcar un numero que no haya salido!");
            }
        }

        private void chequearResultado()
        {
            //Se que es una condicion logica larga, pero es necesaria para chequear si hay alguna linea completada ><
            if (tableroMarcados[0,0]&& tableroMarcados[0,1] && tableroMarcados[0,2] && tableroMarcados[0,3] || tableroMarcados[1,0] && tableroMarcados[1,1] && tableroMarcados[1,2] &&tableroMarcados[1,3] || tableroMarcados[2,0] && tableroMarcados[2,1] && tableroMarcados[2,2] && tableroMarcados[2,3] || tableroMarcados[3,0] && tableroMarcados[3,1] && tableroMarcados[3,2] && tableroMarcados[3,3] || tableroMarcados[0, 0]&& tableroMarcados[1, 0]&&tableroMarcados[2, 0] && tableroMarcados[3, 0] || tableroMarcados[0, 1] && tableroMarcados[1, 1] && tableroMarcados[2, 1] && tableroMarcados[3, 1] || tableroMarcados[0, 2] && tableroMarcados[1, 2] && tableroMarcados[2, 2] && tableroMarcados[3, 2] || tableroMarcados[0, 3] && tableroMarcados[1, 3] && tableroMarcados[2, 3] && tableroMarcados[3, 3]|| tableroMarcados[0, 0] && tableroMarcados[1, 1] && tableroMarcados[2, 2] && tableroMarcados[3, 3] || tableroMarcados[0, 3] && tableroMarcados[1, 2] && tableroMarcados[2, 1] && tableroMarcados[3, 0])
            {
                MessageBox.Show("Felecitaciones, " + NombreJugador + " has ganado!");
            }
        }



        private void button11_Click(object sender, EventArgs e)
        {
            marcarNumero(button11, 2, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marcarNumero(button2, 0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marcarNumero(button3, 0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            marcarNumero(button4, 0, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            marcarNumero(button5, 1, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            marcarNumero(button6, 1, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            marcarNumero(button7, 1, 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            marcarNumero(button8, 1, 3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            marcarNumero(button9, 2, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            marcarNumero(button10, 2, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marcarNumero(button1,0,0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            marcarNumero(button12, 2, 3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            marcarNumero(button13, 3, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            marcarNumero(button14, 3, 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            marcarNumero(button15, 3, 2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            marcarNumero(button16, 3, 3);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tableroMarcados[i, j] = false;
                }
            }
            llenarTablero();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
