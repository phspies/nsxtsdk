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
    /// A single request within a batch of operations
    /// </summary>
    [NSXTProperty(Description: @"A single request within a batch of operations")]
    public class NSXTBatchRequestItemType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public object? Body { get; set; }
        /// <summary>
        /// relative uri (path and args), of the call including resource id (if this is a POST/DELETE), exclude hostname and port
        /// and prefix, exploded form of parameters
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
        /// <summary>
        /// http method type
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBatchRequestItemMethodEnumType Method { get; set; }
    }
}
