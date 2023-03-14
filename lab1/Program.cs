using System;
using System.Threading;

namespace lab1
{
    class Program
    {
        static bool done;
        static void Main(string[] args)
        {
            string text = "Hello World!";
            Thread T = new Thread(delegate() { Stroka(text); });
            text = "HELLO WORLD!!!";
            T.Start();
            Obj(false);
        }

        static void InfinityLoop()
        {
            while (true)
            {
                Console.Write('Y');
            }
        }

        static void LoopWithFor()
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write('Y');
            }
        }

        static void Flag()
        {
            if (!done)
            {
                Console.WriteLine("Done");
                done = true;
            }
        }

        static void Obj (Object obj)
        {
            bool a = (bool)obj;
            if (a)
            {
                Console.WriteLine("HELLO");
            }
            else
            {
                Console.WriteLine("hello");
            }
        }

        static void Stroka(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Point
    {
        int x;
        int y;
        string name;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(int x,int y,string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public int SetX(int value)
        {
            return x = value;
        }
        public int SetY(int value)
        {
            return y = value;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
    }
}
