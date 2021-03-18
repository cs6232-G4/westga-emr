using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Person DAL and Model
    /// </summary>
    public class PersonController
    {
        /// <see cref="PersonDAL.GetPersons"/>
        public List<Person> GetPersons()
        {
            return PersonDAL.GetPersons();
        }

        /// <see cref="PersonDAL.GetPersonByUsernameAndPassword(string, string)"/>
        public Person GetPersonByUsernameAndPassword(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("username and password cannot be null, empty, or consist only of white spaces");
            }
            return PersonDAL.GetPersonByUsernameAndPassword(username, password);
        }
    }
}
