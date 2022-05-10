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
    public class NSXTInterfaceNeighborPropertiesType : NSXTManagedResourceType
    {
        /// <summary>
        /// Interface index
        /// </summary>
        [JsonProperty(PropertyName = "ifindex")]
        public long? Ifindex { get; set; }
        /// <summary>
        /// Neighbor properties
        /// </summary>
        [JsonProperty(PropertyName = "neighbors")]
        public IList<NSXTNeighborPropertiesType> Neighbors { get; set; }
        /// <summary>
        /// Interface MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// Interface Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
