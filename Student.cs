using System;
using System.Text;
using System.Linq;

namespace struct_lab_student
{
    struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            // TODO   you SHOULD IMPLEMENT constructor with exactly this signature
            // lineWithAllData is string contating all data about one student, as described in statement
        }
    }
}
