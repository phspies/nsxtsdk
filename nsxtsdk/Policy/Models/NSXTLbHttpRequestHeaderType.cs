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
    public class NSXTLbHttpRequestHeaderType 
    {
        /// <summary>
        /// Value of HTTP request header
        /// </summary>
        [JsonProperty(PropertyName = "header_value", Required = Required.AllowNull)]
        public string HeaderValue { get; set; }
        /// <summary>
        /// Name of HTTP request header
        /// </summary>
        [JsonProperty(PropertyName = "header_name", Required = Required.AllowNull)]
        public string HeaderName { get; set; }
    }
}
