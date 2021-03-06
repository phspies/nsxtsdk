using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Contains information required to connect to enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Contains information required to connect to enforcement point.")]
    public class NSXTEnforcementPointConnectionInfoType 
    {
        /// <summary>
        /// Value of this property could be Hostname or IP. For instance:
        /// - On an NSX-T MP running on default port, the value could be "10.192.1.1"
        /// - On an NSX-T MP running on custom port, the value could be "192.168.1.1:32789"
        /// - On an NSX-T MP in VMC deployments, the value could be "192.168.1.1:5480/nsxapi"
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_address", Required = Required.AllowNull)]
        public string EnforcementPointAddress { get; set; }
        /// <summary>
        /// Resource Type of Enforcement Point Connection Info.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEnforcementPointConnectionInfoResourceTypeEnumType ResourceType { get; set; }
    }
}
