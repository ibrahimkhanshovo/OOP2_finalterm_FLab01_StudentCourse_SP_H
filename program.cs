            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace FinalLab1
    {
        class Program
        {
            static void Main(string[] args)
            {

                Course c1 = new Course("OOP2", "C1123");
                Course c2 = new Course("Webtec", "C1114");

                Student s1 = new Student("Feekra", "18-39010-3", 3.39f);
                Student s2 = new Student("Baishakhi", "18-39010-3", 3.39f);

                s1.AddCourse(c1, c2);
                s2.AddCourse(c1, c2);
                s2.DropCourse(c2);
                c1.EnrollStudent(s1, s2);
                c2.EnrollStudent(s1);
                Console.WriteLine("**Student Information of Course OOP2**");
                c1.StudentInfo();
                Console.WriteLine("**Student Information of course WEBTEC**");
                c2.StudentInfo();
                Console.WriteLine("**Information of course OOP2**");
                c1.ShowInfoCourse();
                Console.WriteLine("**Information of course WEBTEC**");
                c2.ShowInfoCourse();

            }
        }
    }
}
    }
}
