using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__ListView__and_all_other_Skills_
{
    public class Student//This here is the student class
    {
        string Name;

        double Grade1;

        double Grade2;
        //fields

        public Student(string name, double grade1, double grade2)
        {
            Name = name;
            Grade1 = grade1;
            Grade2 = grade2;
        }//constuctors

      

        public string Name1 { get => Name; set => Name = value; }
        public double Grade11 { get => Grade1; set => Grade1 = value; }
        public double Grade21 { get => Grade2; set => Grade2 = value; }


        //in order to compute the average you need to make grade1 and 2 a double in order to perform the math correctly
        public double getAverageGrade()
        {
            return (Grade1 + Grade2) / 2;
        }
    }
}
