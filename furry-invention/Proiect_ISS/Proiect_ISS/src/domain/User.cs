using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ISS
{
    class User
    {
        private String username;
        private String password;
        private String name;
        private String affiliation;
        private String email;
        private int rank;
    
        public User(String u, String p, String n, String a, String e, int r)
        {
            username = u;
            password = p;
            name = n;
            affiliation = a;
            email = e;
            rank = r;
        }

        public String Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public String Affiliation
        {
            get
            {
                return affiliation;
            }
            set
            {
                affiliation = value;
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Rank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }

        public override String ToString()
        {
            String r = "";
            
            switch (rank)
            {
                case 0:
                    r = "Spectator";
                    break;
                case 1:
                    r = "Author";
                    break;
                case 2:
                    r = "Reviewer";
                    break;
                case 3:
                    r = "Author & Reviewer";
                    break;
                case 4:
                    r = "Admin";
                    break;
            }

            return r + ": " + name + "; (" + username + "); " + affiliation + "; " + email;
        }
        
    }
}
