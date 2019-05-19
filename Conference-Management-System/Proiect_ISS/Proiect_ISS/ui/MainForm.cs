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

namespace Proiect_ISS.ui
{
    public partial class MainForm : Form
    {
        Controller cont;

        public MainForm(Controller c)
        {
            InitializeComponent();
            this.cont = c;

            newBtn.TabStop = false;
            newBtn.FlatStyle = FlatStyle.Flat;
            newBtn.FlatAppearance.BorderSize = 0;

            exitBtn.TabStop = false;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.FlatAppearance.BorderSize = 0;

            chooseBtn.TabStop = false;
            chooseBtn.FlatStyle = FlatStyle.Flat;
            chooseBtn.FlatAppearance.BorderSize = 0;

            //UploadProposalForm cee = new UploadProposalForm(cont,"a");
            //cee.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {  
            Application.Exit();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfCreationForm f3 = new ConfCreationForm(cont);
            f3.ShowDialog();
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseConfForm f5 = new ChooseConfForm(cont);
            f5.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
