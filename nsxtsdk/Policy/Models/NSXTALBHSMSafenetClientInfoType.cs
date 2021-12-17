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
    /// Advanced load balancer HSMSafenetClientInfo object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMSafenetClientInfo object")]
    public class NSXTALBHSMSafenetClientInfoType 
    {
        public NSXTALBHSMSafenetClientInfoType()
        {
        }
        /// <summary>
        /// Name prepended to client key and certificate filename.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name prepended to client key and certificate filename.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClientIp { get; set; }
        /// <summary>
        /// Client Private Key generated by createCert.
        /// </summary>
        [JsonProperty(PropertyName = "client_priv_key")]
        [NSXTProperty(IsRequired: false, Description: @"Client Private Key generated by createCert.")]
        public string? ClientPrivKey { get; set; }
        /// <summary>
        /// Minor number of the sesseion.
        /// </summary>
        [JsonProperty(PropertyName = "session_minor_number")]
        [NSXTProperty(IsRequired: false, Description: @"Minor number of the sesseion.")]
        public long? SessionMinorNumber { get; set; }
        /// <summary>
        /// Generated File - Chrystoki.conf .
        /// </summary>
        [JsonProperty(PropertyName = "chrystoki_conf")]
        [NSXTProperty(IsRequired: false, Description: @"Generated File - Chrystoki.conf .")]
        public string? ChrystokiConf { get; set; }
        /// <summary>
        /// Major number of the sesseion.
        /// </summary>
        [JsonProperty(PropertyName = "session_major_number")]
        [NSXTProperty(IsRequired: false, Description: @"Major number of the sesseion.")]
        public long? SessionMajorNumber { get; set; }
        /// <summary>
        /// Client Certificate generated by createCert.
        /// </summary>
        [JsonProperty(PropertyName = "client_cert")]
        [NSXTProperty(IsRequired: false, Description: @"Client Certificate generated by createCert.")]
        public string? ClientCert { get; set; }
    }
}
