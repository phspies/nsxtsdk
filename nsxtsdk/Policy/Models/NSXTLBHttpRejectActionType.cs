using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBHttpRejectActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "reply_status", Required = Required.AllowNull)]
        public string ReplyStatus { get; set; }
        /// <summary>
        /// Response message.
        /// </summary>
        [JsonProperty(PropertyName = "reply_message")]
        public string? ReplyMessage { get; set; }
    }
}
