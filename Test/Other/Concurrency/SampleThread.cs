namespace Test.Other.Concurrency
{
    public class SampleThread
    {
        private bool _done;
        private readonly object _lock = new object();

        public void DoSomething()
        {
            //var threadOne = new Thread(DoOne);
            //threadOne.Start();
            //threadOne.Join();
            //
            //var threadTwo = new Thread(DoTwo);
            //Thread.Sleep(3000);
            //threadTwo.Start();
            //threadTwo.Join();
            //
            //DoThree();

            //var threadDone = new Thread(WriteDone);
            //threadDone.Start();
            //
            //WriteDone();

            //var threadWrite = new Thread(() =>
            //{
            //    WriteString("this thread");
            //});
            //threadWrite.Start();
            //
            //WriteString("without Thread");

            //Task.Run(() =>
            //{
            //    WriteDone();
            //});
            //WriteDone();

            //var task = Task.Run(() =>
            //{
            //    //Thread.Sleep(1000);
            //    Console.WriteLine("Hi");
            //    return "rettuurrn";
            //});
            //
            //string test = task.Result;
            //Console.WriteLine(test);

            //Console.WriteLine(task.IsCompleted);
            //task.Wait();
            //Console.WriteLine(task.IsCompleted);

            var task = Task.Run(() =>
            {
                Thread.Sleep(2000);
                return 504;
            });

            task.ContinueWith(t =>
            {
                int result = t.Result;
                Console.WriteLine(result);
            });

        }

        private void WriteDone()
        {
            lock (_lock)
            {
                if (!_done)
                {
                    Console.WriteLine("done!");
                    _done = true;
                }
            }
        }

        private void WriteString(string something)
        {
            lock(_lock)
            {
                if (!_done)
                {
                    Console.WriteLine(something);
                    _done = true;
                }
            }
        }

        private void DoOne()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("One -> " + i);
            }
        }

        private void DoTwo()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Two -> " + i);
            }
        }

        private void DoThree()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Three -> " + i);
            }
        }
    }
}
