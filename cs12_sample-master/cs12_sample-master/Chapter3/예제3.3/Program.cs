
/* ================= 예제 3.3: 1 ~ 1,000까지 짝수를 더하는 while 반복문 ================= */

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //int sum = 0;
        //int n = 1;

        //while (n <= 1000)
        //{
        //    if (n % 2 == 0)
        //    {
        //        sum += n;
        //    }

        //    n++;
        //}

        //Console.WriteLine(sum); // 출력 결과: 250500\

        // 문제1. 
        int n = 1;
        int sum = 0;

        while (n < 1000)
        {
            if (n % 3 == 0 || n % 5 == 0)
            {
                sum = sum + n;
            }
            n++;
        }
        Console.WriteLine(sum);
    }
}
