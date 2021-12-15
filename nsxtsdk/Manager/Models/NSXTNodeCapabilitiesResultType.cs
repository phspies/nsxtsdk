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
        [NSXTProperty(IsRequired: true, Description: @"Node capability results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTNodeCapabilityType> Capabilities { get; set; }
    }
}