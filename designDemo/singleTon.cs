using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designMode
{
    class singleTon
    {
        /*
        构造私有
        */
        private static singleTon mySingleTon = null;
        private static object lockObject = new object();
        private singleTon()
        { }
        public static singleTon GetInstance()
        {
            if (mySingleTon==null)
            {
                lock (lockObject)
                {
                    if (mySingleTon==null)
                    {
                        mySingleTon = new singleTon();
                    }
                }
            }
            return mySingleTon;
        }
    }
}
