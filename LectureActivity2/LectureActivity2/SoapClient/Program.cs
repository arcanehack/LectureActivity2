/*
 * Hunter White
 * 1/24/22
 * ASU ID: 1215077149
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            string menuOption;
            do //menu that selects which option you want then sends it to the functions of that option.
            {
                Console.WriteLine("Select which option you would like:\n" +
                                    "[1] Sum of digits\n" +
                                    "[2] Vowel count\n" +
                                    "[3] Exit");
                menuOption = Console.ReadLine();

                if (menuOption == "1")
                {
                    Console.WriteLine("Enter string of digits: ");
                    string numString = Console.ReadLine();
                    int toInteger;
                    toInteger = Convert.ToInt32(numString);
                    Console.WriteLine(myClient.sumOfDigits(toInteger));
                }
                else if (menuOption == "2")
                {
               
                    Console.WriteLine("Enter string with vowels: ");
                    string vowelString = Console.ReadLine();
                    Console.WriteLine(myClient.numOfVowels(vowelString));
                 
                }


            } 
            while (menuOption != "3");

            Console.WriteLine("Exiting");
            
            

        }
    }
}
