using System;

namespace CS_Language_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Value Types

            Byte a = 255;
            SByte b = -127;
            short c = 32000;
            ushort d = 60000;
            int e = 2000000000;
            uint f = 3000000000;
            long g = -999999999999999999;
            ulong h = 5555555555555545555;
            float i = 456.777777f;
            double j = 4444444444.44444444444;
            decimal k = 45552222222222222222222222222.44444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444446546M;
            char l = 'a';
            bool m = true;
                        //Struct and Enum is Value Type too
            Example ex = new Example { x = 10, y = 20};
            int ex_1 = (int)Example_1.FRIDAY;

            //Reference Types
            String n = "Moldova Forever";
            Example_2 ex_2 = new Example_2();
            Console.WriteLine("count is " + Example_2.count);

            //Using of static method
            var result = Example_2.Multiply(ex_2.x, ex_2.y); 
            Console.WriteLine(result);

            //Using of parameters modifiers
            //ref
            var result_1 = Example_2.Multiply(ref c, a);
            Console.WriteLine(result_1);
            //out
            int v;
            int w;
            Console.WriteLine(Example_2.MultiplyForOut(out v, w));
            //params
            Console.WriteLine(Example_2.AdditionUnknownParameters(a, b, c, d));

            //Using of boxing and unboxing
            int z = 100;
            object box = z;
            int p = box;
            Console.WriteLine(z + ", " + box + ", " + p);

            //Static constructor
            Example_2 ex_3 = new Example_2();
            Console.WriteLine("count is " + Example_2.count);            
        }              
    }
    struct Example {
        public int x;
        public int y;
    }
    enum Example_1
    {
        SUNDAY,
        MUNDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY
    }
    class Example_2
    {
        public int x = 10;
        public int y = 20;
        public static int count;

        public Example_2()
        {
            count++;
        }

        public static Example_2()
        {
            count = 1;
            System.Console.WriteLine("First Example_2 instance was created!");
        }

        public static int Multiply(int x, int y)
        {
            return y * x;
        }
        public static int MultiplyForOut(int x, int y)
        {
            x = 20;
            y = 40;
            return y * x;
        }
        public static var AdditionUnknownParameters(params int [] paramsArray)
        {
            var result;
            foreach(var y in paramsArray)
            {
                result += y;
            }
            return reuslt;
        }
    }
};



