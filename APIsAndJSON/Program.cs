using KanyeandRon;

namespace APIsAndJSON

{
    public class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kanye");
                QuoteGenerator.KanyeQuote();

                Console.WriteLine(); 
                
                Console.WriteLine("Ron");
                QuoteGenerator.RonQuote();
                
                
                Console.WriteLine("\n--------------------\n");
                
            }


            OpenWeatherMapAPI.GetWeatherMap();


        }
    }
}
