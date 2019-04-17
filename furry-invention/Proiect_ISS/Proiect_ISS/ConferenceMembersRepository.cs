using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ISS
{
    class ConferenceMembersRepository : Repository<Account, String>
    {
        private Dictionary<String, Account> data;
        private String connetionString = @"Data Source=REMUS; Initial Catalog=ISS; Integrated Security=true";

        public ConferenceMembersRepository()
        {
            data = new Dictionary<string, Account>();
            SqlConnection cnn;
            
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            String SQL = "SELECT * FROM ConferenceMember";

            SqlCommand Cmd = new SqlCommand(SQL, cnn);

            using (SqlDataReader oReader = Cmd.ExecuteReader())
            {
                while(oReader.Read())
                {
                    String username = oReader["username"].ToString().Replace(" ",string.Empty);
                    String password = oReader["password"].ToString().Replace(" ", string.Empty);
                    String name = oReader["name"].ToString().Replace(" ", string.Empty);
                    String affiliation = oReader["affiliation"].ToString().Replace(" ", string.Empty);
                    String email = oReader["email"].ToString().Replace(" ", string.Empty);
                    int rank = int.Parse(oReader["rank"].ToString());

                    Account u = new Account(username, password, name, affiliation, email, rank);

                    data.Add(username, u);
                }
                cnn.Close();
            }

            
        }

        public void add(Account e)
        {
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                String SQL = "INSERT INTO ConferenceMember VALUES(@1,@2,@3,@4,@5,@6)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.Parameters.AddWithValue("@1", e.username);
                    cmd.Parameters.AddWithValue("@2", e.password);
                    cmd.Parameters.AddWithValue("@3", e.name);
                    cmd.Parameters.AddWithValue("@4", e.affiliation);
                    cmd.Parameters.AddWithValue("@5", e.email);
                    cmd.Parameters.AddWithValue("@6", e.rank);
                    cmd.ExecuteNonQuery();

                    data.Add(e.username, e);
                }
                cnn.Close();
            }
        }

        public void remove(String e)
        {

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                String SQL = "DELETE FROM ConferenceMember WHERE username=@1";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.Parameters.AddWithValue("@1", e);
                    cmd.ExecuteNonQuery();

                    data.Remove(e);
                }
                cnn.Close();
            }
        }

        public void update(Account e)
        {
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                String SQL = "UPDATE ConferenceMember SET password=@2, name=@3, affiliation=@4, email=@5, rank=@6 WHERE username=@1";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.Parameters.AddWithValue("@1", e.username);
                    cmd.Parameters.AddWithValue("@2", e.password);
                    cmd.Parameters.AddWithValue("@3", e.name);
                    cmd.Parameters.AddWithValue("@4", e.affiliation);
                    cmd.Parameters.AddWithValue("@5", e.email);
                    cmd.Parameters.AddWithValue("@6", e.rank);
                    cmd.ExecuteNonQuery();

                    data.Remove(e.username);
                    data.Add(e.username, e);
                }
                cnn.Close();
            }

            
        }

        public Account find(String e)
        {
            foreach (Account U in data.Values)
            {
                if (U.username == e)
                    return U;
            }
            return null;
        }

        public ICollection<Account> findAll()
        {
            return data.Values;
        }

        public override string ToString()
        {
            String s = "";
            foreach(Account U in data.Values)
            {
                s += U + "\n";
            }
            MessageBox.Show(s);
            return s;
        }   
    }
}
