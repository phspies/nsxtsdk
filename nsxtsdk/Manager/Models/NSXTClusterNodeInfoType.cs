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
    public class NSXTClusterNodeInfoType 
    {
        /// <summary>
        /// Node clustering status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Node clustering status")]
        public NSXTClusterNodeInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Messaging client of all entities
        /// </summary>
        [JsonProperty(PropertyName = "msg_clients")]
        [NSXTProperty(IsRequired: false, Description: @"Messaging client of all entities")]
        public IList<NSXTNodeMessagingClientInfoType> MsgClients { get; set; }
        /// <summary>
        /// Unique identifier of this node
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of this node")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// The display name of this node
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"The display name of this node")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Service endpoint of all entities
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        [NSXTProperty(IsRequired: false, Description: @"Service endpoint of all entities")]
        public IList<NSXTNodeEntityInfoType> Entities { get; set; }
        /// <summary>
        /// Certificate and thumbprint of all entities
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        [NSXTProperty(IsRequired: false, Description: @"Certificate and thumbprint of all entities")]
        public IList<NSXTNodeCertificateInfoType> Certificates { get; set; }
        /// <summary>
        /// The fqdn of this node
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        [NSXTProperty(IsRequired: false, Description: @"The fqdn of this node")]
        public string? Fqdn { get; set; }
    }
}
