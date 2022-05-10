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
    /// Answer of nslookup
    /// </summary>
    [NSXTProperty(Description: @"Answer of nslookup")]
    public class NSXTDnsQueryAnswerType 
    {
        /// <summary>
        /// Unparsed answer string from raw_answer.
        /// </summary>
        [JsonProperty(PropertyName = "raw_string")]
        public string? RawString { get; set; }
        /// <summary>
        /// Matched name of the given address.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Can be resolved ip address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
    }
}
