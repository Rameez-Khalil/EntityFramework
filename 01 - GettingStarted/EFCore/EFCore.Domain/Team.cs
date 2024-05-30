namespace EFCore.Domain
{
    public class Team : DomainObject {
        public int TeamId { get; set; }
        public string? TeamName { get; set; }
    }
}
