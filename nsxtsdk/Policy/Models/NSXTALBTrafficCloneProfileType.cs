// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public string? CloudName { get; set; }
        /// <summary>
        /// Specifies if client IP needs to be preserved to clone
        /// destination.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        public bool? PreserveClientIp { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Maximum of 10 items allowed.
        /// </summary>
        public IList<NSXTALBCloneServerType> CloneServers { get; set; }
    }
}
