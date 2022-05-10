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
    /// A single respose in a list of batched responses
    /// </summary>
    [NSXTProperty(Description: @"A single respose in a list of batched responses")]
    public class NSXTBatchResponseItemType 
    {
        /// <summary>
        /// object returned by api
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public object? Body { get; set; }
        /// <summary>
        /// The headers returned by the API call
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public object? Headers { get; set; }
        /// <summary>
        /// http status code
        /// </summary>
        [JsonProperty(PropertyName = "code", Required = Required.AllowNull)]
        public long Code { get; set; }
    }
}
