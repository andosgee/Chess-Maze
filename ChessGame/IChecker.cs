namespace FilerNS
{
    public interface IChecker
    {
        // Nullable Types
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
        bool? PreExpandingCheck(string input);
        bool? PreCompressingCheck(string input);
    }
}
