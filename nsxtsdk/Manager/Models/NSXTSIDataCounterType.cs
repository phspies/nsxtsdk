// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSIDataCounterType 
    {
        /// <summary>
        /// The total packets or bytes
        /// </summary>
        [JsonProperty(PropertyName = "total", Required = Required.AllowNull)]
        public long Total { get; set; }
        /// <summary>
        /// The multicast and broadcast packets or bytes
        /// </summary>
        public long? MulticastBroadcast { get; set; }
        /// <summary>
        /// The dropped packets or bytes
        /// </summary>
        public long? Dropped { get; set; }
    }
}
