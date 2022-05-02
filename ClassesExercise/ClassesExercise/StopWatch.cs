namespace ClassesExercise;

public class StopWatch
{
    private DateTime _startingTime;
    private DateTime _endingTime;
    private bool _isRunning;

    public void Start()
    {
        if (_isRunning)
            throw new InvalidOperationException("Stop watch is currently running");

        _startingTime = DateTime.Now;
        _isRunning = true;
    }

    public void Stop()
    {
        if (!_isRunning)
            throw new InvalidOperationException("Stop watch is currently running");

        _endingTime = DateTime.Now;
        _isRunning = false;
    }

    public TimeSpan ElapsedTime
    {
        get
        {
            _startingTime = _startingTime.AddSeconds(1);
            return _startingTime - _endingTime;
        }
    }

    public string ElapsedTimeInFormat
    {
        get
        {
            var hours = ElapsedTime.Hours;
            var minute = ElapsedTime.Minutes;
            var second = ElapsedTime.Seconds;

            return string.Format("{0}:{1}:{2}", hours, minute, second);
        }
    }
}