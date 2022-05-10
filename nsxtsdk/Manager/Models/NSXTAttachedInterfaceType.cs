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
    /// The Attached interface is only effective for the port on Bare metal server.
    /// </summary>
    [NSXTProperty(Description: @"The Attached interface is only effective for the port on Bare metal server.")]
    public class NSXTAttachedInterfaceType 
    {
        /// <summary>
        /// Routing rules
        /// </summary>
        [JsonProperty(PropertyName = "routing_table")]
        public IList<string> RoutingTable { get; set; }
        /// <summary>
        /// IP configuration on migrate_intf will migrate to app_intf_name. It is used for Management and Application sharing the
        /// same IP.
        /// </summary>
        [JsonProperty(PropertyName = "migrate_intf")]
        public string? MigrateIntf { get; set; }
        /// <summary>
        /// The name of application interface
        /// </summary>
        [JsonProperty(PropertyName = "app_intf_name", Required = Required.AllowNull)]
        public string AppIntfName { get; set; }
        /// <summary>
        /// Gateway IP
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        public string? DefaultGateway { get; set; }
    }
}
