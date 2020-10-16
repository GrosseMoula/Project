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

    /// <summary>
    /// Début examen
    /// </summary>
    public partial class Form2 : Form
    {
        private String login;
        private String password;
        BDD Db;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_login.Text = login;
            maskedTextBox_password.Text = password;
            
        }

        ///Fin examen
        ///




    }

    
    
}
