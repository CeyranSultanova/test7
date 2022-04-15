using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    class Student
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        private string surname;
        public string SurName {
            get { return surname; }
            set { surname = value; }
        }
        private int age;
        public int Age {
            get { return age; }
            set { age = value; }
        }



        public Student(string name ,string surname, int age)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;

        }
        //public int Mark
        //{
        //    get { return Mark; }
        //    set
        //    {
        //        if (value > 0 && value < 100)
        //        {
        //            value = Mark;
        //        }
        //        else
        //            Mark = 0;

        //    }
        //}
        public string FullInfo()
        {
            return $" Name {name}, Surname {surname}, Age {age}";
        }

      
        
    }
}
