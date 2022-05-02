namespace ClassesExercise;

public class Post
{
    private string _title;
    private string _description;
    private Vote vote = new Vote();

    public Post(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public void UpVote()
    {
        vote.UpVote();
    }

    public void DownVote()
    {
        vote.DownVote();
    }

    public int GetTotalUpVotes() => vote.GetUpVotes();
    public int GetTotalDownVotes() => vote.GetDownVotes();
}