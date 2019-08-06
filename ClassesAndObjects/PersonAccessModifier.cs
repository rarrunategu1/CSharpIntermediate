using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    //Access Modifiers
    public class PersonAccessModifier
    {
        private DateTime _birthdate;
    
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
