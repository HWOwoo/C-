using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            List<int> ans = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                num.Add(int.Parse(Console.ReadLine()) % 42 );
                //{ 1,2,3,4,5,6,7,8,9,10 }
                // 입력받은 수를 바로 42로 나눈 나머지를 num에 입력
            }

            // num에 저장된 나머지 중 중복찾기
            for (int i = 0; i < num.Count; i++)
            {
                for ( int j = 1 ; j < num.Count; j++)
                { 

                    if ( num[i] == num[j] )
                    {
                      continue; // 동일하다면 넘어가기
                    } 
                    else // 동일하지 않다면,
                    {
                        if (!ans.Contains(num[i]))
                        {
                             ans.Add(num[i]);
                        }
                    }
                }
            }
            if (!ans.Contains(num[^1]))
            {   
                ans.Add(num[^1]);
            }

            Console.WriteLine(ans.Count);
        }
    }
}