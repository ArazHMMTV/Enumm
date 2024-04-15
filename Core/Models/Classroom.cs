using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        static int _id {  get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }
        public string Limited { get; set; }


        public Classroom(string name,Type type, string limited)
        {
            Name = name;
            _id++;
            Id = _id;
            Type = type;
            Limited = limited;
        }

        public Classroom()
        {
            students= new Student[0];
        }
        Student[] students = new Student[] { };


       
        public void StudentAdd(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }


      

        public Student[] FindId(int id)
        {
            Student[] filteredArray = new Student[] { }; 
            foreach(Student student in students)
            {
                if (student.Id == id)
                {
                    Array.Resize(ref filteredArray, filteredArray.Length + 1);
                    filteredArray[filteredArray.Length - 1] = student;
                }
            }
            return filteredArray;
        }

        public Student[] Delete(int id)
        {
            Student[] filteredArray = new Student[] { };
            foreach (Student student in students)
            {
                if (student.Id != id)
                {

                    Array.Resize(ref filteredArray, filteredArray.Length + 1);
                    filteredArray[filteredArray.Length - 1] = student;
                }
            }
            return filteredArray;
        }
    }
}
