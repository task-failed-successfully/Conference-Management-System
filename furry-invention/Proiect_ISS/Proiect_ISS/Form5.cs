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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborting the selection, Returning to Main Menu.");
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
