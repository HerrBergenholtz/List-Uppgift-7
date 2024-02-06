using System;

namespace Uppgift_7
{
    class Program
    {
        static void Main()
        {
            string[] arr1 = { "a", "b", "b", "c", "hej" };
            string[] arr2 = { "hej", "a", "a", "b", "programmering" };

            foreach (string str in FinnsIBåda(arr1, arr2))
            {
                Console.Write($"\"{str}\" ");
            }
        }

        static string[] FinnsIBåda(string[] arr1, string[] arr2)
        {
            List<string> lista = new();

            foreach (string str in arr1)
            {
                if (arr2.Contains(str) && !lista.Contains(str))
                {
                    lista.Add(str);
                }
            }

            return lista.ToArray();
        }
    }
}