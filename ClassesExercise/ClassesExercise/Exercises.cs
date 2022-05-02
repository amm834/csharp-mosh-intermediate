namespace ClassesExercise;

using System.Text;
using ClassesExercise;

public class Exercises
{
    public static void Exercise1()
    {
        var stopWatch = new StopWatch();
        var builder = new StringBuilder();
        builder.Append('-', 20);
        builder.AppendLine();
        builder.Append("Stop Watch Program");
        builder.AppendLine();
        builder.Append('-', 20);
        Console.WriteLine(builder);

        while (true)
        {
            var key = Console.ReadKey();
            Console.WriteLine();
            if (key.Key == ConsoleKey.S)
            {
                stopWatch.Start();
                Console.WriteLine(stopWatch.ElapsedTime);
            }
            else if (key.Key == ConsoleKey.E)
            {
                stopWatch.Stop();
                Console.WriteLine(stopWatch.ElapsedTime);
            }
            else
            {
                Console.WriteLine("Program terminated");
                break;
            }
        }
    }
}