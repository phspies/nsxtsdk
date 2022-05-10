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
    /// Advanced load balancer HSMAwsCloudHsm object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMAwsCloudHsm object")]
    public class NSXTALBHSMAwsCloudHsmType 
    {
        /// <summary>
        /// AWS CloudHSM Cluster Certificate.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_cert")]
        public string? ClusterCert { get; set; }
        /// <summary>
        /// Username of the Crypto User.
        /// This will be used to access the keys on the HSM .
        /// </summary>
        [JsonProperty(PropertyName = "crypto_user_name")]
        public string? CryptoUserName { get; set; }
        /// <summary>
        /// client_config of HSMAwsCloudHsm.
        /// </summary>
        [JsonProperty(PropertyName = "client_config")]
        public string? ClientConfig { get; set; }
        /// <summary>
        /// Password of the Crypto User.
        /// This will be used to access the keys on the HSM .
        /// </summary>
        [JsonProperty(PropertyName = "crypto_user_password")]
        public string? CryptoUserPassword { get; set; }
        /// <summary>
        /// IP address of the HSM in the cluster.
        /// If there are more than one HSMs, only one is sufficient.
        /// </summary>
        [JsonProperty(PropertyName = "hsm_ip")]
        public IList<string> HsmIp { get; set; }
        /// <summary>
        /// mgmt_config of HSMAwsCloudHsm.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_config")]
        public string? MgmtConfig { get; set; }
    }
}
