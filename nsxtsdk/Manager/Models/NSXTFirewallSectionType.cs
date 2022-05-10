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
    public class NSXTFirewallSectionType : NSXTDSSectionType
    {
        /// <summary>
        /// Category from policy framework.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string? Category { get; set; }
        /// <summary>
        /// This attribute represents enforcement point of firewall section. For example, firewall section enforced on logical port
        /// with attachment type bridge endpoint will have 'BRIDGEENDPOINT' value, firewall section enforced on logical router will
        /// have 'LOGICALROUTER' value and rest have 'VIF' value.
        /// </summary>
        [JsonProperty(PropertyName = "enforced_on")]
        public string? EnforcedOn { get; set; }
        /// <summary>
        /// Section is locked/unlocked.
        /// </summary>
        [JsonProperty(PropertyName = "locked")]
        public bool? Locked { get; set; }
        /// <summary>
        /// If TCP strict is enabled on a section and a packet matches rule in it, the following check will be performed. If the
        /// packet does not belong to an existing session, the kernel will check to see if the SYN flag of the packet is set. If it
        /// is not, then it will drop the packet.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_strict")]
        public bool? TcpStrict { get; set; }
        /// <summary>
        /// ID of the user who last modified the lock for the section.
        /// </summary>
        [JsonProperty(PropertyName = "lock_modified_by")]
        public string? LockModifiedBy { get; set; }
        /// <summary>
        /// Section locked/unlocked time in epoch milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "lock_modified_time")]
        public long? LockModifiedTime { get; set; }
        /// <summary>
        /// Priority of current section with respect to other sections. In case the field is empty, the list section api should be
        /// used to get section priority.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public long? Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "firewall_schedule")]
        public NSXTResourceReferenceType FirewallSchedule { get; set; }
        /// <summary>
        /// Comments for section lock/unlock.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string? Comments { get; set; }
        /// <summary>
        /// This flag indicates whether it is an auto-plumbed section that is associated to a LogicalRouter. Auto-plumbed sections
        /// are system owned and cannot be updated via the API.
        /// </summary>
        [JsonProperty(PropertyName = "autoplumbed")]
        public bool? Autoplumbed { get; set; }
    }
}
