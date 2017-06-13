using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designMode
{
    /*
    对象适配器模式： 维护字段，调用字段方法
    类适配器模式： 继承接口


    */
    class AdapterMode
    {
    }
    public abstract class threeHole
    {
        public abstract void request();
        
    }
    public class twohole
    {
        public void specificRequest()
        {
            Console.WriteLine("。。。");
        }
    }

    public class PowerAdapter:threeHole
    {
        private twohole specificHole; 
        public override void request()
        {
            specificHole.specificRequest();
        }
    }

}
