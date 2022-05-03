namespace Polymorphism;

public class VideoEncoder
{
    private readonly IList<INotificationChannel> _notificationChannels = new List<INotificationChannel>();

    public void Encode(Video video)
    {
        foreach (var notificationChannel in _notificationChannels)
        {
            // polymorphic here
            notificationChannel.Send(new Message());
        }

    }

    public VideoEncoder RegisterNotificationChannel(INotificationChannel notificationChannel)
    {
        _notificationChannels.Add(notificationChannel);
        return this;
    }
}