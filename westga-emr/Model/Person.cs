using System;
using System.Linq;

namespace westga_emr.Model
{
	/// <summary>
	/// Models a Person in the WestGA-EMR database
	/// </summary>
	public class Person
	{
		public int? ID { get; }
		public string Username { get; }
		public string Password { get; }
		public string FirstName { get; }
		public string LastName { get; }
		public DateTime DateOfBirth { get; }
		public string SSN { get; }
		public string Gender { get; }
		public int? AddressID { get; }
		public string ContactPhone { get; }

		/// <summary>
		/// Constructs a Person according to the given parameters
		/// </summary>
		/// <param name="id_">Sql Server's id of the Person</param>
		/// <param name="username_">Person's login username</param>
		/// <param name="password_">Person's login password</param>
		/// <param name="firstName_">Person's first name</param>
		/// <param name="lastName_">Person's family name</param>
		/// <param name="dateOfBirth_">Person's date of birth</param>
		/// <param name="ssn_">Person's social security number</param>
		/// <param name="gender_">Person's gender</param>
		/// <param name="addressID_">Sql Server's id of the address of the Person</param>
		/// <param name="contactPhone_">Person's contact phone number</param>
		public Person(int? id_, string username_, string password_, string firstName_, string lastName_, DateTime dateOfBirth_, string ssn_, string gender_, int? addressID_, string contactPhone_)
		{
			if (id_ < 1 || addressID_ < 1)
			{
				throw new ArgumentException("id and addressID cannot be zero or negative");
			}
			if (string.IsNullOrWhiteSpace(firstName_) || string.IsNullOrWhiteSpace(lastName_)
				|| string.IsNullOrWhiteSpace(gender_) || string.IsNullOrWhiteSpace(contactPhone_))
            {
				throw new ArgumentException("first name, last name, gender, and contact phone cannot be " +
					"null, empty, or consist only of white space");
            }
			if (dateOfBirth_ == null)
            {
				throw new ArgumentNullException("dateOfBirth cannot be null");
            }
			if (contactPhone_.Length != 10 || !contactPhone_.All(char.IsDigit))
            {
				throw new ArgumentException("contact phone must be 10 characters in length and consist only of numbers");
            }
			if (string.IsNullOrWhiteSpace(ssn_))
            {
				ssn_ = null;
            }
			if (ssn_ != null && !(ssn_.Length == 9 && ssn_.All(char.IsDigit)))
            {
				throw new ArgumentException("If an ssn exists, it must be 9 characters in length and consist only of numbers");
            }
			this.ID = id_;
			this.Username = username_;
			this.Password = password_;
			this.FirstName = firstName_;
			this.LastName = lastName_;
			this.DateOfBirth = dateOfBirth_;
			this.SSN = ssn_;
			this.Gender = gender_;
			this.AddressID = addressID_;
			this.ContactPhone = contactPhone_;
		}
	}
}
