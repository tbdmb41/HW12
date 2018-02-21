using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12 
{
    class Program
    {
         static public void WritePrompt()
        {
         try
                {
                    Console.WriteLine("Please enter a word to see if it's a Palindrome");
                    Console.WriteLine("Or type exit to leave");
                }
                    catch (OverflowException)
                {
                    throw new Exception();
                }
                }
                    static public string ReverseString(string input)
    {
        try
    {
                    char[] userUnput = input.ToCharArray();
                    Array.Reverse(userUnput);
                    string outcome = new string(userUnput);
                    return outcome;
                }
        catch (StackOverflowException)
                {
        throw new Exception();
 }
 }
                        static void Main(string[] args)
        {
                        {
                        WritePrompt();
                         var i = true;
                         while (i == true)
        {
        try
        {
                var input = Console.ReadLine();
                if (input == ReverseString(input))
        {
                        Console.WriteLine("This is a Palindrome");
                        }
                        else if (input != ReverseString(input) && input != "Exit")
                        {
                         Console.WriteLine("This is not a Palindrome. Please try again.");
                        }
                        else if (input == "Exit")
                        {
                        break;
                        }
                        continue;
                        }
                        catch (Exception)
                        {
                        Console.WriteLine("Error");
                        }
                    finally
                        {
                        }
                }
                }
        }
        }
}
