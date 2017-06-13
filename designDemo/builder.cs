using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designMode
{
    public abstract class Parts
    {
        public List<string> Steps;
        public abstract void Show();
    }

    public class Computer :Parts
    {
        public override void Show()
        {
            Steps = new List<string>();
            refreshStep();
            foreach (var item in Steps)
            {
                Console.WriteLine(item + "has finished");
            }
           // throw new NotImplementedException();
        }
        public void refreshStep()
        { }
    }
    public abstract class builder
    {
        protected Parts toBulidParts = null;
        public abstract Parts GetTobuild();
        public abstract void Build();
    }
    public  class ComputerBuilder:builder
    {
        public override Parts GetTobuild()
        {
            toBulidParts = new Computer();
            return toBulidParts;
        }
        public override void Build()
        {
            throw new NotImplementedException();
        }
    }

    public class Director
    {
        public void Construct(builder builder) /* 调用builder.*/
        {

        }
    }
}
