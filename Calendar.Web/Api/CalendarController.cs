using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calendar.Web.Api
{
    public class EveryNdayssParameter
    {
        public DateTime Start { get; set; }
        public DateTime Finish {get; set; }
        public int DaysInterval { get; set; }
    }
    
    public class CalendarController : ApiController
    {
        //daily, every weekday
        public List<DateTime> GetExpanderDaily() 
        {
           // var alarm = new DateTime(2015, 06, 08);
          //  var x = new List<DateTime>();
         //   x.Add(alarm);
          //  return x;
        var everyday = new List<DateTime>();
        everyday.Add(DateTime.Now);
        everyday.Add(DateTime.Now.AddDays(10));
        return everyday;
        }

        public List<DateTime> Post(EveryNdayssParameter dt)
        {
            List<DateTime> everyday = new List<DateTime>();
            var date = dt.Start;

            while (date < dt.Finish)
            {

                date = date.AddDays(dt.DaysInterval);

                //if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                // {
                everyday.Add(date);

                //  }

            }
            return everyday;

        }
        //public List<DateTime> Post()
        //{

        //    List<DateTime> b = new List<DateTime>();
        //    return b;
        //}
    }
}

       
    

