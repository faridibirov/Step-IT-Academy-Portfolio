using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMethod_Server
{
    public class Command
    {
        public const string GET = "get";
        public const string POST = "post";
        public const string PUT = "put";
        public const string DELETE = "delete";
        public string? Text { get; set; }
        public string? Param { get; set; }

    }
}
