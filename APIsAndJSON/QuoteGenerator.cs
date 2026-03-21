using System; 
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeandRon;


public class QuoteGenerator 
{
   public static string KanyeQuote()
   {
       var client = new HttpClient(); 
       var kanyeUrl = "https://api.kanye.rest";
       var kanyeresponse = client.GetStringAsync(kanyeUrl).Result;
       var kanyeQuote = JObject.Parse(kanyeresponse).GetValue("quote").ToString();
       Console.WriteLine(kanyeQuote);
       
       
    return kanyeQuote;
   }

   public static string RonQuote()
   {
       var client = new HttpClient();
       var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
       var ronResponse = client.GetStringAsync(ronUrl).Result;
       var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
       
       Console.WriteLine(ronQuote);
       Console.WriteLine($"---------------");
       
       return ronQuote;
   }

   
}
   

