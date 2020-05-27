using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    //inheretance-miras almaq
    class Developer:Person
    {
        public string Position;
        public int Experience;
        public Developer(string name,string surname,int age,string pos,int exp):base(name,surname,age)
        {
            Position = pos;
            Experience = exp;
        }

        //polymorphithm
        public override string Info()
        {
            return $"{base.Info()} - position:{Position}, exprerience:{Experience}";
        }
    }

    class Test { }
}
