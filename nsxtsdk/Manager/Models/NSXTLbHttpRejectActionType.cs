// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLbHttpRejectActionType : NSXTLbRuleActionType
    {
        /// <summary>
        /// HTTP response status code
        /// </summary>
        [JsonProperty(PropertyName = "reply_status", Required = Required.AllowNull)]
        public string ReplyStatus { get; set; }
        /// <summary>
        /// Response message
        /// </summary>
        public string? ReplyMessage { get; set; }
    }
}
