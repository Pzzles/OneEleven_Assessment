namespace OneEleven_Assessment.Helpers
{
    public static class StringManipulator
    {
        // CONVERTING
        public static char[] ManualStringToCharArray(string input)
        {
            char[] charArray = new char[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                charArray[i] = input[i];
            }
            
            Console.WriteLine("Manual conversion complete");
            return charArray;
        }
        
        public static char[] MethodStringToCharArray(string input)
        {
            char[] charArr = input.ToCharArray();
            return charArr;
        }

        // SORTIING
        public static char[] ManualSortCharArray(char[] unsortedInput)
        {
            int inputLength = unsortedInput.Length;

            for(int i = 0; i < inputLength - 1; i++)
            { 
                for(int j = 0; j < inputLength - (1 + i); j++)
                {
                    if (unsortedInput[j] > unsortedInput[j + 1])
                        Swap(unsortedInput, j);
                }
            }
            return unsortedInput;
        }
        public static char[] MethodSortCharArray(char[] unsortedInput)
        {
            Array.Sort(unsortedInput);         
            return unsortedInput;
        }

        // UTIL
        private static void Swap(char[] unsortedInput, int j)
        {
            char temp = unsortedInput[j];
            unsortedInput[j] = unsortedInput[j + 1];
            unsortedInput[j + 1] = temp;
        }

    }
}
