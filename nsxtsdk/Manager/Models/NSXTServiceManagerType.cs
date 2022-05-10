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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTServiceManagerType : NSXTManagedResourceType
    {
        /// <summary>
        /// Integer port value to specify a standard/non-standard HTTPS port.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
        /// <summary>
        /// The IDs of services, provided by partner.
        /// </summary>
        [JsonProperty(PropertyName = "service_ids", Required = Required.AllowNull)]
        public IList<NSXTResourceReferenceType> ServiceIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication_scheme", Required = Required.AllowNull)]
        public NSXTCallbackAuthenticationSchemeType AuthenticationScheme { get; set; }
        /// <summary>
        /// Thumbprint (SHA-256 hash represented in lower case hex) for the certificate on the partner console. This will be
        /// required to establish secure communication with the console and to avoid man-in-the-middle attacks.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
        /// <summary>
        /// Id which is unique to a vendor or partner for which the service is created.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_id")]
        public string? VendorId { get; set; }
        /// <summary>
        /// URI on which notification requests should be made on the specified server.
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
        /// <summary>
        /// IP address or fully qualified domain name of the partner REST server.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
