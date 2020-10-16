using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_PlateformeNet
{
    public partial class DataConfig : Form
    {
        String name_file = "AllConfig.txt";
        String type = "Humidité";
        String format = "16 bits";
        int min = 0;
        int max = 100;

        String[] cb_id = new string[] { "lalala", "lilili","lololo","lululu" };
        String[] cb_mesure = new string[] { "Température", "Humidité","Vent","Pression" };
        String[] cb_bits = new string[] { "8 bits", "16 bits","24 bits","32 bits" };

        public string Format { get => format; set => format = value; }
        public string Type { get => type; set => type = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }

        public string[] getcb_mesure { get => cb_mesure; set => cb_mesure = value; }

        public string[] getcb_bits { get => cb_bits; set => cb_bits = value; }


        public DataConfig()
        {
            InitializeComponent();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.type = comboBox_mesure.Text;
            this.format = comboBox_bits.Text;
            this.min = (int)(numericUpDown_min.Value);
            this.max = (int)numericUpDown_max.Value;
            if(this.min > this.max)
            {
                MessageBox.Show("La valeur minimale est plus grande que la valeur maximale, recommencez !");
            }
            else
            {
                writefile();
            }
            
        }

        private void writefile()
        {
            //On ajoute les données dans un fichier txt
            if (!File.Exists(name_file))
            {
                File.Create(name_file);
            }

            String text = comboBox_ID.Text + ";" + type + ";" + format + ";" + min + ";" + max;
            File.AppendAllText(name_file, text + Environment.NewLine); //ecrit dans le fichier a la ligne suivante
        }
    private void DataConfig_Load(object sender, EventArgs e)
    { 
            initCb();
        }
        private void initCb()
        {
            comboBox_ID.Items.AddRange(cb_id);
            comboBox_mesure.Items.AddRange(cb_mesure);
            comboBox_bits.Items.AddRange(cb_bits);

        }
    }

    

        
    
}
