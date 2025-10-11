namespace ThreadingExamples1
{
    internal class Program
    {
        static void Main()
        {
            //Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t1 = new Thread(Func1);
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Main1()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.IsBackground = true;
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.IsBackground = true;
            t2.Start();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        
        static void Main2()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Main : " + i);
            }
            t1.Join(); //waiting call
            t2.Join();
            Console.WriteLine("this line should run after t1 and t2");
        }
        //Priority
        static void Main3()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;

            t1.Start();
            t1.Start();

            t2.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }

        //ThreadState
        static void Main4()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t2 = new Thread(Func2);
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

        static void Main5()
        {
            AutoResetEvent wh = new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("f1:" + i);
                    if (i % 50 == 0)
                    {
                        //instead of Suspend, use this
                        Console.WriteLine("waiting");
                        wh.WaitOne();
                    }
                }
            });
            t1.Start();
            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 1....");
            wh.Set();

            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 2....");
            wh.Set();

            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 3....");
            wh.Set();

            Thread.Sleep(5000);
            //Console.ReadLine();
            Console.WriteLine("resuming 4....");
            wh.Set();
        }

        static void Func1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("First : " + i);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Second : " + i);

            }
        }
    }
}

