using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line";
            //string myString = "Go to your c:\\\\ drive";

            //string myString = String.Format("{0} = {1}", "First", "Second");
            /*outputs First = Second 
             You can also switch between 1 and 0, 0 and 0, 1 and 0*/

            //string myString =String.Format("{0:C}", 123.45);
            /* C means format like currency 
             *Outputs "$123.45" based on your English country setting 
             * On your computer */

            //string myString = String.Format("{0:N}", 1234567890);
            /* N adds decimal points and commas*/

            //string myString = string.Format("Percentage: {0:P}", .123);
            /*P displays percentage*/

            //string myString = string.Format("Phone Number:{0:(###) ###-####}", 123456789012);
            /*Custom US phone number format
             * Adding an extra number outside causes the numbers to be pushed back in*/

            //string myString = " Your skin and bones turn into something beautiful  ";
            //myString = myString.Substring(6); //prints from skin
            //myString = myString.Substring(6, 14); //prints skin and bones

            //myString = myString.ToUpper();//prints everything as Caps

            //myString = myString.Replace(" ", "--");
            /*Repaces every space with -- */

            //myString = myString.Remove(6, 14); //removes from lines 6 to 14

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length, // how long the string is before making changes
                myString.Trim().Length); //cutting off extra spaces, how long is the string itself
            //Trim method gets rid of extra spaces at both ends of the sentence
            */

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString(); //Concatenates -- and current value of i's
            }
            */
            //Using a different type because the above takes up too much runtime
            //It has to create a sepearte bucket in the backgroud to hold the values of i and --,
            //therefor there is a lot of time in running this program

            //Using a string builder

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            } //This is more efficient than the first method because it doesnt have to create 
            //another bucket to hold -- and i values. It just joins it
            //this reduces runtime, which is a good thing,
            //ensuring the efficieny of the program



            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
