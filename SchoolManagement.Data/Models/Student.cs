using System;

namespace SchoolManagement.Data.Models
{
    public class Student : Person
    {
        public int RollId { get; set; }
        public int Standard { get; set; }
        
        public override string ToString()
        {
            return string.Format($"Roll Number = ${this.RollId}\nName = ${this.FullName}");
        }
    }
}
