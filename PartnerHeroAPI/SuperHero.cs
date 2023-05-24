namespace PartnerHeroAPI
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Place { get;set; } = string.Empty;
        public string IdNumber { get; set; } = string.Empty;
    }
}
