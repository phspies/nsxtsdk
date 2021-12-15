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
    /// Advanced load balancer HSMSafenetLunaServer object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMSafenetLunaServer object")]
    public class NSXTALBHSMSafenetLunaServerType 
    {
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Number of index.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Index { get; set; }
        /// <summary>
        /// IP address of the Safenet/Gemalto HSM device.
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP address of the Safenet/Gemalto HSM device.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RemoteIp { get; set; }
        /// <summary>
        /// Serial number of the partition assigned to this client.
        /// </summary>
        [JsonProperty(PropertyName = "partition_serial_number")]
        [NSXTProperty(IsRequired: false, Description: @"Serial number of the partition assigned to this client.")]
        public string? PartitionSerialNumber { get; set; }
        /// <summary>
        /// CA certificate of the server.
        /// </summary>
        [JsonProperty(PropertyName = "server_cert", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"CA certificate of the server.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ServerCert { get; set; }
        /// <summary>
        /// Password of the partition assigned to this client.
        /// </summary>
        [JsonProperty(PropertyName = "partition_passwd")]
        [NSXTProperty(IsRequired: false, Description: @"Password of the partition assigned to this client.")]
        public string? PartitionPasswd { get; set; }
    }
}
