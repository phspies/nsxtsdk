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
    public class NSXTDataCounterType 
    {
        /// <summary>
        /// The total packets or bytes
        /// </summary>
        [JsonProperty(PropertyName = "total", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The total packets or bytes")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Total { get; set; }
        /// <summary>
        /// The multicast and broadcast packets or bytes
        /// </summary>
        [JsonProperty(PropertyName = "multicast_broadcast")]
        [NSXTProperty(IsRequired: false, Description: @"The multicast and broadcast packets or bytes")]
        public long? MulticastBroadcast { get; set; }
        /// <summary>
        /// The dropped packets or bytes
        /// </summary>
        [JsonProperty(PropertyName = "dropped")]
        [NSXTProperty(IsRequired: false, Description: @"The dropped packets or bytes")]
        public long? Dropped { get; set; }
    }
}
