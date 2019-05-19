using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Entity;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Metadata.Edm;
using System.Reflection;

using Proiect_ISS.repository;
using Proiect_ISS.framework;
using System.Windows.Forms;

namespace Proiect_ISS.controller
{
    public class Controller
    {
        public const int ACCOUNT_IDENTIFIER = 1;
        public const int ACCOUNT_SECTION_IDENTIFIER = 2;
        public const int DEADLINE_IDENTIFIER = 3;
        public const int KEYWORD_IDENTIFIER = 4;
        public const int PROPOSAL_IDENTIFIER = 5;
        public const int REVIEW_IDENTIFIER = 6;
        public const int SECTION_IDENTIFIER = 7;
        public const int TOPIC_IDENTIFIER = 8;
        public const int CONFERENCE_IDENTIFIER = 9;

        public const String CONFERENCE_DBNAME = "Conference";

        private readonly Dictionary<int, Repository> repos;

        public Controller(Dictionary<int, Repository> r)
        {
            this.repos = r;
        }

        /**
         * Creates a new database for a conference with name `name`
         */
        public void createConf(String name)
        {
            ConferenceRepository confRepo = (ConferenceRepository)repos[CONFERENCE_IDENTIFIER];
            confRepo.createConference(name);
        }
        
        /**
         * Adds conference inside database, similar with add function
         */
        public void addConference(Conference conf)
        {
            ConferenceHolder context = new ConferenceHolder();
            repos[CONFERENCE_IDENTIFIER].add(conf, context, context.Conferences);
        }

        public Conference getConference(int ID)
        {
            ConferenceHolder context = new ConferenceHolder();
            return (Conference)repos[CONFERENCE_IDENTIFIER].find(ID, context.Conferences);
        }

        /**
         * Chooses the right repository to add an element
         * 
         * @param elem Object from one of the generated table classes, inside Entities (ex Account, Reviews)
         * @param identifier One of the constants from Controller, used as key for finding the right repository
         * @param dbName Used in choosing the right database, should never be empty string!
         * @throws Exception If `catalog` is empty string 
         * (otherwise it will try to add row inside the database used to generate the classes)
         */
        public void add(Object elem, int identifier, String dbName="")
        {
            Entities context = new Entities();
            context.ChangeDatabase(initialCatalog: dbName);
            repos[identifier].add(elem, context, chooseDbSet(identifier, context));
        }

        public void addProposal(String abstractText, String paperText, String[] topics, String[] keywords, String[] authors, String dbName)
        {
            Entities context = new Entities();
            context.ChangeDatabase(initialCatalog: dbName);

            DateTime time = DateTime.Today;


            if(time>=((Deadline)(repos[3].find(1, chooseDbSet(3, context)))).date)
            {
                throw new Exception("Invalid date! Period for submiting is closed!");
            }


            Proposal p = new Proposal();
            p.@abstract = abstractText;
            p.paper = paperText;

            foreach (String s in topics)
            {
                Topic t = new Topic();
                t.name = s;
                p.Topics.Add(t);
            }

            foreach (String s in keywords)
            {
                Keyword k = new Keyword();
                k.name = s;
                p.Keywords.Add(k);
            }

            foreach (String s in authors)
            {
                ProposalAccount a = new ProposalAccount();
                a.AID = (int)repos[1].findByName(s, chooseDbSet(1, context));
                a.PID = 1;

                p.ProposalAccounts.Add(a);
            }

            this.add(p, 5, dbName);
        }

        public void updateDeadlines(DateTime a, DateTime paper, DateTime bidding, DateTime review, String dbName)
        {
            Entities context = new Entities();
            context.ChangeDatabase(initialCatalog: dbName);

            this.repos[3].updateDeadline(1, a, context, chooseDbSet(3, context));
            this.repos[3].updateDeadline(2, paper, context, chooseDbSet(3, context));
            this.repos[3].updateDeadline(3, bidding, context, chooseDbSet(3, context));
            this.repos[3].updateDeadline(4, review, context, chooseDbSet(3, context));
        }

        public void updateAbstract(String text, String dbName)
        {
            Entities context = new Entities();
            context.ChangeDatabase(initialCatalog: dbName);

            DateTime time = DateTime.Today;


            if (time >= ((Deadline)(repos[3].find(1, chooseDbSet(3, context)))).date)
            {
                throw new Exception("Invalid date! Period for submiting is closed!");
            }

            this.repos[5].updateProposal(1, text, context, chooseDbSet(5, context));

        }

        public void updatePaper(String text, String dbName)
        {
            Entities context = new Entities();
            context.ChangeDatabase(initialCatalog: dbName);

            DateTime time = DateTime.Today;


            if (time >= ((Deadline)(repos[3].find(2, chooseDbSet(3, context)))).date)
            {
                throw new Exception("Invalid date! Period for submiting is closed!");
            }

            this.repos[5].updateProposal(2, text, context, chooseDbSet(5, context));
        }

        /**
         * Returns the right table class from `context`
         * 
         * @param identifier One of the constants from Controller, used for finding the right table
         * @param context Used in returning the table from this instance (using new Entities().Table might lead to 
         * unexpected behavior
         * @returns The right table from context
         * @throws Exception If bad identifier was passed (always use the constants from Controller)
         * 
         */
        private DbSet chooseDbSet(int identifier, Entities context)
        {
            switch(identifier)
            {
                case ACCOUNT_IDENTIFIER:
                    return context.Accounts;
                case ACCOUNT_SECTION_IDENTIFIER:
                    return context.AccountSections;
                case DEADLINE_IDENTIFIER:
                    return context.Deadlines;
                case KEYWORD_IDENTIFIER:
                    return context.Keywords;
                case PROPOSAL_IDENTIFIER:
                    return context.Proposals;
                case REVIEW_IDENTIFIER:
                    return context.Reviews;
                case SECTION_IDENTIFIER:
                    return context.Sections;
                case TOPIC_IDENTIFIER:
                    return context.Topics;
                default:
                    throw new Exception("Invalid Identifier!");
            }
        }

        //ToDo: Regenerate Domain, change paper and abstract (and something else?) in VARBINARY(MAX) for uploading pdfs

        public string generatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
