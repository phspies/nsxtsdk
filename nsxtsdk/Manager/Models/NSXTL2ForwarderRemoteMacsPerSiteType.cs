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
    public class NSXTL2ForwarderRemoteMacsPerSiteType 
    {
        /// <summary>
        /// Remote standby IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_standby_ips")]
        public IList<string> RemoteStandbyIps { get; set; }
        /// <summary>
        /// 32 bit unique RTEP group id of the logical switch per site.
        /// </summary>
        [JsonProperty(PropertyName = "rtep_group_id")]
        public long? RtepGroupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_site")]
        public NSXTResourceReferenceType RemoteSite { get; set; }
        /// <summary>
        /// Remote active IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_active_ips")]
        public IList<string> RemoteActiveIps { get; set; }
        /// <summary>
        /// Remote mac addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_mac_addresses")]
        public IList<string> RemoteMacAddresses { get; set; }
    }
}
