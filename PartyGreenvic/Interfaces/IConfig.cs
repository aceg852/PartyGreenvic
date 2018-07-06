namespace PartyGreenvic.Interfaces
{
    using SQLite.Net.Interop;
    public interface IConfig
    {
        string DirectoryBD { get; }
        ISQLitePlatform Platform { get; }
    }
}