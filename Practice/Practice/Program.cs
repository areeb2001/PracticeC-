using System;

namespace Practice
{
    // out parameter
    //class Program
    //{
    //    public void show(out int num1, out int num2)
    //    {
    //        int square = Convert.ToInt32(Console.ReadLine());
    //        num1 = square;
    //        num2 = square;

    //        num1 *= num1;
    //        num2 *= num2;

    //    }
    //    static void Main(string[] args)
    //    {
    //        int a = 23;
    //        int b = 22;
    //        Program p1 = new Program();
    //        Console.WriteLine("Before out "+"para1= "+ a+"  "+"para2= "+b);
    //        p1.show(out a,out b);
    //        Console.WriteLine("after out "+ "para1= "+ a+ "  "+"para2= "+ b);
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("You are not eligible to vote!");
            Console.WriteLine("Enter you age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto start;
            }
            else
            {
                Console.WriteLine("You are  eligible to vote!");
            }
        }

    }
}
