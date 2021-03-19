using System;

namespace westga_emr.Model.DTO
{
    /// <summary>
    /// DTO class for UI Data
    /// </summary>
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public int AddressId { get; set; }
        public string Gender { get; set; }
        public string ContactPhone { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
        public int NurseId { get; set; }
        public int AdminId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool IsActiveNurse { get; set; }

        public bool IsActiveAdmin { get; set; }
        public bool IsActiveDoctor { get; set; }
        public bool IsActivePatient { get; set; }
    }
}
