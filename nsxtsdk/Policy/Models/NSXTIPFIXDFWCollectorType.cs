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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPFIXDFWCollectorType : NSXTPolicyConfigResourceType
    {
        public NSXTIPFIXDFWCollectorType()
        {
        }
        /// <summary>
        /// IP address for the IPFIX DFW collector.
        /// IP addresses such as 0.0.0.0, 127.0.0.1, 255.255.255.255 are invalid.
        /// </summary>
        [JsonProperty(PropertyName = "collector_ip_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP address for the IPFIX DFW collector.IP addresses such as 0.0.0.0, 127.0.0.1, 255.255.255.255 are invalid.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CollectorIpAddress { get; set; }
        /// <summary>
        /// Port for the IPFIX DFW collector.
        /// </summary>
        [JsonProperty(PropertyName = "collector_port", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Port for the IPFIX DFW collector.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [System.ComponentModel.DataAnnotations.Required]
        public int CollectorPort { get; set; }
    }
}
