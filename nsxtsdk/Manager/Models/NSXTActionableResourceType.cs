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
    public class NSXTActionableResourceType : NSXTManagedResourceType
    {
        public NSXTActionableResourceType()
        {
        }
        /// <summary>
        /// A resource reference on which actions can be performed
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        [NSXTProperty(IsRequired: false, Description: @"A resource reference on which actions can be performed")]
        public string? IpAddress { get; set; }
    }
}
