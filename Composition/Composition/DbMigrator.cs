namespace Composition;

public class DbMigrator
{
    private readonly Logger _logger;

    public DbMigrator(Logger logger)
    {
        _logger = logger;
    }

    public void Migrate()
    {
        _logger.Log("Migration files was migrated.");
    }
}