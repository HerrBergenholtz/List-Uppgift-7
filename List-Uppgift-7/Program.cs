using System;

namespace Uppgift_7
{
    class Program
    {
        static void Main()
        {
            string[] snus = { "a", "b", "b", "c", "hej" };
            string[] snus2 = { "hej", "a", "a", "b", "programmering" };

            foreach (string snusmus in FinnsIBåda(snus, snus2))
            {
                Console.Write($"\"{snusmus}\" ");
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