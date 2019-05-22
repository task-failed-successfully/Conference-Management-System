using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Proiect_ISS.framework;
using System.Windows.Forms;
using System.IO;

namespace Proiect_ISS.repository
{
    public class Repository
    {
        public const int NORMAL_RANK = 1;
        public const int PC_RANK = 2;
        public const int CHAIR_RANK = 3;

        /**
         * Adds element inside database
         * 
         * @param elem Table class object from one of the EF generated classes (ex: Conference - Conferences, Entities - Accounts)
         * @param context One of the EF generated classes
         * @param table Table class from `context`, used as a parameter to generalize add for any tables
         */
        public void add(Object elem, DbContext context, DbSet table)
        {
            table.Add(elem);
            context.SaveChanges();
        }

        public void remove(int id, DbContext context, DbSet table)
        {
            table.Remove(id);
            context.SaveChanges();
        }

        public virtual void update(int id, Object elem, DbContext context, DbSet table)
        {
            
        }

        public Object find(int id, DbSet table)
        {
            return table.Find(id);
        }

        /*
         * Searches in the Account table for a record with the username equal
         * to a given parameter.
         * IN: string, DbSet
         * OUT: Object
         * ce returneaza daca nu e gasit?
         */
        public Object findByName(string name, DbSet table)
        {
            foreach(Object o in table.Local)
            {
                Account a = (Account) o;

                if (a.name == name)
                {
                    return a;
                }
            }
            //return null;
            return table.Cast<Account>().FirstOrDefault(e => e.name == name).ID;
        }

        public void updateProposal(int fileType, String newData, DbContext context, DbSet table)
        {
            // 1->abstract
            // 2->paper

            Proposal proposal = (Proposal)table.Find(1);
            if (fileType == 1)
                proposal.@abstract = newData;
            if (fileType == 2)
                proposal.paper = newData;

            context.SaveChanges();
        }

        public void updateDeadline(int position, DateTime newDate, DbContext context, DbSet table)
        {
            Deadline deadline = (Deadline)table.Find(position);
            deadline.date = newDate;
            context.SaveChanges();
        }

    }
}
