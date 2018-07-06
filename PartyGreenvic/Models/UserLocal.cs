namespace PartyGreenvic.Models
{
    using SQLite.Net.Attributes;
    public class UserLocal
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Rut { get; set; }
        public override int GetHashCode()
        {
            return UserId;

        }
    }
}