using System;
using System.Windows.Forms;

using Proiect_ISS.controller;

namespace Proiect_ISS.ui
{
    public partial class LoginForm : Form
    {
        Controller cont;
        String conferenceName;

        public LoginForm(Controller c, String confName)
        {
            InitializeComponent();
            this.cont = c;
            this.conferenceName = confName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
