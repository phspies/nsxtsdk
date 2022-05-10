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
    /// List of capabilities of a fabric node
    /// </summary>
    [NSXTProperty(Description: @"List of capabilities of a fabric node")]
    public class NSXTNodeCapabilitiesResultType 
    {
        /// <summary>
        /// Node capability results
        /// </summary>
        [JsonProperty(PropertyName = "capabilities", Required = Required.AllowNull)]
        public IList<NSXTNodeCapabilityType> Capabilities { get; set; }
    }
}
