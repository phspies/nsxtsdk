using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Data for setting Appliance Proxy certificate for inter-site communication
    /// </summary>
    [NSXTProperty(Description: @"Data for setting Appliance Proxy certificate for inter-site communication")]
    public class NSXTSetInterSiteAphCertificateRequestType 
    {
        /// <summary>
        /// ID of the certificate that is already imported.
        /// </summary>
        [JsonProperty(PropertyName = "cert_id")]
        public string? CertId { get; set; }
        /// <summary>
        /// ID of the node that this certificate is used on.
        /// </summary>
        [JsonProperty(PropertyName = "used_by_id")]
        public string? UsedById { get; set; }
    }
}
