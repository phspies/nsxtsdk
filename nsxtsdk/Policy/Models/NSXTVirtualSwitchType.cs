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
    public class NSXTVirtualSwitchType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// ID of the virtual switch in compute manager
        /// </summary>
        [JsonProperty(PropertyName = "cm_local_id")]
        public string? CmLocalId { get; set; }
        /// <summary>
        /// External id of the virtual switch
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Switch type like VmwareDistributedVirtualSwitch
        /// </summary>
        [JsonProperty(PropertyName = "origin_type")]
        public string? OriginType { get; set; }
        /// <summary>
        /// ID of the compute manager where this virtual switch is discovered.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
    }
}
