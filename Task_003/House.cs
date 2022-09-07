using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    internal class House
    {
        public int appartmentsQuontity;
        public Developer name;

        public House Clone()
            => (House)this.MemberwiseClone();
        public House DeepClone()
        {
            House other = (House)this.MemberwiseClone();
            other.appartmentsQuontity = appartmentsQuontity;
            other.name = new Developer(name.name);
            return other;
        }

    }    
}
