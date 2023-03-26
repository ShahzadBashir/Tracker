namespace Tracker.Persistence.Repositories;

public class CategoryRepository
{
    private readonly TrackerDbContext _dbContext;

    public CategoryRepository(TrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}