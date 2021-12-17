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
    public class NSXTVirtualSwitchType : NSXTDiscoveredResourceType
    {
        public NSXTVirtualSwitchType()
        {
        }
        /// <summary>
        /// ID of the virtual switch in compute manager
        /// </summary>
        [JsonProperty(PropertyName = "cm_local_id")]
        [NSXTProperty(IsRequired: false, Description: @"ID of the virtual switch in compute manager")]
        public string? CmLocalId { get; set; }
        /// <summary>
        /// External id of the virtual switch
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        [NSXTProperty(IsRequired: false, Description: @"External id of the virtual switch")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Switch type like VmwareDistributedVirtualSwitch
        /// </summary>
        [JsonProperty(PropertyName = "origin_type")]
        [NSXTProperty(IsRequired: false, Description: @"Switch type like VmwareDistributedVirtualSwitch")]
        public string? OriginType { get; set; }
        /// <summary>
        /// ID of the compute manager where this virtual switch is discovered.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        [NSXTProperty(IsRequired: false, Description: @"ID of the compute manager where this virtual switch is discovered.")]
        public string? OriginId { get; set; }
    }
}
