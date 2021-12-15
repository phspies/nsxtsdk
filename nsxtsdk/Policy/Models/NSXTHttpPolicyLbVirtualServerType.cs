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
    public class NSXTHttpPolicyLbVirtualServerType : NSXTPolicyLbVirtualServerType
    {
        /// <summary>
        /// Backend web servers typically log each request they handle along with
        /// the requesting client IP address. These logs are used for debugging,
        /// analytics and other such purposes. If the deployment topology requires
        /// enabling SNAT on the load balancer, then server will see the client as
        /// the SNAT IP which defeats the purpose of logging. To work around this
        /// issue, load balancer can be configured to insert XFF HTTP header with
        /// the original client IP address. Backend servers can then be
        /// configured to log the IP address in XFF header instead of the source
        /// IP address of the connection. If XFF header is not present in the
        /// incoming request, load balancer inserts a new XFF header with the
        /// client IP address.
        /// </summary>
        [JsonProperty(PropertyName = "insert_client_ip_header")]
        [NSXTProperty(IsRequired: false, Description: @"Backend web servers typically log each request they handle along withthe requesting client IP address. These logs are used for debugging,analytics and other such purposes. If the deployment topology requiresenabling SNAT on the load balancer, then server will see the client asthe SNAT IP which defeats the purpose of logging. To work around thisissue, load balancer can be configured to insert XFF HTTP header withthe original client IP address. Backend servers can then beconfigured to log the IP address in XFF header instead of the sourceIP address of the connection. If XFF header is not present in theincoming request, load balancer inserts a new XFF header with theclient IP address.")]
        public bool? InsertClientIpHeader { get; set; }
    }
}