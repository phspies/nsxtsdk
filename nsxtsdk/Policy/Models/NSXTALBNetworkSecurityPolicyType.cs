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
    public class NSXTALBNetworkSecurityPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Placeholder for description of property rules of obj type
        /// NetworkSecurityPolicy field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBNetworkSecurityRuleType> Rules { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for Network Sec Policy.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
    }
}
