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
    /// Advanced load balancer HSMSafenetLunaServer object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMSafenetLunaServer object")]
    public class NSXTALBHSMSafenetLunaServerType 
    {
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// IP address of the Safenet/Gemalto HSM device.
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip", Required = Required.AllowNull)]
        public string RemoteIp { get; set; }
        /// <summary>
        /// Serial number of the partition assigned to this client.
        /// </summary>
        [JsonProperty(PropertyName = "partition_serial_number")]
        public string? PartitionSerialNumber { get; set; }
        /// <summary>
        /// CA certificate of the server.
        /// </summary>
        [JsonProperty(PropertyName = "server_cert", Required = Required.AllowNull)]
        public string ServerCert { get; set; }
        /// <summary>
        /// Password of the partition assigned to this client.
        /// </summary>
        [JsonProperty(PropertyName = "partition_passwd")]
        public string? PartitionPasswd { get; set; }
    }
}
