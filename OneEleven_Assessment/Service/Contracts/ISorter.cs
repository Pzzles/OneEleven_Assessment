namespace OneEleven_Assessment.Repo.Contracts
{
    public interface ISorter
    {
        public char[] ManualSort(string input);
        public char[] MethodSort(string input);
    }
}
