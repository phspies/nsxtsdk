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
    /// Advanced load balancer HSMThalesRFS object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMThalesRFS object")]
    public class NSXTALBHSMThalesRFSType 
    {
        /// <summary>
        /// IP address of the RFS server from where to sync the Thales
        /// encrypted private key.
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IP address of the RFS server from where to sync the Thalesencrypted private key.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Port at which the RFS server accepts the sync request from
        /// clients for Thales encrypted private key.
        /// Allowed values are 1-65535.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 9004.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [NSXTProperty(IsRequired: false, Description: @"Port at which the RFS server accepts the sync request fromclients for Thales encrypted private key.Allowed values are 1-65535.Default value when not specified in API or module isinterpreted by ALB Controller as 9004.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [NSXTDefaultProperty(Default: "")]
        public long? Port { get; set; }
    }
}
