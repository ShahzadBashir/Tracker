namespace Tracker.Domain.Entities;

public class Category
{
    public CategoryId Id { get; private set; } = default!;
    public string Name { get; set; } = string.Empty;
}