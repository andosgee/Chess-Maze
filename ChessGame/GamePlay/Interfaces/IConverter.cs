/// <summary>
/// Provides functionality for compressing and expanding level data.
/// </summary>
public interface IConverter
{
    /// <summary>
    /// Gets the expanded form of the level data.
    /// </summary>
    string Expanded { get; }

    /// <summary>
    /// Gets the compressed form of the level data.
    /// </summary>
    string Compressed { get; }

    /// <summary>
    /// Compresses the provided uncompressed level data.
    /// </summary>
    /// <param name="uncompressedLevel">The uncompressed level data.</param>
    void Compress(string uncompressedLevel);

    /// <summary>
    /// Expands the provided compressed level data.
    /// </summary>
    /// <param name="compressedLevel">The compressed level data.</param>
    void Expand(string compressedLevel);
}