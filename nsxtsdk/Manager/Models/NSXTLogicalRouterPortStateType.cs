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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalRouterPortStateType : NSXTEdgeConfigurationStateType
    {
        /// <summary>
        /// Array of DAD status which contains DAD information for IP addresses
        /// on the port.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_dad_statuses")]
        public IList<NSXTIPv6DADStatusType> Ipv6DadStatuses { get; set; }
    }
}
