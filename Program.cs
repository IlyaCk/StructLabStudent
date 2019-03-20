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
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
        }

        static void runMenu(Student[] studs)
        {
            // TODO   implement this method
            // It should call method(s) for concrete variant(s)
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
