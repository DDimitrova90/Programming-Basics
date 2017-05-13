using System;

class MetricConverterNew
{
    static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        string metricFrom = Console.ReadLine();
        string metricTo = Console.ReadLine();

        if (metricFrom == "m")
        {
            value /= 1;
        }
        else if (metricFrom == "mm")
        {
            value /= 1000;
        }
        else if (metricFrom == "cm")
        {
            value /= 100;
        }
        else if (metricFrom == "mi")
        {
            value /= 0.000621371192;
        }
        else if (metricFrom == "in")
        {
            value /= 39.3700787;
        }
        else if (metricFrom == "km")
        {
            value /= 0.001;
        }
        else if (metricFrom == "ft")
        {
            value /= 3.2808399;
        }
        else if (metricFrom == "yd")
        {
            value /= 1.0936133;
        }


        if (metricTo == "m")
        {
            value *= 1;
        }
        else if (metricTo == "mm")
        {
            value *= 1000;
        }
        else if (metricTo == "cm")
        {
            value *= 100;
        }
        else if (metricTo == "mi")
        {
            value *= 0.000621371192;
        }
        else if (metricTo == "in")
        {
            value *= 39.3700787;
        }
        else if (metricTo == "km")
        {
            value *= 0.001;
        }
        else if (metricTo == "ft")
        {
            value *= 3.2808399;
        }
        else if (metricTo == "yd")
        {
            value *= 1.0936133;
        }

        Console.WriteLine(value + " " + metricTo);
    }
}

