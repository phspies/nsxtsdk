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
    /// Answer of nslookup
    /// </summary>
    [NSXTProperty(Description: @"Answer of nslookup")]
    public class NSXTNsxTDnsQueryAnswerType 
    {
        /// <summary>
        /// Matched name of the given address.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Resolved IP address matched with the nslookup address provided
        /// as a request parameter.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
    }
}
