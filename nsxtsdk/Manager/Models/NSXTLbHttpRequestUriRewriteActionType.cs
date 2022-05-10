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
    public class NSXTLbHttpRequestUriRewriteActionType : NSXTLbRuleActionType
    {
        /// <summary>
        /// Query string of URI, typically contains key value pairs, for example:
        /// foo1=bar1&foo2=bar2
        /// </summary>
        [JsonProperty(PropertyName = "uri_arguments")]
        public string? UriArguments { get; set; }
        /// <summary>
        /// URI of HTTP request
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
    }
}
