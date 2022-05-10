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
    public class NSXTLBHttpRequestMethodConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// Type of HTTP request method
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpRequestMethodConditionMethodEnumType Method { get; set; }
    }
}
