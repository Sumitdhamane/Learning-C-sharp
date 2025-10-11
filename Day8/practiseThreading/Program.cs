using System;

namespace practiseThreading
{
    internal class Program
    {
        static void Main0(string[] args)
        {
            Thread t1 = new Thread(F1);
            t1.Start();
            Thread t2 = new Thread(F2);
            t2.Start();
            for (int i = 0; i < 250; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            static void F1()
            {
                for (int i = 0; i < 250; i++)
                {
                    Console.WriteLine("First :" + i);
                }
            }
            static void F2()
            {
                for (int i = 0; i < 250; i++)
                {
                    Console.WriteLine("Second :" + i);
                }
            }
        }

        static void Main1(string[] args)
        {
            Thread t1 = new Thread(F1);
            t1.IsBackground = true;
            t1.Start();
            Thread t2 = new Thread(F2);
            t2.IsBackground = true;
            t2.Start();
            for (int i = 0; i < 250; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            static void F1()
            {
                for (int i = 0; i < 2550; i++)
                {
                    Console.WriteLine("First :" + i);
                }
            }
            static void F2()
            {
                for (int i = 0; i < 2550; i++)
                {
                    Console.WriteLine("Second :" + i);
                }
            }
        }

        static void Main2(string[] args)
        {
            Thread t1 = new Thread(F1);
            t1.Start();
            Thread t2 = new Thread(F2);
            t2.Start();
            for (int i = 0; i < 250; i++)
            {
                Console.WriteLine("Main: " + i);
            }
            t1.Join();
            t2.Join();
            Console.WriteLine("this line should run after t1 and t2");

            static void F1()
            {
                for (int i = 0; i < 250; i++)
                {
                    Console.WriteLine("First :" + i);
                }
            }
            static void F2()
            {
                for (int i = 0; i < 250; i++)
                {
                    Console.WriteLine("Second :" + i);
                }
            }
        }

        static void Main3(string[] args)
        {
            Thread t1 = new Thread(F1);
            Thread t2 = new Thread(F2);

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            for (int i = 0; i < 250; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            static void F1()
            {
                for (int i = 0; i < 250; i++)
                {
                    Console.WriteLine("First :" + i);
                }
            }
            static void F2()
            {
                for (int i = 0; i < 250; i++)
                {
                    Console.WriteLine("Second :" + i);
                }
            }
        }

        static void Main()
        {

            Thread t1 = new Thread(new ThreadStart(F1));
            Thread t2 = new Thread(F2);
            if (t1.ThreadState == ThreadState.Unstarted)
                t1.Start();
            //t1.Abort();
            //t1.Suspend();
            //t1.Resume();
            //if(t1.ThreadState== ThreadState.)            
            t2.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
                Thread.Sleep(10000);
            }
        }

        static void F1()
            {
                for (int i = 0; i < 2500; i++)
                {
                    Console.WriteLine("First :" + i);
                }
            }
            static void F2()
            {
                for (int i = 0; i < 2000; i++)
                {
                    Console.WriteLine("Second :" + i);
                }
            }
        }
    }

