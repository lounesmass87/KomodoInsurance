using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCOS
{
    public class Developer
    {

        public Developer(string name, int idNumber, bool hasPluralsight)
        {
            Name = name;
            IdNumber = idNumber;
            HasPluralsight = hasPluralsight;
        }

        public string Name { get; set; }
        public int IdNumber { get; set; }
        public bool HasPluralsight { get; set; }
    }
}
