using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        // You may (if want) change ``Student[]'' to ``List<Student>''
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill data inside array of Student
        }

        static void RunMenu(Student[] studs)
        // You may (if want) change ``Student[]'' to ``List<Student>''
        {
            // TODO   implement this method
            // It should call method(s) for specific variant(s).
            // Array (or List) studs should already contain data (probably filled with ReadData method)
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            RunMenu(studs);
        }
    }
}
