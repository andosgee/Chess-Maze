namespace FilerNS
{
    public interface IConverter
    {
        string Expanded { get; }
        string Compressed { get; }
        void Compress(string uncompressedLevel);
        void Expand(string compressedLevel);
    }
}
