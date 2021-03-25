using System;
using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;

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
            return PatientDAL.GetActivePatientsByFirstAndLastName(firstName, lastName);
        }

        /// <see cref="PatientDAL.GetActivePatientsByDoB(DateTime)"/>
        public List<Person> GetActivePatientsByDoB(DateTime dateOfBirth)
        {
            return PatientDAL.GetActivePatientsByDoB(dateOfBirth);
        }

        /// <see cref="PatientDAL.GetActivePatientsByDoBAndLastName(string, DateTime)"/>
        public List<Person> GetActivePatientsByDoBAndLastName(string lastName, DateTime dateOfBirth)
        {
            return PatientDAL.GetActivePatientsByDoBAndLastName(lastName, dateOfBirth);
        }

        /// <see cref="PatientDAL.RegisterPatient(Person, Address)"/>
        public bool RegisterPatient(Person patient, Address address)
        {
            if (patient == null || address == null) {
                throw new ArgumentNullException("patient and address cannot be null");
            }
            return PatientDAL.RegisterPatient(patient, address);
        }

        /// <see cref="PatientDAL.UpdatePatient(Person, Address, Patient)"/>
        public bool UpdatePatient(Person patient, Address address, Patient pT)
        {
            return PatientDAL.UpdatePatient(patient, address, pT);
        }
    }
}
