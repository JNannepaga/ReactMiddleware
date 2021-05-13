using System;

namespace SchoolManagement.Repository.Entities
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
