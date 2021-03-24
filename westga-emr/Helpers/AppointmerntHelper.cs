using System.Collections.Generic;

namespace westga_emr.Helpers
{
    /// <summary>
    /// Helper class for appointment
    /// </summary>
    public  class AppointmentHelper
    {
        public  string Title { get; set; }
        public  string Value { get; set; }
        /// <summary>
        /// Get states dictionary
        /// </summary>
        /// <returns></returns>
        public static List<AppointmentHelper> GetStates()
        {
            var states = new List<AppointmentHelper>();
            states.Add(new AppointmentHelper() { Value = "AL",Title = "Alabama" });
            states.Add(new AppointmentHelper(){Value = "AK", Title = "Alaska"});
            states.Add(new AppointmentHelper(){Value = "AZ", Title = "Arizona"});
            states.Add(new AppointmentHelper(){Value = "AR", Title = "Arkansas"});
            states.Add(new AppointmentHelper(){Value = "CA", Title = "California"});
            states.Add(new AppointmentHelper(){Value = "CO", Title = "Colorado"});
            states.Add(new AppointmentHelper(){Value = "CT", Title = "Connecticut"});
            states.Add(new AppointmentHelper(){Value = "DE", Title = "Delaware"});
            states.Add(new AppointmentHelper(){Value = "DC", Title = "District of Columbia"});
            states.Add(new AppointmentHelper(){Value = "FL", Title = "Florida"});
            states.Add(new AppointmentHelper(){Value = "GA", Title = "Georgia"});
            states.Add(new AppointmentHelper(){Value = "HI", Title = "Hawaii"});
            states.Add(new AppointmentHelper(){Value = "ID", Title = "Idaho"});
            states.Add(new AppointmentHelper(){Value = "IL", Title = "Illinois"});
            states.Add(new AppointmentHelper(){Value = "IN", Title = "Indiana"});
            states.Add(new AppointmentHelper(){Value = "IA", Title = "Iowa"});
            states.Add(new AppointmentHelper(){Value = "KS", Title = "Kansas"});
            states.Add(new AppointmentHelper(){Value = "KY", Title = "Kentucky"});
            states.Add(new AppointmentHelper(){Value = "LA", Title = "Louisiana"});
            states.Add(new AppointmentHelper(){Value = "ME", Title = "Maine"});
            states.Add(new AppointmentHelper(){Value = "MD", Title = "Maryland"});
            states.Add(new AppointmentHelper(){Value = "MA", Title = "Massachusetts"});
            states.Add(new AppointmentHelper(){Value = "MI", Title = "Michigan"});
            states.Add(new AppointmentHelper(){Value = "MN", Title = "Minnesota"});
            states.Add(new AppointmentHelper(){Value = "MS", Title = "Mississippi"});
            states.Add(new AppointmentHelper(){Value = "MO", Title = "Missouri"});
            states.Add(new AppointmentHelper(){Value = "MT", Title = "Montana"});
            states.Add(new AppointmentHelper(){Value = "NE", Title = "Nebraska"});
            states.Add(new AppointmentHelper(){Value = "NV", Title = "Nevada"});
            states.Add(new AppointmentHelper(){Value = "NH", Title = "New Hampshire"});
            states.Add(new AppointmentHelper(){Value = "NJ", Title = "New Jersey"});
            states.Add(new AppointmentHelper(){Value = "NM", Title = "New Mexico"});
            states.Add(new AppointmentHelper(){Value = "NY", Title = "New York"});
            states.Add(new AppointmentHelper(){Value = "NC", Title = "North Carolina"});
            states.Add(new AppointmentHelper(){Value = "ND", Title = "North Dakota"});
            states.Add(new AppointmentHelper(){Value = "OH", Title = "Ohio"});
            states.Add(new AppointmentHelper(){Value = "OK", Title = "Oklahoma"});
            states.Add(new AppointmentHelper(){Value = "OR", Title = "Oregon"});
            states.Add(new AppointmentHelper(){Value = "PA", Title = "Pennsylvania"});
            states.Add(new AppointmentHelper(){Value = "RI", Title = "Rhode Island"});
            states.Add(new AppointmentHelper(){Value = "SC", Title = "South Carolina"});
            states.Add(new AppointmentHelper(){Value = "SD", Title = "South Dakota"});
            states.Add(new AppointmentHelper(){Value = "TN", Title = "Tennessee"});
            states.Add(new AppointmentHelper(){Value = "TX", Title = "Texas"});
            states.Add(new AppointmentHelper(){Value = "UT", Title = "Utah"});
            states.Add(new AppointmentHelper(){Value = "VT", Title = "Vermont"});
            states.Add(new AppointmentHelper(){Value = "VA", Title = "Virginia"});
            states.Add(new AppointmentHelper(){Value = "WA", Title = "Washington"});
            states.Add(new AppointmentHelper(){Value = "WV", Title = "West Virginia"});
            states.Add(new AppointmentHelper(){Value = "WI", Title = "Wisconsin"});
            states.Add(new AppointmentHelper(){Value = "WY", Title = "Wyoming"});
            return states;

        }

        /// <summary>
        /// Get  gender dictionary
        /// </summary>
        /// <returns></returns>
        public static List<AppointmentHelper> GetGenders()
        {
            var genders = new List<AppointmentHelper>()
            {
                new AppointmentHelper(){Title = "Male", Value = "M"},
                new AppointmentHelper(){Title = "Female", Value = "F"}
            };
            return genders;
        }

        public static List<AppointmentHelper> GetAppointmentTimeslots()
        {
            var timeSlots = new List<AppointmentHelper>()
            {
                new AppointmentHelper(){Title = "08:00:00 AM", Value = "08:00:00"},
                new AppointmentHelper(){Title = "09:00:00 AM", Value = "09:00:00"},
                new AppointmentHelper(){Title = "10:00:00 AM", Value = "10:00:00"},
                new AppointmentHelper(){Title = "11:00:00 AM", Value = "11:00:00"},
                new AppointmentHelper(){Title = "12:00:00 PM", Value = "12:00:00"},
                new AppointmentHelper(){Title = "01:00:00 PM", Value = "13:00:00"},
                new AppointmentHelper(){Title = "02:00:00 PM", Value = "14:00:00"},
                new AppointmentHelper(){Title = "03:00:00 PM", Value = "15:00:00"},
                new AppointmentHelper(){Title = "04:00:00 PM", Value = "16:00:00"},
                new AppointmentHelper(){Title = "05:00:00 PM", Value = "17:00:00"}

            };
            return timeSlots;
        }
    }
}
