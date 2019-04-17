using System;
using System.Windows.Forms;

using Proiect_ISS.src;
using Proiect_ISS.src.domain.validators;

namespace Proiect_ISS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Repository<User, String> repo = new UsersRepository();
            Validator<User> validator = new UserValidator();

            Controller ctrl = new Controller(repo, validator);

            try
            {
                //ctrl.addUser("username1", "parola1", "Name One", "affiliation1", "e1@yahoo.com", 2);
                //ctrl.addUser("username2", "parola2", "Name Two", "affiliation2", "e2@yahoo.com", 1);
                //ctrl.addUser("username3", "parola3", "Name Three", "affiliation3", "e3@yahoo.com", 3);
                //ctrl.addUser("username4", "parola4", "Name Four", "affiliation4", "e4@yahoo.com", 1);

                //ctrl.updateUser("username1", "U2", "U2", "U2", "u2@u2.u2", 3);
                repo.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String user = usernameTextBox.Text;
            String password = passwordTextBox.Text;
            MessageBox.Show("Moving on");
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
