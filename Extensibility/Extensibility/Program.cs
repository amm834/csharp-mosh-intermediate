namespace Extensibility;

class Program
{
    /// <inheritdoc />
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log("error", message);
        }

        public void LogInfo(string message)
        {
            Log("info", message);
        }

        private void Log(string loggingType, string message)
        {
            using var writer = new StreamWriter(_path,true);
            writer.WriteLine($"{loggingType.ToUpper()}: {message}");
        }
    }

    public static void Main(string[] args)
    {
        var migrator = new DbMigrator(new FileLogger(@"c:\tmp\log.txt"));
        migrator.Migrate();
    }
}