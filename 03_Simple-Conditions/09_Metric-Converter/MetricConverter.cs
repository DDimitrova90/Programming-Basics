using System;

class MetricConverter
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string inputMetric = Console.ReadLine();
        string outputMetric = Console.ReadLine();

        double result = 0;

        if (inputMetric == "m")
        {
            if (outputMetric == "mm")
            {
                result = number * 1000;
            }
            else if (outputMetric == "m")
            {
                result = number;
            }              
            else if (outputMetric == "cm")
            {
                result = number * 100;
            }
            else if (outputMetric == "mi")
            {
                result = number * 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                result = number * 39.3700787;
            }
            else if (outputMetric == "km")
            {
                result = number * 0.001;
            }
            else if (outputMetric == "ft")
            {
                result = number * 3.2808399;
            }
            else
            {
                result = number * 1.0936133;
            }                 
        }
        else if (inputMetric == "mm")
        {
            if (outputMetric == "m")
            {
                result = number / 1000;
            }
            else if (outputMetric == "mm")
            {
                result = number;
            }
            else if (outputMetric == "cm")
            {
                result = number * 0.1;
            }
            else if (outputMetric == "mi")
            {
                result = number * 0.000000621371192;
            }
            else if (outputMetric == "in")
            {
                result = number * 0.0393700787;
            }
            else if (outputMetric == "km")
            {
                result = number * 0.000001;
            }
            else if (outputMetric == "ft")
            {
                result = number * 0.0032808399;
            }
            else
            {
                result = number * 0.0010936133;
            }
        }

        else if (inputMetric == "cm")
        {
            if (outputMetric == "m")
            {
                result = number / 100;
            }
            else if (outputMetric == "cm")
            {
                result = number;
            }
            else if (outputMetric == "mm")
            {
                result = number * 10;
            }
            else if (outputMetric == "mi")
            {
                result = number * 0.00000621371192;
            }
            else if (outputMetric == "in")
            {
                result = number * 0.393700787;
            }
            else if (outputMetric == "km")
            {
                result = number * 0.00001;
            }
            else if (outputMetric == "ft")
            {
                result = number * 0.032808399;
            }
            else
            {
                result = number * 0.010936133;
            }
        }

        else if (inputMetric == "mi")
        {
            if (outputMetric == "m")
            {
                result = number / 0.000621371192;
            }
            else if (outputMetric == "mi")
            {
                result = number;
            }
            else if (outputMetric == "mm")
            {
                result = number * 1609344.000614692;
            }
            else if (outputMetric == "cm")
            {
                result = number * 160934.4000614692;
            }
            else if (outputMetric == "in")
            {
                result = number * 63359.99995957328;
            }
            else if (outputMetric == "km")
            {
                result = number * 1.609344000614692;
            }
            else if (outputMetric == "ft")
            {
                result = number * 5280.000010042307;
            }
            else
            {
                result = number * 1760.000003347436;
            }
        }

        else if (inputMetric == "in")
        {
            if (outputMetric == "m")
            {
                result = number / 39.3700787;
            }
            else if (outputMetric == "in")
            {
                result = number;
            }
            else if (outputMetric == "mm")
            {
                result = number * 25.400000025908;
            }
            else if (outputMetric == "cm")
            {
                result = number * 2.5400000025908;
            }
            else if (outputMetric == "mi")
            {
                result = number * 1.578282829289848e-5;
            }
            else if (outputMetric == "km")
            {
                result = number * 2.5400000025908e-5;
            }
            else if (outputMetric == "ft")
            {
                result = number * 0.083333333545;
            }
            else
            {
                result = number * 0.0277777778483333;
            }
        }

        else if (inputMetric == "km")
        {
            if (outputMetric == "m")
            {
                result = number / 0.001;
            }
            else if (outputMetric == "km")
            {
                result = number;
            }
            else if (outputMetric == "mm")
            {
                result = number * 1000000;
            }
            else if (outputMetric == "cm")
            {
                result = number * 100000;
            }
            else if (outputMetric == "mi")
            {
                result = number * 0.621371192;
            }
            else if (outputMetric == "in")
            {
                result = number * 39370.0787;
            }
            else if (outputMetric == "ft")
            {
                result = number * 3280.8399;
            }
            else
            {
                result = number * 1093.6133;
            }
        }

        else if (inputMetric == "ft")
        {
            if (outputMetric == "m")
            {
                result = number / 3.2808399;
            }
            else if (outputMetric == "ft")
            {
                result = number;
            }
            else if (outputMetric == "mm")
            {
                result = number * 304.799999536704;
            }
            else if (outputMetric == "cm")
            {
                result = number * 30.4799999536704;
            }
            else if (outputMetric == "mi")
            {
                result = number * 1.893939390337212e-4;
            }
            else if (outputMetric == "in")
            {
                result = number * 11.99999996952;
            }
            else if (outputMetric == "km")
            {
                result = number * 3.04799999536704e-4;
            }
            else
            {
                result = number * 0.3333333333333333;
            }
        }

        else 
        {
            if (outputMetric == "m")
            {
                result = number / 1.0936133;
            }
            else if (outputMetric == "yd")
            {
                result = number;
            }
            else if (outputMetric == "mm")
            {
                result = number * 914.399998610112;
            }
            else if (outputMetric == "cm")
            {
                result = number * 91.4399998610112;
            }
            else if (outputMetric == "mi")
            {
                result = number * 5.681818171011636e-4;
            }
            else if (outputMetric == "in")
            {
                result = number * 35.99999990856;
            }
            else if (outputMetric == "km")
            {
                result = number * 9.14399998610112e-4;
            }
            else
            {
                result = number * 3;
            }
        }       
        Console.WriteLine(result + " " + outputMetric);
    }
}

