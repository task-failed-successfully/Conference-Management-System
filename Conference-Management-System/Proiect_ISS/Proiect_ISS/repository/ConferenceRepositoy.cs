using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ISS.repository
{
    public class ConferenceRepository : Repository
    {
        private string CONNECTION_STRING= @"Data Source=REMUS; Integrated Security=true";

        public void createConference(String name)
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("CREATE DATABASE " + name, con))
                    command.ExecuteNonQuery();
                createTables(con, name);
                con.Close();
            }
        }

        public void createTables(SqlConnection con, String name)
        {
            using (SqlCommand command = new SqlCommand("USE " + name + " " +
                "CREATE TABLE Proposal( ID INT PRIMARY KEY IDENTITY(1,1), abstract VARCHAR(8000), paper VARCHAR(8000))" +
                "CREATE TABLE Keyword(ID INT PRIMARY KEY IDENTITY(1, 1), name VARCHAR(30))" +
                "CREATE TABLE ProposalKeyword(PID INT FOREIGN KEY REFERENCES Proposal(ID), KID INT FOREIGN KEY REFERENCES Keyword(ID), PRIMARY KEY(PID, KID))" +
                "CREATE TABLE Topic(ID INT PRIMARY KEY IDENTITY(1, 1), name VARCHAR(30))" +
                "CREATE TABLE ProposalTopic(PID INT FOREIGN KEY REFERENCES Proposal(ID), TID INT FOREIGN KEY REFERENCES Topic(ID), PRIMARY KEY(PID, TID))" +
                "CREATE TABLE Account(ID INT PRIMARY KEY IDENTITY(1, 1), username VARCHAR(30), password VARCHAR(30), name VARCHAR(50), affiliation VARCHAR(30), email VARCHAR(50), rank INT)" +
                "CREATE TABLE Review(AID INT FOREIGN KEY REFERENCES Account(ID), PID INT FOREIGN KEY REFERENCES Proposal(ID), score INT, description VARCHAR(8000), PRIMARY KEY(AID, PID))" +
                "CREATE TABLE ProposalAccount(PID INT FOREIGN KEY REFERENCES Proposal(ID), AID INT FOREIGN KEY REFERENCES Account(ID), uploader INT NOT NULL, PRIMARY KEY(AID, PID))" +
                "CREATE TABLE Section(ID INT PRIMARY KEY IDENTITY(1, 1), name VARCHAR(50), chair INT FOREIGN KEY REFERENCES Account(ID))" +
                "CREATE TABLE AccountSection(SID INT FOREIGN KEY REFERENCES Section(ID), AID INT FOREIGN KEY REFERENCES Account(ID), speaker BIT, PRIMARY KEY(SID, AID))" +
                "CREATE TABLE Deadline(ID INT PRIMARY KEY IDENTITY(1, 1), name VARCHAR(50), date DATE)"
                , con))

                command.ExecuteNonQuery();
        }
    }
}
