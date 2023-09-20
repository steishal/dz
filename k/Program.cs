//using System;

////Таким образом вы определяете свое пространство имен.
//namespace HelloWorld
//{
//    // Таким образом определяется класс.
//    class Program
//    {
//        static void Main()
//        {
//         double x, y;
//         x = double.Parse(Console.ReadLine());
//         y = double.Parse(Console.ReadLine());
//         if (x >= 0 && ((x * x) + (y * y) <= 1))
//            {
//                Console.WriteLine("Да");
//            }
//         else
//            {
//                if (x >= -1 && x <= 0 && y <= 1 && y >= -1)
//                {
//                    Console.WriteLine("Да");
//                }
//                else
//                    Console.WriteLine("Нет");
//            }

//        }
//    }
//}

//using System;

////Таким образом вы определяете свое пространство имен.
//namespace HelloWorld
//{
//    // Таким образом определяется класс.
//    class Program
//    {
//        static void Main()
//        {
//            double x, y;
//            x = double.Parse(Console.ReadLine());
//            y = double.Parse(Console.ReadLine());
//            if (y >= 0 && (x * x >= y) && x >= -1 && x <= 1)
//            {
//                Console.WriteLine("Да");
//            }
//            else
//            {
//                if (y <= 0 && y >= -1 && x >= -1 && x <= 1)
//                {
//                    Console.WriteLine("Да");
//                }
//                else
//                    Console.WriteLine("Нет");
//            }

//        }
//    }
//}
//Таким образом вы определяете свое пространство имен.
//namespace HelloWorld
//{
//    // Таким образом определяется класс.
//    class Program
//    {
//        static void Main()
//        {
//            double x, y;
//            x = double.Parse(Console.ReadLine());
//            y = double.Parse(Console.ReadLine());
//            if (y == 0 && x >= -1 && x <= 0)
//            {
//                Console.WriteLine("Да");
//            }
//            else
//            {
//                if (x >= 0 && x <= 1 && ((y >= 0) && (x >= y) || (y <= 0) && (x <= y)))
//                {
//                    Console.WriteLine("Да");
//                }
//                else
//                    Console.WriteLine("Нет");
//            }

//        }
//    }
//}

//namespace HelloWorld
//{
//    // Таким образом определяется класс.
//    class Program
//    {
//        static void Main()
//        {
//            int k = int.Parse(Console.ReadLine());
//            int result = k;
//            while(k > 1)
//            {
//                result = result * (k - 1);
//                --k;
//            }
//            Console.WriteLine(result);

//        }
//    }
//}

//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main()
//        {
//            int k = int.Parse(Console.ReadLine());
//            int n = int.Parse(Console.ReadLine());
//            while (k != 0 && n != 0)
//            {
//                if(n > k)
//                {
//                    n = n - k;
//                }
//                else
//                {
//                    k = k - n;
//                }

//            }
//            Console.WriteLine(n + k);
//        }
//    }
//}

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            double s = Math.Log(k, 3);
            decimal r = Decimal.Round((decimal)s, 13);
            string str1 = r.ToString();
            int m = (int)s;
            string str2 = m.ToString();
            int dlina1 = str1.Length;
            int dlina2 = str2.Length;
            if (dlina1 == dlina2)
            {
                Console.WriteLine("Это число подходит");
            }
            else
                Console.WriteLine("Это число не подходит");
        }
    }
}
