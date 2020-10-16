using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_PlateformeNet
{
    public partial class GestionAlarme : Form
    {
        int mintemp = 0;
        int maxtemp = 0;

        int minhum = 0;
        int maxhum = 0;

        int minvent = 0;
        int maxvent;

        int minpres = 0;
        int maxpres = 0;
        BDD Db;
        public GestionAlarme()
        {
            InitializeComponent();
        }

        public int getminhum { get => minhum; set => minhum = value; }
        public int getmaxhum { get => maxhum; set => maxhum = value; }

        public int getminvent { get => minvent; set => minvent = value; }
        public int getmaxvent { get => maxvent; set => maxvent = value; }

        public int getminpres { get => minpres; set => minpres = value; }
        public int getmaxpres { get => maxpres; set => maxpres = value; }


        public int getmintemp { get => mintemp; set => mintemp = value; }
        public int getmaxtemp { get => maxtemp; set => maxtemp = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.minhum = (int)numericUpDown_minhum.Value;
            this.maxhum = (int)numericUpDown_maxhum.Value;

            this.minvent = (int)numericUpDown_minvent.Value;
            this.maxvent = (int)numericUpDown_maxvent.Value;

            this.minpres = (int)numericUpDown_minpres.Value;
            this.maxpres = (int)numericUpDown_maxpres.Value;

            this.mintemp = (int)numericUpDown_mintemp.Value;
            this.maxtemp = (int)numericUpDown_maxtemp.Value;

            


            this.Close();


        }

        
    }
}
