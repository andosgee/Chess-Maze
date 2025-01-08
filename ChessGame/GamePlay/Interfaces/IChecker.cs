/// <summary>
/// Provides functionality for checking data before compression or expansion.
/// </summary>
public interface IChecker
{
    /// <summary>
    /// Performs a pre-expansion check on the input data.
    /// </summary>
    /// <param name="input">The input data to check.</param>
    /// <returns>True if the check passes, otherwise false.</returns>
    bool PreExpandingCheck(string input);

    /// <summary>
    /// Performs a pre-compression check on the input data.
    /// </summary>
    /// <param name="input">The input data to check.</param>
    /// <returns>True if the check passes, otherwise false.</returns>
    bool PreCompressingCheck(string input);
}