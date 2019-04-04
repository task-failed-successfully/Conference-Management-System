using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ISS.src
{
    class Controller
    {
        Repository<User, String> userRepository;

        public void add(String username, String password, String name, String affiliation, String email, int rank)
        {
            User u = new User(username, password, name, affiliation, email, rank);
            //validate u
            userRepository.add(u);

        }

        /*
         * Removes a User from the repository. Finds it after the primary key 'username'.
         * IN: String
         * OUT:-
         */
        public void remove(String username)
        {
            userRepository.remove(username);
        }

        /*
         * Updates a User from the repository. The parameter 'username' targets a specific entity and 
         * the other parameters represent the new fields. Validates the new fields before procceding.
         * IN:
         * OUT:-
         */
        public void update(String username, String password, String name, String affiliation, String email, int rank)
        {
            User u = new User(username, password, name, affiliation, email, rank);
            //validate
            userRepository.update(u);
        }

        /*
         * Checks if a specific User exists after a given username as parameter. Returns the object.
         * IN: String
         * OUT: User
         */
        public User find(String username)
        {
            return userRepository.find(username);
        }

        /*
         * Returns a Collection from the repository with all Users.
         */
        public ICollection<User> findAllUsers()
        {
            return userRepository.findAll();
        }


    }
}
