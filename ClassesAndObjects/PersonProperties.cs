using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    public class PersonProperties
    {
        public DateTime Birthdate{ get; set; }

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
