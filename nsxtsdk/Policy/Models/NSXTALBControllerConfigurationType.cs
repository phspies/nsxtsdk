// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Alb Controller config details
    /// </summary>
    [NSXTProperty(Description: @"Alb Controller config details")]
    public class NSXTALBControllerConfigurationType 
    {
        /// <summary>
        /// The cluster IP of the Advanced Load Balancer controller node cluster. This is mandatory parameter and
        /// required for single node controller deployments as well.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_ip", Required = Required.AllowNull)]
        public string ClusterIp { get; set; }
        /// <summary>
        /// Username for server authentication.
        /// </summary>
        public string? InfraAdminUsername { get; set; }
        /// <summary>
        /// List of DNS servers.
        /// </summary>
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// List of NTP servers.
        /// </summary>
        public IList<string> NtpServers { get; set; }
        /// <summary>
        /// The policy initiates workflow by LCM/VCF
        /// </summary>
        [JsonProperty(PropertyName = "owned_by", Required = Required.AllowNull)]
        public NSXTAlbcontrollerConfigurationOwnedByEnumType OwnedBy { get; set; }
        /// <summary>
        /// Password for the controller node admin user. For deployment,
        /// this property is required.
        /// The password specified must be at least 8 characters in length.
        /// </summary>
        public string? InfraAdminPassword { get; set; }
    }
}
