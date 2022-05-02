namespace ClassesExercise;

public class Vote
{
    private int _upVotes = 0;
    private int _downVotes = 0;

    public int GetUpVotes() => _upVotes;
    public int GetDownVotes() => _downVotes;


    public void UpVote()
    {
        _upVotes++;
    }

    public void DownVote()
    {
        _downVotes--;
        if (_downVotes <= 0)
        {
            throw new InvalidOperationException("Down Vote should not be less than 0");
        }
    }
}