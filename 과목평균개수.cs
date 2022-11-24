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
            // 과목 개수 입력
            int n = int.Parse(Console.ReadLine());

            // 시험 점수 입력
            string[] s = Console.ReadLine().Split();
            float[] score = Array.ConvertAll(s, float.Parse);

            // 최고점을 저장
            float max = float.MinValue;

            // 최고점을 찾는다.
            for (int i = 0; i < n; i++)
            {
                if (score[i] > max)
                {
                    max = score[i];
                }
            }


            // 합계를 저장
            float sum = 0.0f;

            // 점수를 바꾼다.
            for (int i = 0; i < n; i++)
            {
                // 바꾼 점수를 change에 저장함
                score[i] = score[i] / max * 100;
                sum += score[i];
            }

            Console.WriteLine("{0:0.00####}", sum / n);
        }
    }
}