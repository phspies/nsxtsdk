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
    /// Details about the destination NSX manager for the migration
    /// </summary>
    [NSXTProperty(Description: @"Details about the destination NSX manager for the migration")]
    public class NSXTDestinationNsxApiEndpointType 
    {
        /// <summary>
        /// IP address or host name of the destination NSX manager to which the config will be migrated.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_ip", Required = Required.AllowNull)]
        public string DestinationNsxIp { get; set; }
        /// <summary>
        /// Valid password for connecting to the destination NSX manager.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_password")]
        public string? DestinationNsxPassword { get; set; }
        /// <summary>
        /// Destination NSX manager port that will be used to apply details.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_port")]
        public int? DestinationNsxPort { get; set; }
        /// <summary>
        /// Valid username for connecting to the destination NSX manager.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_username")]
        public string? DestinationNsxUsername { get; set; }
    }
}
