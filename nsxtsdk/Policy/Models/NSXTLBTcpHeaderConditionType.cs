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
    public class NSXTLBTcpHeaderConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// TCP source port of HTTP message
        /// </summary>
        [JsonProperty(PropertyName = "source_port", Required = Required.AllowNull)]
        public string SourcePort { get; set; }
    }
}
