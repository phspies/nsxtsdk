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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBTrafficCloneProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// Specifies if client IP needs to be preserved to clone
        /// destination.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_client_ip")]
        public bool? PreserveClientIp { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Maximum of 10 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "clone_servers")]
        public IList<NSXTALBCloneServerType> CloneServers { get; set; }
    }
}
