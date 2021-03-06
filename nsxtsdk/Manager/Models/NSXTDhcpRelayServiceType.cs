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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpRelayServiceType : NSXTManagedResourceType
    {
        /// <summary>
        /// dhcp relay profile referenced by the dhcp relay service
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_relay_profile_id", Required = Required.AllowNull)]
        public string DhcpRelayProfileId { get; set; }
    }
}
