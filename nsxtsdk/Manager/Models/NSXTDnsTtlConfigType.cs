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
    /// Firewall to use TTL config to manage firewall cache to expire snooped FQDN entries from DNS response.
    /// </summary>
    [NSXTProperty(Description: @"Firewall to use TTL config to manage firewall cache to expire snooped FQDN entries from DNS response.")]
    public class NSXTDnsTtlConfigType 
    {
        /// <summary>
        /// The number of seconds that snooped DNS responses are retained in the cache. Used only when dns_ttl_type is USE_TTL.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }
        /// <summary>
        /// TTL type to decide how to manage ttl.
        /// </summary>
        [JsonProperty(PropertyName = "dns_ttl_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDnsTtlConfigDnsTtlTypeEnumType DnsTtlType { get; set; }
    }
}
