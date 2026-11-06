using System.EventHandler;

public sealed class MessagePublisher
{
    public event Eventhandler<string>? MessagePublished;

    public void Publish(string message) => MessagePublished?.Invoke(this, message);
}