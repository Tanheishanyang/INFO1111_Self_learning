//This is a program I haven wirte
//it  could check weather or not the world's length is between the 0 to 20
using System;

namespace WordLengthChecker
{
    class Program
    //Define object types
    {
        static void Main(string[] args)
            //starting point
        {
            string myWord = "hello_world";
            bool isLengthValid = CheckWordLength(myWord);//call a function
            Console.WriteLine("The length of the word '" + myWord + "' is valid: " + isLengthValid);
            Console.ReadKey();
        }
        //define a function
        public static bool CheckWordLength(string word)
        {
            int length = word.Length;
            if (length >= 0 && length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
