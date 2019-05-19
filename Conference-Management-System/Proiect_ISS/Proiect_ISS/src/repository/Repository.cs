using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ISS
{
    interface Repository<T, ID>
    {
        void add(T elem);
        void remove(ID id);
        void update(T elem);
        T find(ID id);
        ICollection<T> findAll();
    }
}
