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
    public class NSXTVlanMirrorSourceType : NSXTMirrorSourceType
    {
        /// <summary>
        /// Source VLAN ID list
        /// </summary>
        [JsonProperty(PropertyName = "vlan_ids", Required = Required.AllowNull)]
        public long VlanIds { get; set; }
    }
}
