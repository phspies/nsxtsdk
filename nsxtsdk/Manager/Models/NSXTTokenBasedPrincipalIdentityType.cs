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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTokenBasedPrincipalIdentityType : NSXTManagedResourceType
    {
        public NSXTTokenBasedPrincipalIdentityType()
        {
        }
        /// <summary>
        /// Unique node-id of a principal. This is used primarily in the case
        /// where a cluster of nodes is used to make calls to the NSX Manager and
        /// the same 'name' is used so that the nodes can access and modify the
        /// same data while still accessing NSX through their individual secret
        /// (certificate or JWT). In all other cases this can be any string.
        /// </summary>
        [JsonProperty(PropertyName = "node_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Unique node-id of a principal. This is used primarily in the casewhere a cluster of nodes is used to make calls to the NSX Manager andthe same &apos;name&apos; is used so that the nodes can access and modify thesame data while still accessing NSX through their individual secret(certificate or JWT). In all other cases this can be any string.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NodeId { get; set; }
        /// <summary>
        /// Name of the principal. This will be matched to the name provided in the token.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of the principal. This will be matched to the name provided in the token.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Indicator whether the entities created by this principal should be protected.
        /// </summary>
        [JsonProperty(PropertyName = "is_protected")]
        [NSXTProperty(IsRequired: false, Description: @"Indicator whether the entities created by this principal should be protected.")]
        public bool? IsProtected { get; set; }
    }
}
