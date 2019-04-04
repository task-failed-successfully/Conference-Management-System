using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ISS.src.domain.validators
{
    class UserValidator : Validator<User>
    {
        /*
         * Validates the fields of a User entity.
         * email must contain '.com'
         * rank must be non null, positive
         */
        public void validate(User e)
        {
            string errors = "";

            if ( !e.Email.Contains(".com") )
                errors += "Email does not contain '.com' !\n";

            if ( e.Rank < 1 )
                errors += "Rank must be positive!\n";

            if (errors.Length != 0)
                //There were errors in validation
                throw new Exception("Error! \n" + errors);        
        }
    }
}
