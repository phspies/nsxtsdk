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
    /// This type contains attributes of a cluster node that are relevant to the Cluster Boot Manager.
    /// </summary>
    [NSXTProperty(Description: @"This type contains attributes of a cluster node that are relevant to the Cluster Boot Manager.")]
    public class NSXTClusterNodeType 
    {
        /// <summary>
        /// Current clustering status of the node
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Current clustering status of the node")]
        [NSXTDefaultProperty(Default: "REMOVED")]
        public NSXTClusterNodeStatusEnumType? Status { get; set; }
        /// <summary>
        /// Entities on the node
        /// </summary>
        [JsonProperty(PropertyName = "entities", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Entities on the node")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTClusterNodeEntityType> Entities { get; set; }
        /// <summary>
        /// UUID of the node
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"UUID of the node")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NodeUuid { get; set; }
    }
}
