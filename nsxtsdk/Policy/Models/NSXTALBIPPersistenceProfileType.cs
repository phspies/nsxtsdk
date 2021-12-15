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
    /// Advanced load balancer IPPersistenceProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IPPersistenceProfile object")]
    public class NSXTALBIPPersistenceProfileType 
    {
        /// <summary>
        /// Mask to be applied on client IP.
        /// This may be used to persist clients from a subnet to the
        /// same server.
        /// When set to 0, all requests are sent to the same server.
        /// Allowed values are 0-128.
        /// </summary>
        [JsonProperty(PropertyName = "ip_mask")]
        [NSXTProperty(IsRequired: false, Description: @"Mask to be applied on client IP.This may be used to persist clients from a subnet to thesame server.When set to 0, all requests are sent to the same server.Allowed values are 0-128.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(128)]
        public long? IpMask { get; set; }
        /// <summary>
        /// The length of time after a client's connections have closed
        /// before expiring the client's persistence to a server.
        /// Allowed values are 1-720.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 5.
        /// </summary>
        [JsonProperty(PropertyName = "ip_persistent_timeout")]
        [NSXTProperty(IsRequired: false, Description: @"The length of time after a client&apos;s connections have closedbefore expiring the client&apos;s persistence to a server.Allowed values are 1-720.Unit is MIN.Default value when not specified in API or module isinterpreted by ALB Controller as 5.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(720)]
        [NSXTDefaultProperty(Default: "")]
        public long? IpPersistentTimeout { get; set; }
    }
}