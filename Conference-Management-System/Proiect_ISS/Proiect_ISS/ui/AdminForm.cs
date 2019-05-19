using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proiect_ISS.controller;

namespace Proiect_ISS
{
    public partial class AdminForm : Form
    {
        Controller cont;
        String conferenceName;

        public AdminForm(Controller c, String confName)
        {
            InitializeComponent();
            this.cont = c;
            this.conferenceName = confName;

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            exitBtn.TabStop = false;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.FlatAppearance.BorderSize = 0;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Aborting the selection, Returning to Main Menu.");
            this.Hide();
            ChangeDeadlinesForm f9 = new ChangeDeadlinesForm(cont, conferenceName);
            f9.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
