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
    public class NSXTLbTcpHeaderConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// TCP source port of HTTP message
        /// </summary>
        [JsonProperty(PropertyName = "source_port", Required = Required.AllowNull)]
        public string SourcePort { get; set; }
    }
}
