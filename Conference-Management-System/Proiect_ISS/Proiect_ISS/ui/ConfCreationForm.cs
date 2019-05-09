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
using Proiect_ISS.framework;
using Proiect_ISS.ui;

namespace Proiect_ISS
{
    public partial class ConfCreationForm : Form
    {
        Controller cont;

        public ConfCreationForm(Controller c)
        {
            InitializeComponent();
            this.cont = c;
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborting the creation, Returning to Main Menu.");
            this.Hide();
            MainForm f2 = new MainForm(cont);
            f2.ShowDialog();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Conference conference = new Conference()
                {
                    name = nameTB.Text
                };

                validateCreation(conference);
                cont.createConf(nameTB.Text);

                cont.addConference(conference);

                foreach(DataGridViewRow row in accountsTable.Rows)
                {
                    if (row.IsNewRow) continue;

                    int rank;

                    if ((chairButton.Checked && row.Index == 0) || (coChairButton.Checked && row.Index <= 1))
                        rank = 3;
                    else
                        rank = 2;

                    Account account = new Account()
                    {
                        username = row.Cells["Username"].Value.ToString(),
                        password = cont.generatePassword(8),
                        name = row.Cells["FullName"].Value.ToString(),
                        affiliation = row.Cells["Affiliation"].Value.ToString(),
                        email = row.Cells["Email"].Value.ToString(),
                        rank = rank
                    };

                    cont.add(account, Controller.ACCOUNT_IDENTIFIER, nameTB.Text);
                }

                DateTime defaultDeadline = DateTime.Now.AddDays(48);

                addDeadline("Abstract", defaultDeadline);
                addDeadline("Paper", defaultDeadline.AddDays(14));
                addDeadline("Bidding", defaultDeadline.AddDays(14));
                addDeadline("Review", defaultDeadline.AddDays(28));

                MessageBox.Show("Conference created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Hide();
                MainForm f2 = new MainForm(cont);
                f2.ShowDialog();
            }
        }

        private void validateCreation(Conference conference)
        {
            if (chairButton.Checked && accountsTable.RowCount < 1)
                throw new Exception("Not enough accounts! Must have at least 1 account");
            if (coChairButton.Checked && accountsTable.RowCount < 2)
                throw new Exception("Not enough accounts! Must have at least 2 accounts");
            if (nameTB.Text == "") // MIHAI! Schimba if-u cu validate(conference) aici
                throw new Exception("Invalid conference name!");
        }

        private void addDeadline(String dName, DateTime dDate)
        {
            Deadline deadline = new Deadline()
            {
                name = dName,
                date = dDate
            };

            cont.add(deadline, Controller.DEADLINE_IDENTIFIER, nameTB.Text);
        }
    }
}
