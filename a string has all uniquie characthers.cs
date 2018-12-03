using System;

namespace a_string_has_all_uniquie_characthers
{
    class Program
    {
        static bool unique(String str)
        {
       
            // daca numar de 2 ori acelasi caracter, return false
            for (int i = 0; i < str.Length; i++)
                for (int j = i + 1; j < str.Length; j++)
                    if (str[i] == str[j])
                        return false;
        
            return true;
        }

        public static void Main()
        {
            string a = "mirela";

            if (unique(a) == true)
                Console.WriteLine("stringul are caractere unice " + a);
            else
                Console.WriteLine("stringul are caractere duplicate " + a);

            Console.ReadLine();
        }
    }
}
