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
    }
}
