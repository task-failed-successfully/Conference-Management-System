using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ISS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //UsersRepository repo = new UsersRepository();
            //repo.add(new User("U10", "P10", "N10", "A10", "u10@u10.u10", 2));
            //repo.update(new User("U2", "U20", "U20", "U20", "u2@u2.u2", 3));
            //repo.ToString();

            Conference c = new Conference(110, "");
            c.createConference();
            c.createTables();

        }
    }
}
