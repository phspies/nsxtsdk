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
    public class NSXTALBTrafficCloneProfileType : NSXTPolicyConfigResourceType
    {
        public NSXTALBTrafficCloneProfileType()
        {
        }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        [NSXTProperty(IsRequired: false, Description: @"It is a reference to an object of type Cloud.")]
        public string? CloudName { get; set; }
        /// <summary>
        /// Specifies if client IP needs to be preserved to clone
        /// destination.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "preserve_client_ip")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies if client IP needs to be preserved to clonedestination.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? PreserveClientIp { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        [NSXTProperty(IsRequired: false, Description: @"List of labels to be used for granular RBAC.Allowed in Basic edition, Essentials edition, Enterpriseedition.")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Maximum of 10 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "clone_servers")]
        [NSXTProperty(IsRequired: false, Description: @"Maximum of 10 items allowed.")]
        public IList<NSXTALBCloneServerType> CloneServers { get; set; }
    }
}
