using System;

namespace C_manage
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            int max = 0;

            for ( int i = 0; i < 9; i++)
            {
                string[] s = Console.ReadLine().Split(); // 3, 23, 85, 34, 17 ,74 ,25 ,52 ,65

                for ( int j = 0; j < 9; j++) {
                    if (max < int.Parse(s[j]))
                    {
                        max = int.Parse(s[j]);
                        a = i + 1; 
                        b = j + 1;
                    }
                }
            }
            if ( max == 0 )
            {
                a = 1;
                b = 1;
            }
            Console.WriteLine(max);
            Console.WriteLine(a + " " + b);
        }
    }
}