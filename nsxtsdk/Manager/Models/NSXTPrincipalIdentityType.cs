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
    public class NSXTPrincipalIdentityType : NSXTManagedResourceType
    {
        /// <summary>
        /// Id of the stored certificate. When used with the deprecated POST /trust-management/principal-identities API this field
        /// is required.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_id")]
        public string? CertificateId { get; set; }
        /// <summary>
        /// Indicator whether the entities created by this principal should be protected.
        /// </summary>
        [JsonProperty(PropertyName = "is_protected")]
        public bool? IsProtected { get; set; }
        /// <summary>
        /// The roles that are associated with this PI.
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string? Role { get; set; }
        /// <summary>
        /// Name of the principal.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Unique node-id of a principal. This is used primarily in the case
        /// where a cluster of nodes is used to make calls to the NSX Manager and
        /// the same 'name' is used so that the nodes can access and modify the
        /// same data while still accessing NSX through their individual secret
        /// (certificate or JWT). In all other cases this can be any string.
        /// </summary>
        [JsonProperty(PropertyName = "node_id", Required = Required.AllowNull)]
        public string NodeId { get; set; }
    }
}
