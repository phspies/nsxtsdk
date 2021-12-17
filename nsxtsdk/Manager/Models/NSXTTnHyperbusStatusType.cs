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
    public class NSXTTnHyperbusStatusType 
    {
        public NSXTTnHyperbusStatusType()
        {
        }
        /// <summary>
        /// Display the hyperbus status
        /// </summary>
        [JsonProperty(PropertyName = "hyperbus_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Display the hyperbus status")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTTnHyperbusStatusHyperbusStatusEnumType HyperbusStatus { get; set; }
        /// <summary>
        /// Transport node id.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Transport node id.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TransportNodeId { get; set; }
    }
}
