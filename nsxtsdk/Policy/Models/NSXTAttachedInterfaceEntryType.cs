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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The Attached interface is only effective for the segment port on Bare metal server.
    /// </summary>
    [NSXTProperty(Description: @"The Attached interface is only effective for the segment port on Bare metal server.")]
    public class NSXTAttachedInterfaceEntryType 
    {
        /// <summary>
        /// Routing rules
        /// </summary>
        public IList<string> RoutingTable { get; set; }
        /// <summary>
        /// IP configuration on migrate_intf will migrate to app_intf_name. It is used for Management and Application sharing the
        /// same IP.
        /// </summary>
        public string? MigrateIntf { get; set; }
        /// <summary>
        /// The name of application interface
        /// </summary>
        [JsonProperty(PropertyName = "app_intf_name", Required = Required.AllowNull)]
        public string AppIntfName { get; set; }
        /// <summary>
        /// Gateway IP
        /// </summary>
        public string? DefaultGateway { get; set; }
    }
}
