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
    public class NSXTAgentStatusType 
    {
        /// <summary>
        /// Agent status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAgentStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Agent name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAgentStatusNameEnumType? Name { get; set; }
    }
}
