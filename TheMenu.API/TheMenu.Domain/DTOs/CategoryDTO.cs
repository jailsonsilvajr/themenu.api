namespace TheMenu.Domain.DTOs
{
    public record CategoryDTO
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
    };
}
