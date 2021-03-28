            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace FinalLab1
    {
        class Course
        {
            public string CourseName { get; set; }
            public string CourseCode { get; set; }
            Student[] students;
            public int TotalStudent { get; set; }
            public Course()
            {

            }
            public Course(string coursename, string coursecode)
            {
                CourseName = coursename;
                CourseCode = coursecode;
                students = new Student[30];
            }
            public void EnrollStudent(params Student[] students)
            {
                foreach (var e in students)
                {
                    this.students[TotalStudent++] = e;
                }
            }

            virtual public void StudentInfo()
            {

                for (int i = 0; i < TotalStudent; i++)
                {
                    students[i].ShowInfo();
                }
            }

            virtual public void ShowInfoCourse()
            {
                Console.WriteLine("Course Name: " + CourseName);
                Console.WriteLine("Total  students: " + TotalStudent);

            }
        }
    }
}
    }
}
