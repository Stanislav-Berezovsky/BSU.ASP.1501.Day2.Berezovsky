using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task4
{
    public static class NOD
    {
        public static int EuclideanMethod(int a ,int b)
        {
            a=Math.Abs(a);
            b=Math.Abs(b);
            int variable = 0;
            while (b > 0)
            {
                variable = b;
                b = a % b;
                a = variable;
            }
            return a;
        }

        public static int EuclideanMethod(int a, int b, out long ticks)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = EuclideanMethod(a, b);
            stopwatch.Stop();
            ticks = stopwatch.ElapsedTicks;
            return result;
        }

        public static int EuclideanMethod(params int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result = EuclideanMethod(result, array[i]);
            }
            return result;  
        }


        public static long EuclideanMethod(out long ticks, params int[] array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = EuclideanMethod(array);
            stopwatch.Stop();
            ticks = stopwatch.ElapsedTicks;
            return result;
        }

        public static int SteinMethod(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a == b)
                return a;
            if (a == 1 && b==1)
                return 1;
            if (a % 2 == 0)
            {
                if (b % 2 == 0)                   
                    return 2*SteinMethod(a/2, b/2) ;
                return SteinMethod(a/2, b);
            }
            if (b % 2 == 0)
                return SteinMethod(a, b/2);

            if (a > b)
                return SteinMethod((a - b)/2, b);
            return SteinMethod((b - a) /2, a);
        }


        public static int SteinMethod(int a, int b, out long ticks)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = SteinMethod(a, b);
            stopwatch.Stop();
            ticks = stopwatch.ElapsedTicks;
            return result;
        }


        public static int SteinMethod(params int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result = SteinMethod(result, array[i]);
            }
            return result;
        }


        public static long SteinMethod(out long ticks, params int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = SteinMethod(array);
            stopwatch.Stop();
            ticks = stopwatch.ElapsedTicks;
            return result;
        }
    }
}
