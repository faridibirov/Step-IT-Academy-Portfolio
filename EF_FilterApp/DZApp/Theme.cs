using System;
using System.Collections.Generic;

namespace DZApp;

public partial class Theme
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; } = new List<Book>();

    public override string ToString()
    {
        return $"{Name}";
    }
}
