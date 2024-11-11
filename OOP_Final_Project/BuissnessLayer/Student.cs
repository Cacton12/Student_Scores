using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Project
{
    public class Student : Person,ICloneable
    {
        public List<int> Scores;
        public Student(string first_Name, string last_Name, List<int> scores) : base(first_Name, last_Name)
        {
            Scores = scores;
        }

        public int scoresTotal()
        {
            if (Scores.Count > 0)
            {
                return Scores.Sum();
            }
            else
            {
                return 0;
            }
        }
        public int scoresAverage()
        {   
            if (Scores.Count > 0)
            {
                return (int)Scores.Average();
            }
            else
            {
                return 0;
            }
        }
        public override string ToString() //needed to display the student in lstStudent
        {
            return $"{First_Name} {Last_Name}|{string.Join("|", Scores)}";
        }

        public object Clone()
        {
            Student clonedStudent = new Student(First_Name, Last_Name, new List<int>(Scores));
            return clonedStudent;
        }
    }
}
