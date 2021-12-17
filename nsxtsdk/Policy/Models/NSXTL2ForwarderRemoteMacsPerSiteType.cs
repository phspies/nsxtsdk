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
    public class NSXTL2ForwarderRemoteMacsPerSiteType 
    {
        public NSXTL2ForwarderRemoteMacsPerSiteType()
        {
        }
        /// <summary>
        /// Remote standby IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_standby_ips")]
        [NSXTProperty(IsRequired: false, Description: @"Remote standby IP addresses.")]
        public IList<string> RemoteStandbyIps { get; set; }
        /// <summary>
        /// 32 bit unique RTEP group id of the logical switch per site.
        /// </summary>
        [JsonProperty(PropertyName = "rtep_group_id")]
        [NSXTProperty(IsRequired: false, Description: @"32 bit unique RTEP group id of the logical switch per site.")]
        public long? RtepGroupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_site")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTResourceReferenceType RemoteSite { get; set; }
        /// <summary>
        /// Remote active IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_active_ips")]
        [NSXTProperty(IsRequired: false, Description: @"Remote active IP addresses.")]
        public IList<string> RemoteActiveIps { get; set; }
        /// <summary>
        /// Remote mac addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_mac_addresses")]
        [NSXTProperty(IsRequired: false, Description: @"Remote mac addresses.")]
        public IList<string> RemoteMacAddresses { get; set; }
    }
}
