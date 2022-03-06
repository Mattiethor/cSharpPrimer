using challangeTwo;

namespace CsharpPrimer
{
    class Program
    {

        // 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the weather app");

            int temp = 0;
            int humidity = 0;
            string scale = ""; 

            Console.WriteLine("enter temp:");
            temp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter humidity:");
            humidity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter scale f or c:");
            scale = Console.ReadLine();

            Weather w1 = new Weather(temp, humidity, scale);

           
            Console.WriteLine($"{w1.Temperature} {w1.Scale.ToLower()}");
            Console.WriteLine($"Humidity: {w1.Humidity}%");
            

            
            
            if(w1.Scale == "f") {
                Console.WriteLine($"Converted temp: {Converter(w1.Temperature, w1.Scale)} c");
            }
            else
            {
                Console.WriteLine($"Converted temp: {Converter(w1.Temperature, w1.Scale)} f");
            }
        }




        static int Converter(int temp, string scale)
        {

            if(scale == "f")
            {
                int celsius = (temp - 32) * 5/9;
                return celsius ;

                
            }else if(scale == "c")

            {
                int fahrenheit = (int)((temp * 1.8) + 32);
                return fahrenheit;


            }
            else
            {
                return 0;
            }  

        }

        

    }
}