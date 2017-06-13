using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designMode
{
    /// <summary>
    /// 桥接模式即将抽象部分与实现部分脱耦，使它们可以独立变化
    /// </summary>
    class 桥接模式
    {
    }
    public class ReomoteControl
    {
        private TV implementor;
        public TV Implementor
        {
            get { return implementor; }
            set { implementor = value; }
        }
        public virtual void On()
        { implementor.On(); }

        public virtual void Off()
        { implementor.Off(); }

        public void ChangeChannel()
        { implementor.ChangeChannel(); }

    }
    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void ChangeChannel();
    }

    //public class Chanhong:TV
    //{ }
}
