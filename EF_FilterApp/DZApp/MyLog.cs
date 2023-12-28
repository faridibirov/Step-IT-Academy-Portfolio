using System;
using System.Collections.Generic;

namespace DZApp;

public partial class MyLog
{
    public int Id { get; set; }

    public string LoginName { get; set; } = null!;

    public DateTime PostDate { get; set; }

    public string EventType { get; set; } = null!;

    public string? ObjectName { get; set; }

    public string? ObjectType { get; set; }

    public string? CommandText { get; set; }
}
