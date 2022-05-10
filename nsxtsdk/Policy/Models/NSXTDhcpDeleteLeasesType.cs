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
    /// List of DHCP leases to be deleted
    /// </summary>
    [NSXTProperty(Description: @"List of DHCP leases to be deleted")]
    public class NSXTDhcpDeleteLeasesType 
    {
        /// <summary>
        /// List of DHCP leases
        /// </summary>
        [JsonProperty(PropertyName = "leases", Required = Required.AllowNull)]
        public IList<NSXTDhcpDeleteLeaseRequestParametersType> Leases { get; set; }
    }
}
