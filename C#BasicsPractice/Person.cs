using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicsPractice
{
    public delegate void StudentDetailsDelegate(Student stud);
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
                
        }

        public Person(int id, string name)
        {
                this.Id = id;
                this.Name = name;
        }

        
    }

    public class Student : Person
    {
        public string SchoolName { get; set; }

        public string Division { get; set; }

        public Student()
        {
                
        }

        public Student(int id, string name, string schoolName,string division) : base(id,name)
        {
                this.SchoolName = schoolName;
                this.Division = division;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, SchoolName: {this.SchoolName}, Division: {this.Division}.";
        }
        protected int num;
    }

    public class DelegateMethods
    {
        public static void ShowStudentDetails(Student student)
        {
            Console.WriteLine("----------------------------------\nStudent Details are !!!!");
            Console.WriteLine($"Id : {student.Id}, Name : {student.Name}, School name : {student.SchoolName}, Division : {student.Division}");
        }

        public void CallingShowDetailsMethod(Student student)
        {
            StudentDetailsDelegate studDel = ShowStudentDetails;
            studDel(student);
        }
    }

}
