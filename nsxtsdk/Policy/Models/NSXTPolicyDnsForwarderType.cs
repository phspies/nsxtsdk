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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyDnsForwarderType : NSXTPolicyConfigResourceType
    {
        public NSXTPolicyDnsForwarderType()
        {
            LogLevel = test
            CacheSize = test
            Enabled = test
        }
        /// <summary>
        /// Set log_level to DISABLED will stop dumping fowarder log.
        /// </summary>
        [JsonProperty(PropertyName = "log_level")]
        [NSXTProperty(IsRequired: false, Description: @"Set log_level to DISABLED will stop dumping fowarder log.")]
        public NSXTPolicyDnsForwarderLogLevelEnumType? LogLevel { get; set; }
        /// <summary>
        /// Cache size in KB.
        /// </summary>
        [JsonProperty(PropertyName = "cache_size")]
        [NSXTProperty(IsRequired: false, Description: @"Cache size in KB.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(16777216)]
        public int? CacheSize { get; set; }
        /// <summary>
        /// The flag, which suggests whether the DNS forwarder is enabled or
        /// disabled. The default is True.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"The flag, which suggests whether the DNS forwarder is enabled ordisabled. The default is True.")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Max of 5 DNS servers can be configured
        /// </summary>
        [JsonProperty(PropertyName = "conditional_forwarder_zone_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Max of 5 DNS servers can be configured")]
        public IList<string> ConditionalForwarderZonePaths { get; set; }
        /// <summary>
        /// This is the zone to which DNS requests are forwarded by default
        /// </summary>
        [JsonProperty(PropertyName = "default_forwarder_zone_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"This is the zone to which DNS requests are forwarded by default")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DefaultForwarderZonePath { get; set; }
        /// <summary>
        /// This is the IP on which the DNS Forwarder listens.
        /// </summary>
        [JsonProperty(PropertyName = "listener_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"This is the IP on which the DNS Forwarder listens.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ListenerIp { get; set; }
    }
}
