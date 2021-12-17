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
    public class NSXTStubStatusType 
    {
        public NSXTStubStatusType()
        {
        }
        /// <summary>
        /// Is stub up
        /// </summary>
        [JsonProperty(PropertyName = "connection_up", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Is stub up")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool ConnectionUp { get; set; }
        /// <summary>
        /// IP/FQDN of the node
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        [NSXTProperty(IsRequired: false, Description: @"IP/FQDN of the node")]
        public string? Address { get; set; }
    }
}