#region bad example

//interface IMessage
//{
//    void Send();
//    string Text { get; set; }
//    string Subject { get; set; }
//    string ToAddress { get; set; }
//    string FromAddress { get; set; }
//}

//class EmailMessage : IMessage
//{
//    public string Subject { get; set; } = "";
//    public string Text { get; set; } = "";
//    public string FromAddress { get; set; } = "";
//    public string ToAddress { get; set; } = "";

//    public void Send() => Console.WriteLine($"Send Email message {Text}");
//}

//class SmsMessage : IMessage
//{
//    public string Text { get; set; } = "";
//    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public string ToAddress { get; set; } = "";
//    public string FromAddress { get; set; } = "";
//    public void Send() => Console.WriteLine($"Send SMS message {Text}");
//}

#endregion


#region good example

interface IMessage
{
    void Send();
    string ToAddress { get; set; }
    string FromAddress { get; set; }
}

interface ITextMessage : IMessage
{
    string Text { get; set; }
}

interface IEmailMessage : ITextMessage
{
    string Subject { get; set; }
}

class EmailMessage : IEmailMessage
{
    public string Text { get; set; } = "";
    public string Subject { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public string ToAddress { get; set; } = "";

    public void Send() => Console.WriteLine($"Send Email message: {Text}");
}

class SmsMessage : ITextMessage
{
    public string Text { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public string ToAddress { get; set; } = "";
    public void Send() => Console.WriteLine($"Send Sms message: {Text}");
}


#endregion