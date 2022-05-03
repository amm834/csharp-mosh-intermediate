﻿namespace Polymorphism;

public class MailNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Mail sent ...");
    }
}