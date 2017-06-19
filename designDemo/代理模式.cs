using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designDemo
{
    class 代理模式
    {
    }
    public abstract class Person
    {
        public abstract void BuyThings();

    }

    public class RealPerson:Person
    {
        public override void BuyThings()
        {
            Console.WriteLine("wo mai dongxi le");
        }
    }


    public class DelegatePerson:Person
    {
        private Person helpPerson = null;
        public override void BuyThings()
        {
            if (helpPerson ==null)
            {
                helpPerson = new RealPerson();
            }
            ///...

        }
    }
}
