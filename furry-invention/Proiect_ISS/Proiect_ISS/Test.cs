using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ISS
{
    class Test
    {
        private String connectionString = @"Data Source=REMUS; Integrated Security=true";
        private int id;
        public Test()
        {
            id = 8;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("CREATE DATABASE Conference" + id, con))
                        command.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            createConference();
        }
        private void createConference()
        {
            String cString = @"Data Source=REMUS; Initial Catalog=Conference"+id+"; Integrated Security=true";
            MessageBox.Show(cString);
            using (SqlConnection con = new SqlConnection(cString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("CREATE TABLE P2(ID INT PRIMARY KEY)", con))
                       command.ExecuteNonQuery();
                    MessageBox.Show("am creat");
                    con.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
