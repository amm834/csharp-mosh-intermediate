namespace Polymorphism;

class Program
{
    public static void Main(string[] args)
    {
        var encoder = new VideoEncoder();
        // polymorphic here 
        encoder
            .RegisterNotificationChannel(new MailNotificationChannel())
            .RegisterNotificationChannel(new RealTimeNotificationChannel());
        encoder.Encode(new Video());
    }
}