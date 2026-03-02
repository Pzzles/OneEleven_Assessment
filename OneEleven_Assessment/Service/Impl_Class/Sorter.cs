using OneEleven_Assessment.Helpers;
using OneEleven_Assessment.Repo.Contracts;

namespace OneEleven_Assessment.Repo.Impl_Class
{
    public class Sorter : ISorter
    {
        public char[] ManualSort(string input)
        {
            return StringManipulator.ManualSortCharArray(StringManipulator.ManualStringToCharArray(input));
        }

        public char[] MethodSort(string input)
        {
            return StringManipulator.MethodSortCharArray(StringManipulator.MethodStringToCharArray(input));
        }
    }
}
