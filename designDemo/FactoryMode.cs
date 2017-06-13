using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designMode
{
    /*抽象工厂
     多态的运用*/
    public abstract class country
    {
        public abstract void Print();

    }
    public interface water
    {
        void Print();
    }
    public abstract class FactoryMode
    {
        public abstract country GetCountry();
        public abstract water GetWater();
    }

    public class ChinaFactory:FactoryMode
    {
        public override country GetCountry()
        {
            return new China();  
        }
        public override water GetWater()
        {
            return new GuiLin();
        }
    }
    public class China:country,water
    {
        public override void Print()
        {
            Console.WriteLine((this as water).ToString());
            throw new NotImplementedException();
        }
    }
    public class GuiLin:water
    {
        public void Print()
        { }
    }

}
