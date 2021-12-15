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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalPortMirrorDestinationType : NSXTMirrorDestinationType
    {
        /// <summary>
        /// Destination logical port identifier list.
        /// </summary>
        [JsonProperty(PropertyName = "port_ids", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Destination logical port identifier list.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> PortIds { get; set; }
    }
}