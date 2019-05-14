using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Proiect_ISS.framework;

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

        public void remove(int id)
        {

        }

        public virtual void update(int id, Object elem)
        {

        }

        public Object find(int id)
        {
            throw new Exception("Hey! Implement this!");
        }
    }
}
