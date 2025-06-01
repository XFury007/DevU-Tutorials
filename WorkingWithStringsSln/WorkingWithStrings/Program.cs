using System.Text;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line";
            // string myString = "Go to your c\\ drive";
            //string myString = @"Go to your c:\  drive";

            //string myString = String.Format("{1} = {0}", "First", "Second");


            //string myString = string.Format("{0:C}", 123.450);
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

            //string myString = Console.ReadLine();

            //myString = myString.ToUpper();    

            //myString = myString.Replace("that", "I am");

            
            string myString = " ";
           /*
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                   myString.Append("--");
                   myString.ToUpper();  
            }    
            
            Console.WriteLine(myString);
            Console.ReadLine();
            
        
        }
    }
}
