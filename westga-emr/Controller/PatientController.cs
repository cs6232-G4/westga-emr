﻿using System.Collections.Generic;
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
    }
}
