using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objectStudent = new Student();
            objectStudent.SetName("Lisa Simpson");
            Console.WriteLine("Hello "+objectStudent.GetName());

            Teacher objectTeacher=new Teacher();
            objectTeacher.Name = "Bill Jones";
            Console.WriteLine("Your teacher is " + objectTeacher.Name);
        }
    }
}
