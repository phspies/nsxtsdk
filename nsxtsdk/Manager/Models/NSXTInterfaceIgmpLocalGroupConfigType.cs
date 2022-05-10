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
    /// Interface IGMP[Internet Group Management Protocol] configuration parameters.
    /// </summary>
    [NSXTProperty(Description: @"Interface IGMP[Internet Group Management Protocol] configuration parameters.")]
    public class NSXTInterfaceIgmpLocalGroupConfigType 
    {
        /// <summary>
        /// IGMP join group manages the membership of hosts and routing devices in
        /// the multicast group. Host will join the group by conveying its information
        /// through IGMP.
        /// </summary>
        [JsonProperty(PropertyName = "igmp_local_join_groups")]
        public IList<string> IgmpLocalJoinGroups { get; set; }
    }
}
