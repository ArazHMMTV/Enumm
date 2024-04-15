using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        static int _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
