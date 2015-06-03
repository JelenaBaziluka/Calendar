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
    public class ClientParameterRequest
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int DaysInterval { get; set; }
    }
    public class CalendarTests
    {
        [Fact]
        public void SomeTest()
        {
            var c = new HttpClient();
            c.BaseAddress = new Uri("http://localhost:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new ClientParameterRequest
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
            c.BaseAddress = new Uri("http://localhost:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new ClientParameterRequest
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
            c.BaseAddress = new Uri("http://localhost:1848/");
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var parameters = new ClientParameterRequest
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
    }
}
   