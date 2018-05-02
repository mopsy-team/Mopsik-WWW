using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mopsik_www.Models
{
    public class Usage
    {
        public double Value;
        public string PrintValue;
        public string BackgroundColor;
        public string TextColor;

        public Usage(int available, int taken)
        {
            if (available == 0)
            {
                Value = 100;
                PrintValue = "--";
            }
            else
            {
                Value = ((double)taken / available) * 100;
                PrintValue = Value.ToString("N2") + "%";
            }

            if(Value < 35)
            {
                BackgroundColor = "green";
                TextColor = "white";
            }
            else if(Value < 50)
            {
                BackgroundColor = "yellow";
                TextColor = "black";
            }
            else if(Value < 75)
            {
                BackgroundColor = "orange";
                TextColor = "black";
            }
            else if (Value <= 100)
            {
                BackgroundColor = "red";
                TextColor = "white";
            }
            else
            {
                BackgroundColor = "black";
                TextColor = "white";
            }
        }
    }
}
