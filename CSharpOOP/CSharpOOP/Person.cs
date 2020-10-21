using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Person
    {
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
