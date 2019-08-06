using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    public class PersonProperties
    {   
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public PersonProperties(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;

                return years;
             }
        }

    }
}
