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
    public partial class UploadProposalForm : Form
    {
        Controller cont;
        String conferenceName;

        public UploadProposalForm(Controller c, String confName)
        {
            InitializeComponent();
            this.cont = c;
            this.conferenceName = confName;
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborting the selection, Returning to Main Menu.");
            this.Hide();
            AuthorForm f6 = new AuthorForm(cont, conferenceName);
            f6.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upload succesful, Returning to Main Menu.");
            this.Hide();
            AuthorForm f6 = new AuthorForm(cont, conferenceName);
            f6.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                textBox5.Text = ofd.SafeFileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = ofd.SafeFileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedIndex>=0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex >= 0)
            {
                this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.listBox3.SelectedIndex >= 0)
            {
                this.listBox3.Items.RemoveAt(this.listBox3.SelectedIndex);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(this.textBox2.Text!="")
            {
                listBox1.Items.Add(this.textBox2.Text);
                this.textBox2.Focus();
                this.textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a topic to add","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text != "")
            {
                listBox2.Items.Add(this.textBox3.Text);
                this.textBox3.Focus();
                this.textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a keyword to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox3.Focus();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text != "")
            {
                listBox3.Items.Add(this.textBox4.Text);
                this.textBox4.Focus();
                this.textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an author to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox4.Focus();
            }
        }
    }
}
