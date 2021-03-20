using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceVirtualMethod
{
    class Mammal
    {
        protected string name;
        public virtual string GetName()
        {
            return "Mammal";
        }
    }
    class Horse : Mammal
    {
        string Name;
        public override string GetName()
        {
            Name = base.name;
            return "Horse";
        }
    }
    class Whale : Mammal
    {
        public override string GetName()
        {
            return "Whale";
        }
    }
    class Human : Mammal
    {
       
    }

    class Delphine : Mammal
    {
        new public string GetName()
        {
            return "I am cool fish";
        }
    }
}
