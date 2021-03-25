using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;
using westga_emr.Model.DTO;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Person DAL and Model
    /// </summary>
    public class PersonController
    {
        private UserDTO currentUser;
        private PersonDAL personDBSource;
        public PersonController()
        {
            this.personDBSource = new PersonDAL();
        }
        /// <see cref="PersonDAL.GetPersons"/>
        public List<Person> GetPersons()
        {
            return PersonDAL.GetPersons();
        }

        /// <see cref="PersonDAL.GetPersonByPatientID(Patient)"/>
        public Person GetPersonByPatientID(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException("patient cannot be null");
            }
            return PersonDAL.GetPersonByPatientID(patient);
        }

        /// <see cref="PersonDAL.GetPersonByDoctorID(Doctor)"/>
        public Person GetPersonByDoctorID(Doctor doctor)
        {
            if (doctor == null)
            {
                throw new ArgumentNullException("doctor cannot be null");
            }
            return PersonDAL.GetPersonByDoctorID(doctor);
        }

        /// <summary>
        /// Sign In method to authenticate User
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>The signed in user</returns>
        public UserDTO SignIn(string username, string password)
        {
            if (!personDBSource.UserExist(username))
            {
                throw new Exception();
            }
            currentUser =  personDBSource.SignIn(username, password);
            return currentUser;
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

        /// <summary>
        /// Method to get current user of the application
        /// </summary>
        /// <returns></returns>
        public UserDTO GetCurrentUser()
        {
            return this.currentUser;
        }

        /// <summary>
        /// Signs out the current user from the aspplication
        /// </summary>
        public void SignOutUser()
        {
            this.currentUser = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public UserDTO SearchPatient(string firstName, string lastName, DateTime dateOfBirth)
        {
            return personDBSource.SearchPatient(firstName, lastName, dateOfBirth);
        }
    }
}
