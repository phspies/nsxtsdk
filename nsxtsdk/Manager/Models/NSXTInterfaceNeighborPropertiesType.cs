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
    public class NSXTInterfaceNeighborPropertiesType : NSXTManagedResourceType
    {
        /// <summary>
        /// Interface index
        /// </summary>
        public long? Ifindex { get; set; }
        /// <summary>
        /// Neighbor properties
        /// </summary>
        public IList<NSXTNeighborPropertiesType> Neighbors { get; set; }
        /// <summary>
        /// Interface MAC address
        /// </summary>
        public string? Mac { get; set; }
        /// <summary>
        /// Interface Name
        /// </summary>
        public string? Name { get; set; }
    }
}
