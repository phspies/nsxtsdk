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
    /// Network prefix entry
    /// </summary>
    [NSXTProperty(Description: @"Network prefix entry")]
    public class NSXTPrefixEntryType 
    {
        /// <summary>
        /// Action for the prefix list.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPrefixEntryActionEnumType? Action { get; set; }
        /// <summary>
        /// Prefix length greater than or equal to.
        /// </summary>
        [JsonProperty(PropertyName = "ge")]
        public int? Ge { get; set; }
        /// <summary>
        /// Prefix length less than or equal to.
        /// </summary>
        [JsonProperty(PropertyName = "le")]
        public int? Le { get; set; }
        /// <summary>
        /// Network prefix in CIDR format. "ANY" matches all networks.
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        public string Network { get; set; }
    }
}
