namespace ClassesExercise;

class Program
{
    public static void Main(string[] args)
    {
        var post = new Post("Title", "This is description");
        post.UpVote();
        post.UpVote();

        Console.WriteLine(post.GetTotalUpVotes());
        Console.WriteLine(post.GetTotalDownVotes());
    }
}