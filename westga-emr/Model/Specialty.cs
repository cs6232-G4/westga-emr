using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models a Specialty in the WestGA-EMR database
	/// </summary>
	public class Specialty
	{
		public string Name { get; }

		/// <summary>
		/// Creates a Specialty with the given name
		/// </summary>
		/// <param name="name_">Name of the Specialty</param>
		public Specialty(string name_)
		{
			if (string.IsNullOrWhiteSpace(name_))
            {
				throw new ArgumentException("name cannot be null, empty, or consist only of white space");
            }
			this.Name = name_;
		}
	}
}
