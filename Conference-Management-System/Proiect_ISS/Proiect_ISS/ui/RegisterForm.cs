using Proiect_ISS.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ISS.ui
{
    public partial class RegisterForm : Form
    {
        Controller cont;
        String conferenceName;

        public RegisterForm(Controller c, String confName)
        {
            InitializeComponent();
            this.cont = c;
            this.conferenceName = confName;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string usernameString = usernameTextBox.Text;
            string passwordString = passwordTextBox.Text;
            string fullnameString = fullnameTextBox.Text;
            string affiliationString = affiliationTextBox.Text;
            string emailString = emailTextBox.Text;

            //Validate fields here

            Account a = new Account()
            {
                username = usernameString,
                password = passwordString,
                name = fullnameString,
                affiliation = affiliationString,
                email = emailString,
                rank = 1
            };

            cont.add(a, 1, conferenceName);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm(cont, conferenceName);
            f1.ShowDialog();
            this.Close();
        }
    }
}
