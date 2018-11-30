﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Models
{
    public class PersonalModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
