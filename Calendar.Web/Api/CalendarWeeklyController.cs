using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calendar.Web.Api
{
    public class WeeklyDataParameter
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public bool Monday { get; set; }
        public bool Monday { get; set; }
    }
    public class CalendarWeeklyController : ApiController
    {
        public List<DateTime> GetExpanderWeekly()
        {
            var dates = new List<DateTime>();
            return dates;
        }
         public List<DateTime> Post(WeeklyDataParameter dt)
        {
           

                 
             //string [] listofdays = new string [] {Monday, Tuesday, Wednesday, Thusday, Friday, Saturday, Sunday};
            List<DateTime> weeklypickeddays = new List<DateTime>();
            var date = dt.Start;

            while (date < dt.Finish)
            {
                if (DayOfWeek == Monday)
                {
                    
                    weeklypickeddays.Add(date);
                    date = date.AddDays(1);
                }
              if
            }

            return weeklypickeddays;

        }
    }
    }
}
