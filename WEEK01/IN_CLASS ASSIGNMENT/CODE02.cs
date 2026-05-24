using System;
using System.Collections.Generic;
using System.Text;

namespace proj1
{
  
        //CLASS03--IF ELSE STATEMENT-ASSIGNMENT QUESTION
        //Accept character from user and check whether it is a letter, digit or special character.


        public void check()
        {
            Console.Write("Enter a character:");
            char c = Convert.ToChar(Console.ReadLine());

            if (char.IsLetter(c))
            {
                Console.WriteLine("The character is a letter.");

            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("The character is a digit.");
            }

            else
            {
                Console.WriteLine("The character is a special character.");
            }
        }    
}

 internal class Program
 {
     static void Main(string[] args)
     {
         ConditionalExample example = new ConditionalExample();
         example.check();
     }
 } 
        
        
   






