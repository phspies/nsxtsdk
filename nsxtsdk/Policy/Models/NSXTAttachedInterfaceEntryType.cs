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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The Attached interface is only effective for the segment port on Bare metal server.
    /// </summary>
    [NSXTProperty(Description: @"The Attached interface is only effective for the segment port on Bare metal server.")]
    public class NSXTAttachedInterfaceEntryType 
    {
        public NSXTAttachedInterfaceEntryType()
        {
        }
        /// <summary>
        /// Routing rules
        /// </summary>
        [JsonProperty(PropertyName = "routing_table")]
        [NSXTProperty(IsRequired: false, Description: @"Routing rules")]
        public IList<string> RoutingTable { get; set; }
        /// <summary>
        /// IP configuration on migrate_intf will migrate to app_intf_name. It is used for Management and Application sharing the
        /// same IP.
        /// </summary>
        [JsonProperty(PropertyName = "migrate_intf")]
        [NSXTProperty(IsRequired: false, Description: @"IP configuration on migrate_intf will migrate to app_intf_name. It is used for Management and Application sharing the same IP.")]
        public string? MigrateIntf { get; set; }
        /// <summary>
        /// The name of application interface
        /// </summary>
        [JsonProperty(PropertyName = "app_intf_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The name of application interface")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AppIntfName { get; set; }
        /// <summary>
        /// Gateway IP
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        [NSXTProperty(IsRequired: false, Description: @"Gateway IP")]
        public string? DefaultGateway { get; set; }
    }
}
