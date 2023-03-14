using System;
using System.Threading;

namespace lab1
{
    class Program
    {
        bool done;
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "MainThread";
            Thread T = new Thread(F1);
            T.Name = "ChildThread";
            T.Start();
            T.Join();
            F1();
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

        void Obj ()
        {

            if (done)
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

        static void F1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
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
