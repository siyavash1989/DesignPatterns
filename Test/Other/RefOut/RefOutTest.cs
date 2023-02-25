namespace Test.Other.RefOut
{
    public class RefOutTest
    {
        public void Executer()
        {
            int inputRef = 1;
            int inputOut = 2;
            int inputIn = 3;

            OutSample(10, out inputOut);
            RefSample(10, ref inputRef);
            InSample(10, in inputIn);

            Sample(inputOut, inputRef);
        }

        private int OutSample(int input1, out int input2)
        {
            input2 = 12;
            return input1 + input2;
        }

        private int InSample(int input1, in int input2)
        {
            return input1 + input2;
        }

        private int RefSample(int input1, ref int input2)
        {
            input2 = 12;
            return input1 + input2;
        }

        private int Sample(int input1, int input2)
        {
            input2 = 5;
            return input1 + input2;
        }
    }
}
