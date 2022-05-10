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
    public class NSXTLbHttpRequestVersionConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// HTTP version
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpRequestVersionConditionVersionEnumType Version { get; set; }
    }
}
