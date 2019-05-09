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
using Proiect_ISS.ui;

namespace Proiect_ISS
{
    public partial class ChooseConfForm : Form
    {
        Controller cont;
        
        public ChooseConfForm(Controller c)
        {
            InitializeComponent();
            this.cont = c;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f2 = new MainForm(cont);
            f2.Show();
        }

        private void conferenceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)conferenceList.SelectedItems[0];
                this.Hide();
                LoginForm login = new LoginForm(cont, row[1].ToString());
                login.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChooseConfForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conferenceDataSet.Conference' table. You can move, or remove it, as needed.
            this.conferenceTableAdapter.Fill(this.conferenceDataSet.Conference);

        }
    }
}
