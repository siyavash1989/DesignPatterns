namespace Test.Other.Delegates
{
    public class Sample
    {
        public static void RunActionFuncSample()
        {
            Action<int, long> sumAndShowOnConsole = new Action<int, long>(Sum);
            sumAndShowOnConsole(10, 22);

            Func<int, int, long> sumAndShow = new Func<int, int, long>(SumFunc);
            Console.WriteLine(sumAndShow(12, 10));
        }

        public static void Sum(int num1, long num2)
        {
           // Console.WriteLine(num1 + num2);
        }

        public static long SumFunc(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void RunArrowFunctions()
        {
            Action<int, int> sampleAction = (num1, num2) =>
            {
                Console.WriteLine(num1 + num2);
            };

            Func<int, int, long> sampleFunc = (num1, num2) =>
            {
                return (num1 + num2);
            };
        }
    }
}
