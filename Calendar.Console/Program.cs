using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Console
{
  
    class Program
    {
      

        static void Main(string[] args)
        {

            var start = new DateTime(2015, 05, 22);
            var finish = new DateTime(2015, 05, 25);
            var n = start;


            while (n < finish)
            {
                n = n.AddDays(1);
                System.Console.WriteLine(n);
            }
        }
      //  static DataPicker ()
    }
}
