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
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public int Weekinterval {get;set;}
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
                if (dt.Monday == true)
                {

                    weeklypickeddays.Add(date);
                    date = date.AddDays(1);
                }
                else 
                {
                    date = date.AddDays(1);
                }
                  
              if(dt.Tuesday==true)
              {
                   weeklypickeddays.Add(date);
                    date = date.AddDays(1);
              }
              else
              {
                  date = date.AddDays(1);
              }
              
             
              if(dt.Wednesday==true)
              {
                   weeklypickeddays.Add(date);
                    date = date.AddDays(1);
              }
              else
              {
                  date = date.AddDays(1);
              }
                   

               if(dt.Thursday==true)
               {
                   weeklypickeddays.Add(date);
                    date = date.AddDays(1);
               }
               else
               {
                   date = date.AddDays(1);
               }
              if(dt.Friday==true)
              {
                   weeklypickeddays.Add(date);
                    date = date.AddDays(1);
              }
              else
              {
                  date = date.AddDays(1);
              }
              if(dt.Saturday==true)
              {
                   weeklypickeddays.Add(date);
                    date = date.AddDays(1);
              }
              else
              {
                  date = date.AddDays(1);
              }
           

              if(dt.Sunday==true)
              {
                   weeklypickeddays.Add(date);
                    date = date.AddDays(1);
              }
              else
              {
                  date = date.AddDays(1);
              }
              date = date.AddDays(7 * dt.Weekinterval);
              date = date.AddDays(1);
            }
            return weeklypickeddays;

        
    }
    }
}
