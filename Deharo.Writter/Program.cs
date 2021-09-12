using Deharo.Writter.Models;
using Deharo.Writter.Models.Core;
using Deharo.Writter.Services;
using System;
using System.Collections.Generic;

namespace Deharo.Writter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "VuelingUniversity";
            int option = 0;
            Console.WriteLine(@"Hi user, you've to choose an option of below!
    1.- Format your archive to JSON.
    2.- Format your archive to TXT.
    3.- Format your archive to XML.
    4.- Format your archive to YML.");

            Int32.TryParse(Console.ReadLine(), out option);
            // TRUE = CLOUD .. FALSE = LOCAL
            WriterContainer container = new WriterContainer(true);
            switch (option)
            {
                case 0:
                    Console.WriteLine("This is not a number.");
                    break;
                case 1:
                    container.Factory.CreateWritter(EFormatTypes.JSON).WriteBody(fileName);
                    break;
                case 2:
                    container.Factory.CreateWritter(EFormatTypes.TXT).WriteBody(fileName);
                    break;
                case 3:
                    container.Factory.CreateWritter(EFormatTypes.XML).WriteBody(fileName);
                    break;
                case 4:
                    container.Factory.CreateWritter(EFormatTypes.YML).WriteBody(fileName);
                    break;
                default:
                    Console.WriteLine("That is not an option.");
                    break;
            }
            VuelingUniversity vuelingUniversity = new VuelingUniversity();
            Console.WriteLine(vuelingUniversity.ToString());
        }
    }
}
