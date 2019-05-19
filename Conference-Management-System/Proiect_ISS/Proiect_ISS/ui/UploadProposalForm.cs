using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        String abstractText;
        String paperText;


        public UploadProposalForm(Controller c, String confName)
        {
            InitializeComponent();
            this.cont = c;
            this.conferenceName = confName;
            this.textBox1.Text = confName;

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;

            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;

            button7.TabStop = false;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;

            button8.TabStop = false;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;

            button9.TabStop = false;
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 0;

            button10.TabStop = false;
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 0;
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
            try
            {
                cont.addProposal(abstractText,
                    paperText,
                    this.listBox1.Items.OfType<string>().ToArray(),
                    this.listBox2.Items.OfType<string>().ToArray(),
                    this.listBox3.Items.OfType<string>().ToArray(),
                    conferenceName
                    );
                MessageBox.Show("Upload succesful, Returning to Main Menu.");

                this.Hide();
                AuthorForm f6 = new AuthorForm(cont, conferenceName);
                f6.ShowDialog();
                this.Close();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }


            paperText = fileContent;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                    

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            abstractText = fileContent;            
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

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
