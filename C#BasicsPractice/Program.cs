using System.Security.Cryptography.X509Certificates;

namespace C_BasicsPractice
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();

            students.Add(new Student(1, "onkar", "abcSchool", "A"));
            students.Add(new Student(2, "person2", "abcSchool", "B"));
            students.Add(new Student(6, "person6", "hijSchool", "B"));
            students.Add(new Student(7, "person7", "hijSchool", "C"));
            students.Add(new Student(8, "person8", "klmSchool", "A"));
            students.Add(new Student(9, "person9", "klmSchool", "B"));
            students.Add(new Student(7, "person7", "klmSchool", "C"));

            List<Student> studentsInDescendingOrder = students.OrderByDescending(student => student.Id).ToList();
            
            //overrided tostring method and gave custom behaviour
            //calling extended method to capitalise first letter of data
            Console.WriteLine("!!!Student info in first letter capital format!!!!!");
            foreach (Student student in studentsInDescendingOrder)
            {
                var studentInfo = student.ToString().CapitalizedString();
                Console.WriteLine(studentInfo);
            }

            Console.ReadLine();
        }

       
    }

    
}
