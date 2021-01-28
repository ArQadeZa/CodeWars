using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encrypt_this_
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.EncryptThis("a ass")); 
        }

        public string EncryptThis(string input) // method that returns an encrypted string
        {
            string Completed = ""; // the completed string
            string[] sWords = input.Split(); //splits the words up into a array
           
            if (input.Length == 0)
            {
                return ""; // returns blank if the input is blank
            }
            foreach (string item in sWords)
            {
                if (item.Length == 1)
                {
                   if (sWords.Count() < 2)
                    {
                        Completed += ((int)Convert.ToChar(item)).ToString();    //converts the value to ascii
                    }
                    else
                    {
                        Completed += ((int)Convert.ToChar(item)).ToString() + " "; //converts the value to ascii and adds a space if there are other values in the array
                    }
                    
                }
                else
                {
                    string text = "";
                    char temp = '0';
                    char[] cWord = item.Remove(0, 1).ToCharArray(); //breaks the word up inta a array of characters

                    temp = cWord.Last(); //stores the last value in a temp variable
                    cWord[cWord.Count() - 1] = cWord.First(); //sets the last value to the first one
                    cWord[0] = temp;    //sets the first value to the temp variable

                    foreach (char c in cWord)
                    {
                        text += c; //adds all the characters to a string
                    }

                    Completed += string.Join("", (int)Convert.ToChar(item.First()), text) + " ";   //converts the first letter to the ascii value
                }
                
            }
            return Completed.Trim() ;
        }
    }
}
