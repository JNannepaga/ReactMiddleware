using System;

namespace SchoolManagement.Data.Models 
{ 
    public class Teacher : Person
    {
        public int TeacherId { get; set; }
        public int Subject { get; set; }
        
        public override string ToString()
        {
            return string.Format($"Teacher ID = ${this.TeacherId}\nName = ${this.FullName}");
        }
    }
}
