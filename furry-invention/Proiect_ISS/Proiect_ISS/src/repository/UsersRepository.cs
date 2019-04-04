using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ISS
{
    class UsersRepository : Repository<User, String>
    {
        private Dictionary<String, User> data;
        private String connectionString = @"Data Source=desktop-uc392eu\sqlexpress; Initial Catalog=ISS; Integrated Security=true";

        public UsersRepository()
        {
            data = new Dictionary<string, User>();
            SqlConnection cnn;
            
            // Estabilish connection with SQL Server
            cnn = new SqlConnection(connectionString);
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

                    User u = new User(username, password, name, affiliation, email, rank);

                    data.Add(username, u);
                }
                cnn.Close();
            }

            
        }

        public void add(User e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                String SQL = "INSERT INTO ConferenceMember VALUES(@1,@2,@3,@4,@5,@6)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.Parameters.AddWithValue("@1", e.Username);
                    cmd.Parameters.AddWithValue("@2", e.Password);
                    cmd.Parameters.AddWithValue("@3", e.Name);
                    cmd.Parameters.AddWithValue("@4", e.Affiliation);
                    cmd.Parameters.AddWithValue("@5", e.Email);
                    cmd.Parameters.AddWithValue("@6", e.Rank);
                    cmd.ExecuteNonQuery();

                    data.Add(e.Username, e);
                }
                cnn.Close();
            }
        }

        public void remove(String e)
        {

            using (SqlConnection cnn = new SqlConnection(connectionString))
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

        public void update(User e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                String SQL = "UPDATE ConferenceMember SET password=@2, name=@3, affiliation=@4, email=@5, rank=@6 WHERE username=@1";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, cnn))
                {
                    cmd.Parameters.AddWithValue("@1", e.Username);
                    cmd.Parameters.AddWithValue("@2", e.Password);
                    cmd.Parameters.AddWithValue("@3", e.Name);
                    cmd.Parameters.AddWithValue("@4", e.Affiliation);
                    cmd.Parameters.AddWithValue("@5", e.Email);
                    cmd.Parameters.AddWithValue("@6", e.Rank);
                    cmd.ExecuteNonQuery();

                    data.Remove(e.Username);
                    data.Add(e.Username, e);
                }
                cnn.Close();
            }
        }

        public User find(String e)
        {
            foreach (User U in data.Values)
            {
                if (U.Username == e)
                    return U;
            }
            return null;
        }

        public ICollection<User> findAll()
        {
            return data.Values;
        }

        public override string ToString()
        {
            String s = "";
            foreach(User U in data.Values)
            {
                s += U + "\n";
            }
            MessageBox.Show(s);
            return s;
        }   
    }
}
