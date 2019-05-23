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

            loginButton.TabStop = false;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            Object o = cont.findByUsername(username, conferenceName);

            if(o == null)
            {
                MessageBox.Show("Invalid username!");
                return;
            }

            Account a = (Account)o;

            if(a.password != password)
            {
                MessageBox.Show("Invalid password!");
                return;
            }
            this.Hide();
            switch (a.affiliation)
            {
                case "author":
                    AuthorForm f1 = new AuthorForm(cont, conferenceName);
                    f1.ShowDialog();
                    break;

                case "admin":
                    AdminForm f2 = new AdminForm(cont, conferenceName);
                    f2.ShowDialog();
                    break;

                case "reviewer":
                    ReviewerForm f3 = new ReviewerForm();
                    f3.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Affiliation invalid! Cannot show form.")
                    break;
            }

            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f4 = new RegisterForm(cont, conferenceName);
            f4.ShowDialog();
            this.Close();
        }
    }
}
