using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaoneCE4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables

            double
                tempF=0,
                tempCelsius=0;

            //ask for user input

            Console.WriteLine("Please enter the temperature in fahrenheit: ");
          

            tempConvert(ref tempCelsius);
            

            Console.WriteLine("Converted value is: {0} degrees Celsius", +Math.Round(tempCelsius, 0));


            Console.ReadKey();




        }//end of main



        public static double tempConvert(ref double tempCelsius)
        {
            double tempF;
           //do conversions
            tempF = Convert.ToDouble(Console.ReadLine());
            tempCelsius = (tempF - 32) * 5.0/9.0;
            return tempCelsius;

        }





    }//end of class

}
