using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static ReadCSV;
using static System.Net.WebRequestMethods;

namespace credly
{
    public class BadgeAssigner
    {
        private readonly HttpClient _httpClient;
        //Use HttpClient to send HTTP POST requests to the provided URL with the badge assignment data.
        public BadgeAssigner()
        {
            _httpClient = new HttpClient();
        }
        //This function iterates over the list of employees, serializes each employee object into JSON format, creates an HttpContent object with the
        //JSON data, and then sends an HTTP POST request to the provided URL(url) with the JSON data as the request body.
        public async Task AssignBadgesAsync(string url, List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                var json = JsonSerializer.Serialize(employee);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(url, content);

                // Handle response if needed
            }
        }
    }
}
