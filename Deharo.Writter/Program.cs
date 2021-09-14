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
            WriterContainer container = new WriterContainer(false);
            VuelingUniversity vUni = new VuelingUniversity();
            vUni.StudentsList.Clear();
            switch (option)
            {
                case 0:
                    Console.WriteLine("This is not a correct number.");
                    break;
                case 1:
                    vUni = Reader.LoadFromXMLString(@"C:\Users\gteam\source\repos\Writter-Kata\SourceArchive");
                    vUni.StudentsList.Add(new Student("Antonio", "De Haro2", true, 5.43));
                    container.Factory.CreateWritter(EFormatTypes.JSON).WriteBody(fileName, vUni);
                    break;
                case 2:
                    container.Factory.CreateWritter(EFormatTypes.TXT).WriteBody(fileName, vUni);
                    break;
                case 3:
                    vUni = Reader.LoadFromXMLString(@"C:\Users\gteam\source\repos\Writter-Kata\SourceArchive");
                    vUni.StudentsList.Add(new Student("Antonio", "De Haro2", true, 5.43));
                    container.Factory.CreateWritter(EFormatTypes.XML).WriteBody(fileName, vUni);
                    break;
                case 4:
                    container.Factory.CreateWritter(EFormatTypes.YML).WriteBody(fileName, vUni);
                    break;
                default:
                    Console.WriteLine("That is not an option.");
                    break;
            }
            //Console.WriteLine(vUni.ToString());
        }
    }
}
