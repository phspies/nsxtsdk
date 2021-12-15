// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Unparsed answer string from raw_answer.")]
        public string? RawString { get; set; }
        /// <summary>
        /// Matched name of the given address.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Matched name of the given address.")]
        public string? Name { get; set; }
        /// <summary>
        /// Can be resolved ip address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        [NSXTProperty(IsRequired: false, Description: @"Can be resolved ip address.")]
        public string? Address { get; set; }
    }
}