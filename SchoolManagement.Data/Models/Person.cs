using System;

namespace SchoolManagement.Data.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return string.Format(this.FirstName + " " + this.LastName);
            }
        }
    }
}
