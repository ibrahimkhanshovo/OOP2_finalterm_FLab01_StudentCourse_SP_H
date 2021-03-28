            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace FinalLab1
    {
        class Student
        {
            public string Name { get; set; }
            public string ID { get; }
            public float Cgpa { get; set; }

            Course[] courses;
            public int CourseCount { get; set; }
            public Student() { }
            public Student(string name, string id, float cgpa)
            {
                Name = name;
                ID = id;
                Cgpa = cgpa;
                courses = new Course[5];
            }
            public void AddCourse(params Course[] courses)
            {
                foreach (var a in courses)
                {
                    this.courses[CourseCount++] = a;
                }
            }
            public void DropCourse(Course c)
            {
                for (int i = 0; i < CourseCount; i++)
                {
                    if (courses[i] == c)
                    {
                        int pos = i;
                        for (i = pos; i < CourseCount - 1; i++)
                        {
                            courses[i] = courses[i + 1];
                        }
                    }
                }
                CourseCount--;
            }

            public void Show()
            {
                for (int i = 0; i < CourseCount; i++)
                {
                    courses[i].ShowInfoCourse();
                }
            }


            virtual public void ShowInfo()
            {
                Console.WriteLine("Name:" + Name);
                Console.WriteLine("ID:" + ID);
                Console.WriteLine("Cgpa:" + Cgpa);

            }

        }
    }
}
    }
}
