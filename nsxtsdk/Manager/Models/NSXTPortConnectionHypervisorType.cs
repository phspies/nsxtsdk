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
    public class NSXTPortConnectionHypervisorType : NSXTPortConnectionEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pnics")]
        public IList<NSXTPnicType> Pnics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pnics_list")]
        public IList<NSXTNodeInterfacePropertiesType> PnicsList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "neighbors_list")]
        public IList<NSXTInterfaceNeighborPropertiesType> NeighborsList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "profiles")]
        public IList<NSXTBaseHostSwitchProfileType> Profiles { get; set; }
    }
}
