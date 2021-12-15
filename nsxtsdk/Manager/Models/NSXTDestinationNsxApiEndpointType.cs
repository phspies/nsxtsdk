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
    /// Details about the destination NSX manager for the migration
    /// </summary>
    [NSXTProperty(Description: @"Details about the destination NSX manager for the migration")]
    public class NSXTDestinationNsxApiEndpointType 
    {
        /// <summary>
        /// IP address or host name of the destination NSX manager to which the config will be migrated.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP address or host name of the destination NSX manager to which the config will be migrated.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DestinationNsxIp { get; set; }
        /// <summary>
        /// Valid password for connecting to the destination NSX manager.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_password")]
        [NSXTProperty(IsRequired: false, Description: @"Valid password for connecting to the destination NSX manager.")]
        public string? DestinationNsxPassword { get; set; }
        /// <summary>
        /// Destination NSX manager port that will be used to apply details.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_port")]
        [NSXTProperty(IsRequired: false, Description: @"Destination NSX manager port that will be used to apply details.")]
        [NSXTDefaultProperty(Default: "")]
        public int? DestinationNsxPort { get; set; }
        /// <summary>
        /// Valid username for connecting to the destination NSX manager.
        /// </summary>
        [JsonProperty(PropertyName = "destination_nsx_username")]
        [NSXTProperty(IsRequired: false, Description: @"Valid username for connecting to the destination NSX manager.")]
        public string? DestinationNsxUsername { get; set; }
    }
}
