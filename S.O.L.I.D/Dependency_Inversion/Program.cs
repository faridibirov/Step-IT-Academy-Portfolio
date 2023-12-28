#region bad example

//public class Facebook
//{
//    public void Send()
//    {
//        // some code send Facebook notifications
//    }
//}

//public class Instagaram
//{
//    public void Send()
//    {
//        // some code send Instagram notifications
//    }
//}


//public class Notification
//{
//    private Facebook facebook;
//    public Notification()
//    {
//        facebook = new Facebook();
//    }

//    public void FacebookDistribution()
//    {
//        facebook.Send();
//    }
//}

#endregion



#region good example

public interface IMessenger
{
    void Send();
}

public class Facebook : IMessenger
{
    public void Send()
    {
        // some code to send Facebook notifications
    }
}

public class Instagram : IMessenger
{
    public void Send()
    {
        // some code to send Instagram notifications
    }
}


public class Notification
{
    private IMessenger _messenger;
    public Notification(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void DoNotify()
    {
        _messenger.Send();
    }
}


#endregion