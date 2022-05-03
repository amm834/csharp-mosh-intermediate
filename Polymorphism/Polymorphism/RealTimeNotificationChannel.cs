namespace Polymorphism;

public class RealTimeNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Real time message sent ...");
    }
}