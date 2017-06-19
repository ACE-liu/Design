using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designDemo
//{
{ 
//    struct myData
//    {
//        fixed char love[123];
//    }
    class csharpVesion
    {
        char[] data = new char[100];
        List<student> myClassMates = new List<student>();
        
        void get()
        {
            
            var items = from c in
                            from g in myClassMates
                            group g by g.id
                        select new { country = c.Key, name = c.Count() };


        }
        void getId()
        { }
    }
   public class student
    {
        internal int id;
        public string name;
       internal int classId;
    }
}
