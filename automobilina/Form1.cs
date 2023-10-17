using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automobilina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    }
    class Auto
    {
        private bool Motore;
        private int Vel;
        private int Marcia;
        public Auto()
        {
            Motore = false;
            Vel = 0;
            Marcia = 0;
        }
        public Auto(bool Motore, int Vel, int Marcia)
        {
            this.Motore = Motore;
            this.Vel = Vel;
            this.Marcia = Marcia;
        }
        public void Accensione(bool Motore)
        {
            Motore = true;
        }
        public void Spegnimento(bool Motore)
        {
            Motore = false;
        }
        public void Accellerazione(int Vel)
        {
            Vel += 5;
        }
        public void Freno(int Vel)
        {
            Vel -= 5;
        }

    }
}
