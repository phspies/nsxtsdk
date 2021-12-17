// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpHeaderType 
    {
        public NSXTDhcpHeaderType()
        {
            OpCode = test
        }
        /// <summary>
        /// This is used to specify the general type of message. A client sending request to a server uses an op code of
        /// BOOTREQUEST, while a server replying uses an op code of BOOTREPLY.
        /// </summary>
        [JsonProperty(PropertyName = "op_code")]
        [NSXTProperty(IsRequired: false, Description: @"This is used to specify the general type of message. A client sending request to a server uses an op code of BOOTREQUEST, while a server replying uses an op code of BOOTREPLY.")]
        public NSXTDhcpHeaderOpCodeEnumType? OpCode { get; set; }
    }
}
