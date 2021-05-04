using System.Collections.Generic;
using westga_emr.Model;
using westga_emr.DAL;
using westga_emr.Model.DTO;
using westga_emr.Helpers;
using System;
using System.Transactions;

namespace westga_emr.Controller
{
    /// <summary>
    /// Controller for Nurse DAL and Model
    /// </summary>
    public class NurseController
    {
        /// <see cref="NurseDAL.GetNurses"/>
        public List<Nurse> GetNurses()
        {
            return NurseDAL.GetNurses();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<UserDTO> GetAllNurse()
        {
            return NurseDAL.GetAllNurse(AuthenticationHelper.currentUser);
        }

        /// <summary>
        /// Inserts a new Patient with their data into the db.
        /// </summary>
        /// <param name="patient">Person of Patient to insert</param>
        /// <param name="address">Address of Patient to insert</param>
        /// <returns>Whether or not the insertion succeeded</returns>
        public bool RegisterNurse(Person nurse, Address address)
        {
            if (nurse == null || address == null)
            {
                throw new ArgumentNullException("nurse and address cannot be null");
            }
            using (TransactionScope scope = new TransactionScope())
            {

                int? addressID = AddressDAL.InsertAddress(address);
                int? personID = PersonDAL.InsertPerson(new Person(null, nurse.Username, nurse.Password, nurse.FirstName, nurse.LastName, nurse.DateOfBirth,
                    nurse.SSN, nurse.Gender, addressID, nurse.ContactPhone));
                NurseDAL.InsertNurse(new Nurse(null, personID, true));
                scope.Complete();
            }
            return true;
        }

        /// <summary>
        /// Updates the given Nurse and their information in the db
        /// </summary>
        /// <param name="person">The Person of the Nurse to update</param>
        /// <param name="address">The Address of the Nurse to update</param>
        /// <param name="nurse">The Nurse to update</param>
        /// <returns>Whether or not the update succeeded</returns>
        public bool UpdateNurse(Person person, Address address, Nurse nurse)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                AddressDAL.UpdateAddress(address);
                PersonDAL.UpdatePerson(person);
                NurseDAL.UpdateNurse(nurse);
                scope.Complete();
            }
            return true;
        }

        /// <see cref="NurseDAL.IsThisNurseTheNurseOfTheVisit(UserDTO, VisitDTO)"/>
        public bool IsThisNurseTheNurseOfTheVisit(UserDTO currentUser, VisitDTO visit)
        {
            if (currentUser == null || visit == null || visit.ID == null)
            {
                throw new ArgumentNullException("currentUser, visit, and visitID cannot be null");
            }
            return NurseDAL.IsThisNurseTheNurseOfTheVisit(currentUser, visit);
        }
    }
}
