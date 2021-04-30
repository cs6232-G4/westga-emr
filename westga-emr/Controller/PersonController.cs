using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System;
using westga_emr.Model.DTO;
using westga_emr.Helpers;
using System.Transactions;

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
            if (patient == null || patient.ID == null)
            {
                throw new ArgumentNullException("patient and its id cannot be null");
            }
            return PersonDAL.GetPersonByPatientID(patient);
        }

        /// <see cref="PersonDAL.GetPersonByDoctorID(Doctor)"/>
        public Person GetPersonByDoctorID(Doctor doctor)
        {
            if (doctor == null || doctor.ID == null)
            {
                throw new ArgumentNullException("doctor and its id cannot be null");
            }
            return PersonDAL.GetPersonByDoctorID(doctor);
        }

        /// <see cref="PersonDAL.GetPersonByNurseID(Nurse)"/>
        public Person GetPersonByNurseID(Nurse nurse)
        {
            if (nurse == null || nurse.ID == null)
            {
                throw new ArgumentNullException("nurse and its id cannot be null");
            }
            return PersonDAL.GetPersonByNurseID(nurse);
        }

        /// <see cref="PersonDAL.GetPersonByClinicalAdministratorID(Clinical_Administrator)"/>
        public Person GetPersonByClinicalAdministratorID(Clinical_Administrator admin)
        {
            if (admin == null || admin.ID == null)
            {
                throw new ArgumentNullException("admin and its id cannot be null");
            }
            return PersonDAL.GetPersonByClinicalAdministratorID(admin);
        }

        /// <see cref="PersonDAL.GetPersonOfDoctorByVisit(Visit)"/>
        public Person GetDoctorByVisitID(Visit visit)
        {
            if (visit == null || visit.ID == null)
            {
                throw new ArgumentNullException("visit and its id cannot be null");
            }
            return PersonDAL.GetPersonOfDoctorByVisit(visit);
        }

        /// <see cref="PersonDAL.GetPersonOfNurseByVisit(Visit)"/>
        public Person GetNurseByVisitID(Visit visit)
        {
            if (visit == null || visit.ID == null)
            {
                throw new ArgumentNullException("visit and its id cannot be null");
            }
            return PersonDAL.GetPersonOfNurseByVisit(visit);
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
            this.currentUser =  personDBSource.SignIn(username, password);
            AuthenticationHelper.SetCurrentUser(this.currentUser);
            return this.currentUser;
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
            this.currentUser = new UserDTO();
            AuthenticationHelper.SetCurrentUser(this.currentUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public List<UserDTO> SearchPatient(string firstName, string lastName, DateTime? dateOfBirth)
        {
            if (dateOfBirth.HasValue)
            {
                return personDBSource.SearchPatient(firstName, lastName, dateOfBirth.Value);
            } else
            {
                return personDBSource.SearchPatient(firstName, lastName, null);
            }
            
        }

        /// <summary>
        /// Checks if social security exists
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool SocialSecurityExist(string ssn)
        {
            return personDBSource.SocialSecurityExist(ssn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsUsernameDuplicate(string username)
        {
            return personDBSource.UserExist(username);
        }

        /// <summary>
        /// Gets number of password hashed
        /// </summary>
        /// <returns></returns>
        public int PasswordsHashed()
        {
            return PersonDAL.HashDBPasswords();
        }
    }
}
