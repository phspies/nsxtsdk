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
    /// Advanced load balancer SSLClientCertificateAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLClientCertificateAction object")]
    public class NSXTALBSSLClientCertificateActionType 
    {
        /// <summary>
        /// Placeholder for description of property headers of obj type
        /// SSLClientCertificateAction field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IList<NSXTALBSSLClientRequestHeaderType> Headers { get; set; }
        /// <summary>
        /// Placeholder for description of property close_connection of
        /// obj type SSLClientCertificateAction field type str  type
        /// boolean.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "close_connection")]
        public bool? CloseConnection { get; set; }
    }
}
