
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.IO;

namespace Projet_PlateformeNet
{
    public partial class Form1 : Form
    {
        private String[] header = new string[] { "ID", "Type", "Format", "Valeur", "Min", "Max" };
        private String[] header2 = new string[] { "Type", "Min", "Max" };

        /******CODE EXAMEN: DEBUT*********/

        String selectedType;
        String selectedTimes;
        private BDD db = new BDD();
        private int valueMaxSecond = 60;
        private int valueMaxMinutes = 60;
        private int valueMaxHours = 24;
        private string[] TypeName = new string[] { "Température", "Humidité", "Vent", "Pression" };


        private String[] RecordsTitle = new string[] { "ID", "Period", "Date of last DB Upload" }; //Les titres de la Datagrid du records

            //Dans le projet, il y a 4 type d'ID (qui sont des mesures) : température, pression, cent et humidité. Donc on crée 3 liste pour chaque ID

        private List<Mesure> Temperature_ID_Second = new List<Mesure>();
        private List<Mesure> Temperature_ID_Minutes = new List<Mesure>();
        private List<Mesure> Temperature_ID_Hours = new List<Mesure>();

        private List<Mesure> Pression_ID_Second = new List<Mesure>();
        private List<Mesure> Pression_ID_Minutes = new List<Mesure>();
        private List<Mesure> Pression_ID_Hours = new List<Mesure>();

        private List<Mesure> Humidite_ID_Second = new List<Mesure>();
        private List<Mesure> Humidite_ID_Minutes = new List<Mesure>();
        private List<Mesure> Humidite_ID_Hours = new List<Mesure>();

        private List<Mesure> Vent_ID_Second = new List<Mesure>();
        private List<Mesure> Vent_ID_Minutes = new List<Mesure>();
        private List<Mesure> Vent_ID_Hours = new List<Mesure>();




        /******CODE EXAMEN: FIN***********/


        private DataConfig dc = new DataConfig();
        private GestionAlarme ga = new GestionAlarme();
        private Stack<Mesure> mesures = new Stack<Mesure>();
        private Random rnd = new Random();
        private Graphique graphique = new Graphique();
        private String file_title = "Dataze.csv";

        int mintemp ;
        int maxtemp ;

        int minhum ;
        int maxhum ;

        int minvent ;
        int maxvent ;

        int minpres ;
        int maxpres ;


        public Form1()
        {
            InitializeComponent();
            initdt();
            AddToGraph();
            initdt2();
            

            /******CODE EXAMEN: DEBUT***********/
            initRecords_datagrid();
            initRecords_Cb();
            /******CODE EXAMEN: FIN***********/




            initchart();
            timer1.Enabled = false;

        }
        /******CODE EXAMEN: DEBUT*********/
        private void initRecords_Cb()
        {
            for (int i = 0; i < TypeName.Length; i++)
            {
                ID_ComboBox.Items.Add(TypeName[i]);
            }
        }

       
        private void initRecords_datagrid()
        {
            Records_Datagrid.ColumnCount = 3;   
            for (int i = 0; i < RecordsTitle.Length; i++)
            {

                Records_Datagrid.Columns[i].HeaderCell.Value = RecordsTitle[i];

            }
        }
        /******CODE EXAMEN: FIN***********/






        private void AddToGraph()
        {
            foreach (string val in graphique.Series.Keys)
            {
                chart1.Series.Add(graphique.Series[val]);
            }
        }

        private void initchart()
        {
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{00.00}";
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                chart1.Series[i].MarkerStyle = (System.Windows.Forms.DataVisualization.Charting.MarkerStyle)MarkerStyle.Square;
                chart1.Series[i].MarkerSize = 5;
            }
        }

        private void initdt2()
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < header2.Length ; i++)
            {
                dt.Columns.Add(header[i]);
            }
            dt.Rows.Add("Temperature", 80, 100);
            dt.Rows.Add("Vitesse du vent(km/h)", 70, 100);
            dt.Rows.Add("Humidité", 50, 100);
            dt.Rows.Add("Pression", 80, 100);
            dataGridView_alarme.DataSource = dt;
                
        }

        private void addMesure(Mesure mesure)
        {
            if (mesures.Count > 50)
            {
                mesures.Pop();
                mesures.Push(mesure);
            }
            else
            {
                mesures.Push(mesure);
            }
        }

        private void initdt()
        {
            dataGridView1.ColumnCount = 6;
            for (int i = 0; i < header.Length; i++)
            {
                
                dataGridView1.Columns[i].HeaderCell.Value = header[i];
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {

                timer1.Enabled = true;
            }

            else if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int second = timer1.Interval/100;
            int random = rnd.Next(0, 4);
            
            int value = rnd.Next(dc.Min, dc.Max);
            Mesure mesure = new Mesure(dc.getcb_bits[random], dc.getcb_mesure[random], dc.Min, dc.Max,value); 
            
            addMesure(mesure);
            dataGridView1.Rows.Insert(0, mesure.getID, mesure.getType, mesure.getformat, value, mesure.getmin, mesure.getmax);
            ///PlacerPoints(mesure,second,random);

            if(dataGridView1.Rows[0].Cells[1].Value == "Température")
            {
                /******CODE EXAMEN: DEBUT*********/

                    //la mesure ici est de type temperature, alors on l'ajoute dans la liste correspondante
                Temperature_ID_Second.Add(mesure);
                checkFull(Temperature_ID_Second,valueMaxSecond,Temperature_ID_Minutes,"Temperature");


                /******CODE EXAMEN: FIN*********/

                if (value < maxtemp && value > mintemp)
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Green;
                }
            }

            if (dataGridView1.Rows[0].Cells[1].Value == "Humidité")
            {
                /******CODE EXAMEN: DEBUT*********/

                //la mesure ici est de type humidité, alors on l'ajoute dans la liste correspondante
                Humidite_ID_Second.Add(mesure);
                checkFull(Humidite_ID_Second, valueMaxSecond,Humidite_ID_Minutes,"Humidité");


                /******CODE EXAMEN: FIN*********/

                if (value < this.maxhum && value > this.minhum )
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Green;
                }
            }

            if (dataGridView1.Rows[0].Cells[1].Value == "Vent")
            {
                /******CODE EXAMEN: DEBUT*********/

                //la mesure ici est de type vent, alors on l'ajoute dans la liste correspondante
                Vent_ID_Second.Add(mesure);
                checkFull(Vent_ID_Second, valueMaxSecond,Vent_ID_Minutes,"Vent");


                /******CODE EXAMEN: FIN*********/
                if (value < maxvent && value > minvent)
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Red;
                }
                else if (!(value < this.maxvent && value > this.minvent))
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Green;
                }

            }

            if (dataGridView1.Rows[0].Cells[1].Value == "Pression")
            {
                /******CODE EXAMEN: DEBUT*********/

                //la mesure ici est de type vent, alors on l'ajoute dans la liste correspondante
                Pression_ID_Second.Add(mesure);
                checkFull(Pression_ID_Second, valueMaxSecond,Vent_ID_Minutes,"Pression");


                /******CODE EXAMEN: FIN*********/
                if (value < this.maxpres && value > this.minpres)
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Red;
                }
                else if (!(value < this.maxpres && value > this.minpres))
                {
                    dataGridView1.Rows[0].Cells[3].Style.BackColor = Color.Green;
                }
            }

            ///Début examen
            ///
            
            
           
            //fin



        }

        /******CODE EXAMEN: DEBUT*********/
        private void checkFull(List<Mesure> ID_List_Second,int valueMax, List<Mesure> ID_List_Minutes,string type)
        {
            int AllValue = 0;
            Mesure temp;
            //Cette methode verifiera si la liste (entrée en paramètres) est remplie ou pas
            if(ID_List_Second.Count.Equals(valueMax))
            {
                foreach(var value in ID_List_Second)
                {
                    //On additionne tous les valeurs de la liste seconde
                    AllValue = AllValue + value.getValeur;
                }
                
                AllValue = AllValue / valueMaxSecond;
                temp = new Mesure("16 bits", type, 0, 100, AllValue);
                ID_List_Minutes.Add(temp);
                ID_List_Second.Clear();
            }


            
        }
        /******CODE EXAMEN: FIN*********/

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            
            dc = new DataConfig();
            dc.ShowDialog();

            
            
        }

        private void configurerLesAlarmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            ga = new GestionAlarme();
            ga.ShowDialog();
            this.maxhum = ga.getmaxhum;
            this.minhum = ga.getminhum;

            this.maxtemp = ga.getmaxtemp;
            this.mintemp = ga.getmintemp;

            this.maxvent = ga.getmaxvent;
            this.minvent = ga.getminvent;

            this.maxpres = ga.getmaxpres;
            this.minpres = ga.getminpres;

            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void créerUnProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fn = new Form2();
            fn.ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(comboBox_event.Text);
            String filter = comboBox_filter.Text;
          


        }

        private void button_create_Click(object sender, EventArgs e)
        {
            
            if(File.Exists(file_title) == false)
            {
                File.Create(file_title);
            }

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                String line = (dataGridView2.Rows[i].Cells[0].Value + ";" + dataGridView2.Rows[i].Cells[1].Value + ";" + dataGridView2.Rows[i].Cells[2].Value + ";" + dataGridView2.Rows[i].Cells[3].Value);
                File.AppendAllText(file_title, line + Environment.NewLine);
            }
            MessageBox.Show("Insertion réussie");
            
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            selectedType = ID_ComboBox.Text;
            if(Minutes_RadioButton.Checked)
            {
                selectedTimes = "Minutes";
            }
            else if (Seconds_RadioButton.Checked)
            {
                selectedTimes = "Seconds";
            }
            int index = Records_Datagrid.Rows.Add();
            Records_Datagrid.Rows[index].Cells[0].Value = selectedType;
            Records_Datagrid.Rows[index].Cells[1].Value = selectedTimes;
            Records_Datagrid.Rows[index].Cells[2].Value = DateTime.Now.ToString();


            if (selectedTimes.Equals("Minutes"))
            {
                if(selectedType.Equals("Température"))
                {
                    foreach(var value in Temperature_ID_Minutes)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(),value.getValeur);
                        
                    }
                }
                else if (selectedType.Equals("Humidité"))
                {
                    foreach (var value in Humidite_ID_Minutes)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(), value.getValeur);
                    }
                }
                else if (selectedType.Equals("Vent"))
                {
                    foreach (var value in Vent_ID_Minutes)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(), value.getValeur);
                    }
                }

                else if (selectedType.Equals("Pression"))
                {
                    foreach (var value in Pression_ID_Minutes)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(), value.getValeur);
                    }
                }
            }

            if (selectedTimes.Equals("Seconds"))
            {
                if (selectedType.Equals("Température"))
                {
                    foreach (var value in Temperature_ID_Second)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(), value.getValeur);
                        
                    }
                }
                else if (selectedType.Equals("Humidité"))
                {
                    foreach (var value in Humidite_ID_Second)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(), value.getValeur);
                    }
                }
                else if (selectedType.Equals("Vent"))
                {
                    foreach (var value in Vent_ID_Second)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(), value.getValeur);
                    }
                }

                else if (selectedType.Equals("Pression"))
                {
                    foreach (var value in Pression_ID_Minutes)
                    {
                        db.insertEvent(selectedTimes, value.getID, DateTime.Now.ToString(), value.getValeur);
                    }
                }
            }

        }
    }
   }
        
        
    

