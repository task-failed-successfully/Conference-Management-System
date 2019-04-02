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

            UsersRepository repo = new UsersRepository();
            //repo.add(new User("U2", "P2", "N2", "A2", "u2@u2.u2", 2));
            repo.update(new User("U2", "U2", "U2", "U2", "u2@u2.u2", 3));
            repo.ToString();
        }
    }
}
