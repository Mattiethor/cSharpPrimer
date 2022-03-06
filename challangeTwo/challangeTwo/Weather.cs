using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challangeTwo
{
    internal class Weather
    {
        public Weather(int temp, int humid, string scale )
        {
            Temperature = temp;
            Humidity = humid;
            Scale = scale;

           

        }

        
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public string Scale { get; set; }


    }


}
