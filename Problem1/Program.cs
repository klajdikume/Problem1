using System;

namespace Problem1
{
    class Program
    {

        private static void Problem1_alg(string haystack, string needle, int threshold)
        {
            

            if (threshold > needle.Length) return;

            //per cdo karakter te stringut needle
            for (int i = 0; i < needle.Length; i++)
            {
                //marr karaktere ne numer me te madh sec eshte threshold
                for (int j = 0; j < needle.Length - i + 1; j++)
                {
                    if (j >= threshold)
                    {
                        //marr sekuencen e stringut nga per indekset perkatese 
                        var sequence = needle.Substring(i, j);

                        var haystack_offset = haystack.IndexOf(sequence);//ku e has per here te pare kete sequence ne haystack, nese jo jep -1

                        var needle_offset = needle.IndexOf(sequence); //marr offset te substringut ne needle

                        if (haystack_offset != -1 && needle_offset != -1) //Console.WriteLine(allSubstrings);
                            Console.WriteLine($"sequence of length = {j} found at haystack offset {haystack_offset}, needle offset {needle_offset}");
                    }
                }
            }

        }

        

        static void Main(string[] args)
        {


            string haystack = "vnk2435kvabco8awkh125kjneytbcd12qjhb4acd123xmnbqwnw4t";
            string needle = "abcd1234"; 

            int threshold = 3;

            Problem1_alg(haystack, needle, threshold);

        }
    }
}
