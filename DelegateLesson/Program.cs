using System;

namespace DelegateLesson
{
    delegate bool Check(int x);
    delegate int Calc(int x, int y);
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 7, 65, 76, 12,33,63, 76 };

            Console.WriteLine(SumOfEvenNums(arr));
            Console.WriteLine(SumOfOddNums(arr));
            Console.WriteLine(SumOfDiviedBy3Nums(arr));

            Console.WriteLine(Sum(arr,IsEven));
            Console.WriteLine(Sum(arr, IsOdd));
            Console.WriteLine(Sum(arr,IsDividedBy3));

            Check ck1 = IsOdd;

            ck1 = delegate (int x) { return x > 10; };

            Console.WriteLine(Sum(arr, delegate (int x) { return x > 10; }));

            Console.WriteLine(Sum(arr,delegate(int x) { return x % 5 == 0; }));

            ck1 = null;

            Console.WriteLine(Sum(arr,x=>x%5==0));

            Console.WriteLine(ck1?.Invoke(34));

            Calc calc1 = Sum;

            Calc calc2 = Divide;

            calc2 = delegate (int num1, int num2)
            {
                return num1 * num2;
            };

            calc2  = (n1,n2) => n1 * n2;

            Console.WriteLine(calc1(10,4));
            Console.WriteLine(calc2(10, 2));


            Func<int, int, int> func1 = Divide;
            Func<int, bool> func2 = IsEven;
            func2 = x => x % 10 == 0;

            Action<int, int, int> act1 = ShowSum;

            act1 = (x, y, z) => Console.WriteLine(x+y+z);

            act1(30, 10, 30);

            Predicate<int> predicate = IsEven;
            predicate = x => x % 5 == 0;

            double[] doubleArr = { 34, 54, 10, 3, 54 };

            Console.WriteLine(Sum(doubleArr,x=>x>30));
        }

        static double Sum(double[] nums,Predicate<double> pred)
        {
            double sum = 0;

            foreach (var item in nums)
            {
                if (pred(item))
                    sum += item;
            }

            return sum;
        }

        static int Sum(int[] nums,Check check)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (check(item))
                {
                    sum += item;
                }
            }

            return sum;
        }

        static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }

        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static void ShowSum(int num1,int num2,int num3)
        {
            Console.WriteLine(num1+num2+num3);
        }

        static int SumOfEvenNums(int[] nums)
        {
            int sum = 0;

            foreach (var item in nums)
            {
                if (IsEven(item))
                    sum += item;
            }

            return sum;
        }

        static int SumOfOddNums(int[] nums)
        {
            int sum = 0;

            foreach (var item in nums)
            {
                if (IsOdd(item))
                    sum += item;
            }

            return sum;
        }

        static int SumOfDiviedBy3Nums(int[] nums)
        {
            int sum = 0;

            foreach (var item in nums)
            {
                if (item%3==0)
                    sum += item;
            }

            return sum;
        }

        static int SumOf2digitsNums(int[] nums)
        {
            int sum = 0;

            foreach (var item in nums)
            {
                if (item>=10 && item<=99)
                    sum += item;
            }

            return sum;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
        static bool IsDividedBy3(int num)
        {
            return num % 3 == 0;
        }
    }

}
