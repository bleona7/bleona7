using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._1_7.Students
{
    class Student
    {
        static int numberOfStudents = 0;
        private string firstName;
        private string middleName;
        private string lastName;
        private int course;
        private string specialty;
        private string university;
        private string eMail;
        private string phoneNumber;

        public Student(string firstName, string middleName, string lastName, int course, string specialty,
            string university, string eMail, string phoneNumber)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
            numberOfStudents++;
        }

        public Student(string firstName, string lastName)
            : this(firstName, null, lastName, 0, null, null, null, null)
        {
        }

        public Student(string firstName, string lastName, string university)
            : this(firstName, null, lastName, 0, null, university, null, null)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("First Name: " + firstName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Middle Name: " + middleName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Last Name: " + lastName);
            sb.Append(System.Environment.NewLine);
            sb.Append("Course: " + course);
            sb.Append(System.Environment.NewLine);
            sb.Append("Specialty: " + specialty);
            sb.Append(System.Environment.NewLine);
            sb.Append("University: " + university);
            sb.Append(System.Environment.NewLine);
            sb.Append("eMail: " + eMail);
            sb.Append(System.Environment.NewLine);
            sb.Append("Phone Number: " + phoneNumber);


            return sb.ToString();
        }
        public static int NumberOfStudents
        {
            get { return Student.numberOfStudents; }
            set { Student.numberOfStudents = value; }
        }
    }
}
