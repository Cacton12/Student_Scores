using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace OOP_Final_Project
{
    public class Validator
    {
        public bool NameValid(string name)
        {
            if (name == null)
            {
                return false;
            }
            string[] nameParts = name.Split([' '], 2);
            if (nameParts.Length >= 2)
            {
                return true;
            }
            return false;
        }
        public bool NewScoresValid(int scores)
        {
            if(scores > 100)
            {
                return false;
            }
            else if(scores < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
