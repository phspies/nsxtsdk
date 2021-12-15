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
    /// This object contains SNMP v2c target/receiver where SNMP traps/notifications will be sent.
    /// </summary>
    [NSXTProperty(Description: @"This object contains SNMP v2c target/receiver where SNMP traps/notifications will be sent.")]
    public class NSXTSnmpv2cTargetType 
    {
        /// <summary>
        /// Unique non-sensitive community name to identify community.
        /// </summary>
        [JsonProperty(PropertyName = "community_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Unique non-sensitive community name to identify community.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CommunityName { get; set; }
        /// <summary>
        /// Community string (shared secret). This field is required when adding a community target. When updating a community
        /// target, do not include this field in the request. If this field is present in an update request, it will be considered
        /// as a new value for community string.
        /// </summary>
        [JsonProperty(PropertyName = "community_string")]
        [NSXTProperty(IsRequired: false, Description: @"Community string (shared secret). This field is required when adding a community target. When updating a community target, do not include this field in the request. If this field is present in an update request, it will be considered as a new value for community string.")]
        public string? CommunityString { get; set; }
        /// <summary>
        /// SNMP v2c target server's port number.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [NSXTProperty(IsRequired: false, Description: @"SNMP v2c target server&apos;s port number.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [NSXTDefaultProperty(Default: "")]
        public long? Port { get; set; }
        /// <summary>
        /// SNMP v2c target server's IP or FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"SNMP v2c target server&apos;s IP or FQDN.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Server { get; set; }
    }
}
