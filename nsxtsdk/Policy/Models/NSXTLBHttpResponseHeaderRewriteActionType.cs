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
    public class NSXTLBHttpResponseHeaderRewriteActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// Value of header field
        /// </summary>
        [JsonProperty(PropertyName = "header_value", Required = Required.AllowNull)]
        public string HeaderValue { get; set; }
        /// <summary>
        /// Name of a header field of HTTP request message.
        /// </summary>
        [JsonProperty(PropertyName = "header_name", Required = Required.AllowNull)]
        public string HeaderName { get; set; }
    }
}
