using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    partial class Person
    {
        //method
        public string Fullname()
        {
            return $"{Name} {Surname}";
        }
        public virtual string Info()
        {
            return $"{Fullname()} {Age}";
        }
    }
}
