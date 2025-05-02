namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers =new int[5];

            numbers[0] = 4; 
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 56;    


            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            //int[] numbers = new int[] { 4, 7, 14, 16, 32, 42 };

            //string[] names = new string[] { "Eddie", "Alex", "Micheal", "David Bill" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }

            Console.ReadLine();
            */
            /*
            foreach (string name in names) 
            { 
                Console.WriteLine(name);    
                           
            }
            Console.ReadLine();
            */

            string zig = "You can gte what you want out of life" + 
                         "if you help enough other people get what they want";

            char[] charArray =  zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.WriteLine(zigChar); 

            }
            Console.ReadLine();
        }
    }
}