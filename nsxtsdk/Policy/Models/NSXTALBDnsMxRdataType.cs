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
    /// Advanced load balancer DnsMxRdata object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsMxRdata object")]
    public class NSXTALBDnsMxRdataType 
    {
        public NSXTALBDnsMxRdataType()
        {
        }
        /// <summary>
        /// The priority field identifies which mail server should be
        /// preferred.
        /// Allowed values are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The priority field identifies which mail server should bepreferred.Allowed values are 0-65535.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Priority { get; set; }
        /// <summary>
        /// Fully qualified domain name of a mailserver.
        /// The host name maps directly to one or more address records
        /// in the DNS table, and must not point to any CNAME records
        /// (RFC 2181).
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Fully qualified domain name of a mailserver.The host name maps directly to one or more address recordsin the DNS table, and must not point to any CNAME records(RFC 2181).")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Host { get; set; }
    }
}
