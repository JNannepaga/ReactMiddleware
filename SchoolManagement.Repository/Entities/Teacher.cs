using System;
using System.Collections.Generic;

namespace SchoolManagement.Repository.Entities
{
    public class Teacher : Person
    {
        #region Properties
        public int TeacherId { get; set; }
        public Subject Subject { get; set; }

        public ICollection<Student> Students { get; private set; }
        #endregion

        #region Overloads
        public override string ToString()
        {
            return string.Format($"Teacher ID = ${this.TeacherId}\nName = ${this.FullName}");
        }
        #endregion

        #region Constructors
        public Teacher()
        {
            this.Students = new HashSet<Student>();
        }
        #endregion
    }
}
