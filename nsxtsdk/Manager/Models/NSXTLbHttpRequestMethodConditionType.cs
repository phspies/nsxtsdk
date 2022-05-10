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
    public class NSXTLbHttpRequestMethodConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// Type of HTTP request method
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpRequestMethodConditionMethodEnumType Method { get; set; }
    }
}
