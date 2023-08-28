using System.Threading.Channels;

namespace CharString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //Console.WriteLine("Input string:");
            //string word = Console.ReadLine();
            //string[] splitArr = word.Split(" ");
            //Console.WriteLine($"Total number of words in the string is : {splitArr.Length}");


            // Task 2
            char[] vowels = {'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            int vowelCount=0;
            
            Console.WriteLine("Input string");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        vowelCount++;
                    }
                }
            }
            int consonantCount = word.Length - vowelCount;
            Console.WriteLine($"Vowels: {vowelCount}, Consonants: {consonantCount}");


            // Task 3
            //Console.WriteLine("Input string:");
            //string str = Console.ReadLine();
            //char[] newArr = str.ToCharArray();
            //Console.Write("Reversed and UpperCase: ");
            //for ( int i = newArr.Length-1; i >= 0; i--)
            //{
            //    Console.Write(newArr[i].ToString().ToUpper());
            //}

        }
    }
}