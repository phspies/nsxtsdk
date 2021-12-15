using nsxtsdk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nsxtsdk
{
    public class NSXTException : System.Exception
    {

        public string Error { get; }

        public NSXTException()
        {
        }
        public NSXTException(string message) : base(message)
        {
        }
        public NSXTException(string message, string error) : this(message)
        {
            Error = error;
        }
    }
}
