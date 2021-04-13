using System;
using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using System.Data.SqlClient;
using System.Transactions;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Patient DAL and Model
    /// </summary>
    public class PatientController
    {

        /// <see cref="PatientDAL.GetAllActivePatients"/>
        public List<Person> GetAllActivePatients()
        {
            return PatientDAL.GetAllActivePatients();
        }

        /// <see cref="PatientDAL.GetActivePatientsByFirstAndLastName(string, string)"/>
        public List<Person> GetActivePatientsByFirstAndLastName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("first name and last name cannot be null, empty, or consist only of white space");
            }
            return PatientDAL.GetActivePatientsByFirstAndLastName(firstName, lastName);
        }

        /// <see cref="PatientDAL.GetActivePatientsByDoB(DateTime)"/>
        public List<Person> GetActivePatientsByDoB(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("date of birth cannot be null");
            }
            return PatientDAL.GetActivePatientsByDoB(dateOfBirth);
        }

        /// <see cref="PatientDAL.GetActivePatientsByDoBAndLastName(string, DateTime)"/>
        public List<Person> GetActivePatientsByDoBAndLastName(string lastName, DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("last name cannot be null, empty, or consist only of white space");
            }
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("date of birth cannot be null");
            }
            return PatientDAL.GetActivePatientsByDoBAndLastName(lastName, dateOfBirth);
        }

        /// <summary>
        /// Inserts a new Patient with their data into the db.
        /// </summary>
        /// <param name="patient">Person of Patient to insert</param>
        /// <param name="address">Address of Patient to insert</param>
        /// <returns>Whether or not the insertion succeeded</returns>
        public bool RegisterPatient(Person patient, Address address)
        {
            if (patient == null || address == null) {
                throw new ArgumentNullException("patient and address cannot be null");
            }
            if (patient.Username != null || patient.Password != null)
            {
                throw new ArgumentNullException("username and password of a patient should be null");
            }
            using (TransactionScope scope = new TransactionScope())
            {
                int? addressID = AddressDAL.InsertAddress(address);
                int? personID = PersonDAL.InsertPerson(new Person(null, null, null, patient.FirstName, patient.LastName, patient.DateOfBirth,
                    patient.SSN, patient.Gender, addressID, patient.ContactPhone));
                PatientDAL.InsertPatient(new Patient(null, personID, true));
                scope.Complete();
            }
            return true;
        }

        /// <summary>
        /// Updates a Patient's various records in the db
        /// </summary>
        /// <param name="person">Person of the patient to update</param>
        /// <param name="address">Address of the patient to update</param>
        /// <param name="patient">Patient to update</param>
        /// <returns></returns>
        public bool UpdatePatient(Person person, Address address, Patient patient)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                AddressDAL.UpdateAddress(address);
                PersonDAL.UpdatePerson(person);
                PatientDAL.UpdatePatient(patient);
                scope.Complete();
            }
            return true;
        }
    }
}
