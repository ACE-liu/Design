using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designDemo
{
    class 观察者模式
    {
    }
    public interface Observer
    {
        void ReceiveAndPrint(string Message);
    }
    public class GameObserver : Observer
    {
        public void ReceiveAndPrint(string Message)
        {

        }
    }
    public abstract class DingYue
    {
        public List<Observer> ObList = null;
        public string item { get; set; }

        public string symbol { get; set; }
        //public DingYue()

        public DingYue(string name, string symbol)
        {
            this.item = name;
            this.symbol = symbol;
        }
        public void UpDate(string Message)
        {
            if (ObList != null)
            {
                foreach (var item in ObList)
                {
                    item.ReceiveAndPrint(Message);

                }
            }
        }
    }
}
