using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proiect_ISS.src.domain.validators;

namespace Proiect_ISS.src
{
    /*
     * Controller consists of more repositories and validators for each entity.
     * It calls functions from repositories and validates fields.
     * GUI code which creates the objects is in Form1's code.
     */
    class Controller
    {
        Repository<User, String> userRepository;
        Validator<User> userValidator;
        
        //Nu prea e util, chiar daca e interface
        //In repository ar trebui verificat daca exista deja

        public Controller(Repository<User, String> userRepository, Validator<User> userValidator)
        {
            this.userRepository = userRepository;
            this.userValidator = userValidator;
        }

        /*
         * Adds a new User in the Repository, after it is created and validated in this method.
         * IN: String, String, String, String, String, int
         * OUT:-
         */
        public void addUser(String username, String password, String name, String affiliation, String email, int rank)
        {
            User u = new User(username, password, name, affiliation, email, rank);
            userValidator.validate(u);
            userRepository.add(u);
        }

        /*
         * Removes a User from the repository. Finds it after the primary key 'username'.
         * IN: String
         * OUT:-
         */
        public void removeUser(String username)
        {
            userRepository.remove(username);
        }

        /*
         * Updates a User from the repository. The parameter 'username' targets a specific entity and 
         * the other parameters represent the new fields. Validates the new fields before procceding.
         * IN: String, String, String, String, String, int
         * OUT:-
         */
        public void updateUser(String username, String password, String name, String affiliation, String email, int rank)
        {
            User u = new User(username, password, name, affiliation, email, rank);
            userValidator.validate(u);
            userRepository.update(u);
        }

        /*
         * Checks if a specific User exists after a given username as parameter. Returns the object.
         * IN: String
         * OUT: User
         */
        public User findUser(String username)
        {
            return userRepository.find(username);
        }

        /*
         * Returns a Collection from the repository with all Users.
         * IN:-
         * OUT: ICollection of User
         */
        public ICollection<User> findAllUsers()
        {
            return userRepository.findAll();
        }
    }
}
