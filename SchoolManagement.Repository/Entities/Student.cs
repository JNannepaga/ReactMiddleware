using System;
using System.Collections.Generic;

namespace SchoolManagement.Repository.Entities
{
    public class Student : Person
    {
        #region Properties
        public int RollId { get; set; }
        public Standard Standard { get; set; }
        
        public ICollection<Teacher> Teachers { get; private set; }
        #endregion

        #region Overloads
        public override string ToString()
        {
            return string.Format($"Roll Number = ${this.RollId}\nName = ${this.FullName}");
        }
        #endregion

        #region Constructors
        public Student()
        {
            this.Teachers = new HashSet<Teacher>();
        }
        #endregion
    }
}
