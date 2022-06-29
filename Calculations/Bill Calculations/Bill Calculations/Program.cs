using System;
namespace Bill_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double telephone = 250;
            double internet = 2629.60;
            double evocharji = 0.00;
            double tv = 0;
            double valueaddedservices = 375.0;
            double discount = 250;
            double adjustment = 0;
            double totalservicescharges = telephone + internet + evocharji + tv + valueaddedservices - discount + adjustment;
            double arears = 4;
            double credit = -5;
            //service ta is 19.5%;
            double servicetax = tolalservicecharges * 19.5 / 108;

            Console.ReadKey();
        }
    }
}
