using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMessagingClientInfoType 
    {
        /// <summary>
        /// Type of messaging client
        /// </summary>
        [JsonProperty(PropertyName = "client_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMessagingClientInfoClientTypeEnumType? ClientType { get; set; }
        /// <summary>
        /// Account name in messaging client
        /// </summary>
        [JsonProperty(PropertyName = "account_name")]
        public string? AccountName { get; set; }
    }
}
