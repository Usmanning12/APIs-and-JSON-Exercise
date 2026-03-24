using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        private static string apiKey = "86924eafbff9ea748843b429936359fc";
        
        private static string BuildWeatherUrl(string city)
        {
            return $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={apiKey}";

        }


        public  static void GetWeatherMap()
        {
            try
            {
                var client = new HttpClient();
                Console.WriteLine("Enter a city");
                var city = Console.ReadLine().Trim();
                var weatherUrl = BuildWeatherUrl(city);
                var response = client.GetStringAsync(weatherUrl).Result;
                var weatherData = JObject.Parse(response);
                if (weatherData["main"]!= null)
                {
                    var temp = weatherData["main"]["temp"].ToString();
                    var description = weatherData["weather"][0]["description"].ToString();
                    Console.WriteLine($"Temp: {temp}°F");
                    Console.WriteLine($"Condition: {description}");
                }
                else
                {
                    Console.WriteLine("City not found, try again");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("City not found or network error, try again");
            }

            

           
        }
        
    }

    
}
