using System;

namespace Anagrams
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool Exit =false;
            while (Exit == false)
            {
                var foos1 = Console.ReadLine();
                string[] arr1 = foos1.Split(',');

                var foos2 = Console.ReadLine();
                string[] arr2 = foos2.Split(',');

                    for (int i = 0; i < arr1.Length; i++)
                    {
                        bool Angram = isAnagram(arr1[i], arr2[i]);
                        if (Angram == true)
                        {
                            Console.WriteLine("1");
                        }
                        else
                        { Console.WriteLine("0"); }
                    }
            }
        }


        public static bool isAnagram(string arr1, string arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr2.Length; i++)
            {
                int x = arr1.IndexOf(arr2[i]);
                if (x < 0)
                    return false;
                arr1 = arr1.Remove(x, 1);
            }
            return String.IsNullOrEmpty(arr1);
        }
    }
}
