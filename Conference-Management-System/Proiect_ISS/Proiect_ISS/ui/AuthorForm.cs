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
    public partial class AuthorForm : Form
    {
        Controller cont;
        String conferenceName;

        public AuthorForm(Controller c, String confName)
        {
            InitializeComponent();
            this.cont = c;
            this.conferenceName = confName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Aborting the selection, Returning to Main Menu.");
            this.Hide();
            UploadProposalForm f7 = new UploadProposalForm(cont, conferenceName);
            f7.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
