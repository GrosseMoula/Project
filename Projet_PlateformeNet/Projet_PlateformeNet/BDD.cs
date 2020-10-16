using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_PlateformeNet
{
    /// <summary>
    /// Début éxamen
    /// </summary>
    class BDD
    {
         String chemin = "Provider=Microsoft.ACE.Oledb.12.0; Data Source=DB_Records.accdb;";
         OleDbConnection connexion;

        /******CODE EXAMEN: DEBUT***********/
        public void connectDb() 
        {
            this.connexion = new OleDbConnection();
            this.connexion.ConnectionString = chemin;
           
            
                this.connexion.Open();
            
            
                
            
            
            
                
          

            
            
                //Si la connexion échoue, un MessageBox s'affichera
                
            



        }
        

            public void insertEvent(String tableName,int ID, String date, int value)
            {
                try
            {
                this.connectDb();
                String insert = "INSERT INTO " + tableName + " (ID,Record Date,Record Value) VALUES ( " + ID + ",'" + date + "'," + value + ")";
                OleDbCommand query = new OleDbCommand();
                query.CommandText = insert;
                query.Connection = connexion;
                query.ExecuteNonQuery();
                MessageBox.Show("Inséré avec succès");
                this.connexion.Close();
            }
                catch (Exception ex)
            {
                MessageBox.Show("Erreur : "+ex.Message);
            }




        }
        /******CODE EXAMEN: FIN***********/

        public void Selecting(String filter,String value,DataGridView data)
        {
            String select;
            List<String> date = new List<string>();
            List<String> Type = new List<string>();
            List<String> description = new List<string>();
            List<int> reference = new List<int>();

            connectDb();
            if(filter == "" || filter == "Pas de filtre")
            {
                select = "SELECT * FROM LogsTable";
            }
            else
            {
                select = "SELECT * FROM LogsTable WHERE LogType = '" + filter + "'";
            }
             
            OleDbCommand query = new OleDbCommand();
            
            query.Connection = connexion;
            query.CommandText = select;
            OleDbDataReader cursor = query.ExecuteReader(); 
            while(cursor.Read())
            {
                reference.Add((int)cursor["LogRef"]);
                date.Add((String)cursor["LogDate"]);
                Type.Add((String)cursor["LogType"]);
                description.Add((String)cursor["LogDescription"]);

            }
            data.RowCount = date.Count;
            ///Commme les listes ont le meme count, on aurait pu prendre nimporte laquel
            for (int i = 0; i < date.Count; i++)
            {
                
                data.Rows[i].Cells[0].Value = reference[i];
                data.Rows[i].Cells[1].Value = date[i];
                data.Rows[i].Cells[2].Value = Type[i];
                data.Rows[i].Cells[3].Value = description[i];
            }
            connexion.Close();
            }

        }

        



    }

