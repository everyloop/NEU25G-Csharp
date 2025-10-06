
class Publisher
{
    // Deklarera delegattyp och använd för Message ...
    //public delegate void MessageEvent(object sender, MessageEventArgs args);
    //public event MessageEvent Message;

    // ... eller använd generiska EventHandler<> för Message
    public event EventHandler<MessageEventArgs> Message;

    public void SendMessage(string message)
    {
        Message?.Invoke(this, new MessageEventArgs(message));
    }
}
