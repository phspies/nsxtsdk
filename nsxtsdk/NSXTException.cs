using nsxtsdk.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nsxtsdk
{
    public partial class NSXTException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public IList<Parameter> Headers { get; private set; }

        public NSXTException(string message, int statusCode, string response, IList<Parameter> headers, Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }
}
