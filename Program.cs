using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            // Max heart rate is equal 220 - age
            int Max_Heart_rate;
            age = 28;
            height = 56;
            Max_Heart_rate = 220 - age;

            // Console should write: I am ### years old, my max heart
            //rate is ## and I am ## inches tall

            Console.WriteLine("I am "+ age + " years old, my max heart rate is "+ Max_Heart_rate + " and I am " + height + " inches tall");
        }
    }
}
