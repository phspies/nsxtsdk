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
    /// BFD configuration for BGP peers
    /// </summary>
    [NSXTProperty(Description: @"BFD configuration for BGP peers")]
    public class NSXTBgpBfdConfigType 
    {
        /// <summary>
        /// Declare dead multiple.
        /// Number of times heartbeat packet is missed before BFD declares the
        /// neighbor is down.
        /// </summary>
        [JsonProperty(PropertyName = "multiple")]
        [NSXTProperty(IsRequired: false, Description: @"Declare dead multiple.Number of times heartbeat packet is missed before BFD declares theneighbor is down.")]
        //[System.ComponentModel.DataAnnotations.MinLength(2)]
        //[System.ComponentModel.DataAnnotations.MaxLength(16)]
        [NSXTDefaultProperty(Default: "")]
        public long? Multiple { get; set; }
        /// <summary>
        /// Time interval between heartbeat packets in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        [NSXTProperty(IsRequired: false, Description: @"Time interval between heartbeat packets in milliseconds.")]
        //[System.ComponentModel.DataAnnotations.MinLength(50)]
        //[System.ComponentModel.DataAnnotations.MaxLength(60000)]
        [NSXTDefaultProperty(Default: "")]
        public long? Interval { get; set; }
        /// <summary>
        /// Flag to enable BFD cofiguration.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable BFD cofiguration.")]
        public bool? Enabled { get; set; }
    }
}