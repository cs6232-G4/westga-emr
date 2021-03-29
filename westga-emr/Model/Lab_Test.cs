using System;

namespace westga_emr.Model
{
	/// <summary>
	/// Models a Lab Test in the WestGA-EMR
	/// </summary>
	public class Lab_Test
	{
		public int? Code { get; }
		public string Name { get; }

		/// <summary>
		/// Constructs a Lab Test according to the given parameters
		/// </summary>
		/// <param name="code_">The code of the Lab Test</param>
		/// <param name="name_">The name of the Lab Test</param>
		public Lab_Test(int code_, string name_)
		{
			if (code_ < 1)
            {
				throw new ArgumentException("code must be greater than zero");
            }
			if (string.IsNullOrWhiteSpace(name_))
            {
				throw new ArgumentException("name cannot be null, empty, or consist only of white space");
            }
			this.Code = code_;
			this.Name = name_;
		}
	}
}
