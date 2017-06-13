using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designMode
{

   public abstract class ProtoType
    {
        public string name { get; set; }
        public ProtoType(string name)
        { this.name = name; }
        public abstract ProtoType Clone();
    }

    public class TimePrototype:ProtoType,ICloneable
    {
        public TimePrototype(string name):base(name)
        { }
        public override ProtoType Clone()
        {
            return this.MemberwiseClone() as TimePrototype;
        }
         object ICloneable.Clone()
        { 
            return (this as ICloneable).Clone();
        }
    }
}
