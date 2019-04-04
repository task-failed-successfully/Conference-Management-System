using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ISS.src.domain.validators
{
    interface Validator<T>
    {
        void validate(T entity);
    }
}
