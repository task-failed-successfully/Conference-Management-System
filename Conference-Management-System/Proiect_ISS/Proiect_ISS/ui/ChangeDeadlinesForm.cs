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
    public partial class ChangeDeadlinesForm : Form
    {
        Controller cont;
        String conferenceName;

        public ChangeDeadlinesForm(Controller c, String confName)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborting Changes, Returning to Main Menu.");
            this.Hide();
            AdminForm f8 = new AdminForm(cont, conferenceName);
            f8.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime a = Convert.ToDateTime(this.dateTimePicker1.Text);
            DateTime paper = Convert.ToDateTime(this.dateTimePicker2.Text);
            DateTime bidding = Convert.ToDateTime(this.dateTimePicker3.Text);
            DateTime review = Convert.ToDateTime(this.dateTimePicker4.Text);

            this.cont.updateDeadlines(a, paper, bidding, review, conferenceName);


            MessageBox.Show("Changes were made successfuly, Returning to Main Menu.");
            this.Hide();
            AdminForm f8 = new AdminForm(cont, conferenceName);
            f8.ShowDialog();
            this.Close();
        }
    }
}
