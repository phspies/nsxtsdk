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
    public class NSXTNodeEntityInfoType 
    {
        /// <summary>
        /// IP address of service provider
        /// </summary>
        public string? IpAddress { get; set; }
        /// <summary>
        /// Port number of service provider
        /// </summary>
        public long? Port { get; set; }
        /// <summary>
        /// Entity type of this service endpoint
        /// </summary>
        public NSXTNodeEntityInfoEntityTypeEnumType? EntityType { get; set; }
    }
}
