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
    /// Port Connection Containers Entities
    /// </summary>
    [NSXTProperty(Description: @"Port Connection Containers Entities")]
    public class NSXTPortConnectionContainersEntitiesType 
    {
        public NSXTPortConnectionContainersEntitiesType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_ports")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTLogicalPortType> LogicalPorts { get; set; }
    }
}
