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
    /// Identity Firewall standalone hosts switch setting. This setting enables or
        /// disables Identity Firewall feature on all standalone hosts.
    /// </summary>
    [NSXTProperty(Description: @"Identity Firewall standalone hosts switch setting. This setting enables ordisables Identity Firewall feature on all standalone hosts.")]
    public class NSXTIdfwStandaloneHostsSwitchSettingType 
    {
        /// <summary>
        /// IDFW standalone hosts switch (true=Enabled / false=Disabled).
        /// </summary>
        [JsonProperty(PropertyName = "standalone_hosts_enabled", Required = Required.AllowNull)]
        public bool StandaloneHostsEnabled { get; set; }
    }
}
