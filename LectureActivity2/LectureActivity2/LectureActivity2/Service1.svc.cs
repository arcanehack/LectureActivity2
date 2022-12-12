using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LectureActivity2
{
    public class Service1 : IService1
    {
        public int sumOfDigits(int digits) //modified from source: https://www.codegrepper.com/code-examples/csharp/how+to+add+up+the+digits+of+an+int+c%23 
        {
            int sumOfNums = 0; //takes in each single digit from the int digits then adds them together
            while (digits > 0)
            {
                sumOfNums += digits % 10;
                digits /= 10;
            }
            return sumOfNums;
        }
        public int numOfVowels(string possibleVowelString)
        {

            int sumOfVowels = 0; //takes in a string then for each character in the possibleVowelString searches for any vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            
            foreach (char possibleVowel in possibleVowelString)
            {
                Console.WriteLine(possibleVowel);
                for (int i = 0; i < vowels.Length;  i++)
                {
                    if (possibleVowel == vowels[i])
                        sumOfVowels += 1;
                }
            }
            return sumOfVowels;//returns the sum of vowels that were found in the string
        }
        public int quitFunction(string quit)
        {
            return 0;
        }

    }
}
