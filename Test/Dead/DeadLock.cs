namespace Test.Dead
{
    public class DeadLock
    {
        private readonly object _lock1 = new object();
        private readonly object _lock2 = new object();
        public void TestDeadLock()
        {
            
            var task1 = Task.Run(() =>
            {
                lock (_lock1)
                {
                    Thread.Sleep(1000);
                    lock (_lock2)
                    {
                        Console.WriteLine("Task 1 finished");
                    }
                }
            });
            
            var task2 = Task.Run(() => 
            {
                lock (_lock2)
                {
                    Thread.Sleep(1000);
                    lock (_lock1)
                    {
                        Console.WriteLine("Task 2 finished");
                    }
                }
            });

            Task.WaitAll(task1, task2);
        }
    }
}
