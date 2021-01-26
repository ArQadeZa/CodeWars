using System;
using System.Collections.Generic;
using System.Linq;

namespace Digital_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program(); //Make an instance of the program class to call the Digital_Root method
            Console.WriteLine(p.Digital_Root(66)); 
        }

        public int Digital_Root(long number)
        {
            int total=0;        //integer to add the totals together

            char[] cNumber = number.ToString().ToArray();   //converts the long number to a string then converts to a array of characters
            int[] iNumber = new int[cNumber.Length];     //array to 

           
            for (int i = 0; i < cNumber.Length; i++)
            {
                iNumber[i] = (int)Char.GetNumericValue(cNumber[i]);     // gets the numeric value of the char and not the utf-16 version
                total += iNumber[i];    //adds the values together into one number
            }

            return total >= 10 ? Digital_Root(total) : total; // if the total is bigger or equal to 10 the digital_root method is run again until it is less than 10,
                                                                //and then gets returned to the display
            
        }
    }
}
