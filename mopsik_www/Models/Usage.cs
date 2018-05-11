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
                BackgroundColor = "#008000"; //green
                TextColor = "#ffffff"; //white
            }
            else if(Value < 50)
            {
                BackgroundColor = "#ffff00"; //yellow
                TextColor = "#000000"; //black
            }
            else if(Value < 75)
            {
                BackgroundColor = "#ffa500"; //orange
                TextColor = "#000000"; //black
            }
            else if (Value <= 100)
            {
                BackgroundColor = "#ff0000"; //red
                TextColor = "#ffffff"; //white
            }
            else
            {
                BackgroundColor = "#000000"; //black
                TextColor = "#ffffff"; //white
            }
        }
    }
}
