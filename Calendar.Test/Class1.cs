using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Calendar.Test
{
    public class EveryNdayssParameter
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int DaysInterval { get; set; }
    }
    public class WeeklyParameter
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
        public int Weekinterval { get; set; }

    }

    public class CalendarTests
    {
        [Fact]
        public void SomeTest()
        {
            var c = new HttpClient();
            c.BaseAddress = new Uri("http://localhost.fiddler:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new EveryNdayssParameter
              {
                  Start = new DateTime(2015, 06, 01),
                  Finish = new DateTime(2015, 06, 20),
                  DaysInterval = 3
              };
            string json = JsonConvert.SerializeObject(parameters);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage result = c.PostAsync("/api/calendar", content).Result;

            if (result.IsSuccessStatusCode)
            {
                string jsonReturnedFromServer = result.Content.ReadAsStringAsync().Result;
                var dates = JsonConvert.DeserializeObject<DateTime[]>(jsonReturnedFromServer);

                Assert.Equal(new DateTime(2015, 06, 04), dates[0]);
                Assert.Equal(new DateTime(2015, 06, 07), dates[1]);
                Assert.Equal(new DateTime(2015, 06, 10), dates[2]);
                Assert.Equal(7, dates.Length);
            }
            else
            {
             
              Assert.True(false);
            }
        }
        [Fact]
        public void FailTest()
        {
             var c = new HttpClient();
             c.BaseAddress = new Uri("http://localhost.fiddler:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new EveryNdayssParameter
              {
                  Start = new DateTime(2015, 06, 01),
                  Finish = new DateTime(2015, 06, 20),
                  DaysInterval = 3
              };
            string json = JsonConvert.SerializeObject(parameters);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage result = c.PostAsync("/api/calendar", content).Result;

            if (result.IsSuccessStatusCode)
            {
                string jsonReturnedFromServer = result.Content.ReadAsStringAsync().Result;
                var dates = JsonConvert.DeserializeObject<DateTime[]>(jsonReturnedFromServer);

                Assert.Equal(new DateTime(2015, 06, 04), dates[0]);
                Assert.Equal(new DateTime(2015, 06, 07), dates[1]);
                Assert.Equal(new DateTime(2015, 06, 10), dates[2]);
                Assert.Equal(7, dates.Length);
            }
            else
            {

                Assert.True(false);
            }
        }

        [Fact]
        public void Test()
        {
            var c = new HttpClient();
            c.BaseAddress = new Uri("http://localhost.fiddler:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new EveryNdayssParameter
            {
                Start = new DateTime(2015, 06, 01),
                Finish = new DateTime(2015, 06, 20),
                DaysInterval = 3
            };
            string json = JsonConvert.SerializeObject(parameters);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage result = c.PostAsync("/api/calendar", content).Result;

            if (result.IsSuccessStatusCode)
            {
                string jsonReturnedFromServer = result.Content.ReadAsStringAsync().Result;
                var dates = JsonConvert.DeserializeObject<DateTime[]>(jsonReturnedFromServer);

                Assert.Equal(new DateTime(2015, 06, 04), dates[0]);
                Assert.Equal(new DateTime(2015, 06, 07), dates[1]);
                Assert.Equal(new DateTime(2015, 06, 10), dates[2]);
                Assert.Equal(7, dates.Length);
            }
            else
            {

                Assert.True(false);
            }
        }

        ////////////////////////////////////////////
        //for weekdays
        [Fact]
        public void WeekDaysTest()
        {
            var c = new HttpClient();
            c.BaseAddress = new Uri("http://localhost.fiddler:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new WeeklyParameter
            {
                Start = new DateTime(2015, 06, 06),
                Finish = new DateTime(2015, 09, 30),
                Monday = true,
                Tuesday = true,
                Wednesday = true,
                Thursday = true,
                Friday = false,
                Saturday = false,
                Sunday = false,
                Weekinterval = 2
            };
            string json = JsonConvert.SerializeObject(parameters);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage result = c.PostAsync("/api/CalendarWeekly", content).Result;

            if (result.IsSuccessStatusCode)
            {
                string jsonReturnedFromServer = result.Content.ReadAsStringAsync().Result;
                var dates = JsonConvert.DeserializeObject<DateTime[]>(jsonReturnedFromServer);

                Assert.Equal(new DateTime(2015, 06, 06), dates[0]);
                Assert.Equal(new DateTime(2015, 06, 22), dates[1]);
                Assert.Equal(new DateTime(2015, 07, 06), dates[2]);
                Assert.Equal(8, dates.Length);
            }
            else
            {

                Assert.True(false);
            }
        }
             [Fact]
        public void WeekDaysTest2()
        {
            var c = new HttpClient();
            c.BaseAddress = new Uri("http://localhost.fiddler:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new WeeklyParameter
            {
                Start = new DateTime(2015, 06, 08),
                Finish = new DateTime(2015, 07, 06),
                Monday = false,
                Tuesday = true,
                Wednesday = true,
                Thursday = true,
                Friday = false,
                Saturday = true,
                Sunday = false,
               Weekinterval  = 1
            };
            string json = JsonConvert.SerializeObject(parameters);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage result = c.PostAsync("/api/CalendarWeekly", content).Result;

            if (result.IsSuccessStatusCode)
            {
                string jsonReturnedFromServer = result.Content.ReadAsStringAsync().Result;
                var dates = JsonConvert.DeserializeObject<DateTime[]>(jsonReturnedFromServer);

                Assert.Equal(new DateTime(2015, 06, 09), dates[0]);
                Assert.Equal(new DateTime(2015, 06, 10), dates[1]);
                Assert.Equal(new DateTime(2015, 06, 11), dates[2]);
                Assert.Equal(8, dates.Length);
            }
            else
            {

                Assert.True(false);
            }
        }
    }
}
   