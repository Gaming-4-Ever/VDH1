using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDH1.Students.Valbon
{
    class Valbon
    {
        public string FullName { get; set; }
        public Valbon(string fullName)
        {
            FullName = fullName;
        }

        Valbon person = new Valbon("Valbon Osmani");
    }
}
