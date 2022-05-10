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
    /// 
    /// </summary>
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("TlsInspectionExternalProfile", typeof(NSXTTlsInspectionExternalProfileType))]
    [JsonInheritanceAttribute("TlsInspectionInternalProfile", typeof(NSXTTlsInspectionInternalProfileType))]
    [NSXTProperty(Description: @"")]
    public class NSXTTlsProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Bypass profile  - CA bundle is required if the "invalid_certificate" action is allow.
        /// External profile - CA bundle is always required.
        /// Internal profile - CA bundle is required if "certificate_validation" is turned on.
        /// </summary>
        [JsonProperty(PropertyName = "trusted_ca_bundles")]
        public IList<string> TrustedCaBundles { get; set; }
        /// <summary>
        /// Bypass profile  - CRL is required if the "invalid_certificate" action is allow.
        /// External profile - CRL is always required.
        /// Internal profile - CRL is required if "certificate_validation" is turned on.
        /// </summary>
        [JsonProperty(PropertyName = "crls")]
        public IList<string> Crls { get; set; }
        /// <summary>
        /// Used to indicate an TLS version or Cipher version pre-defined settings mis-match.
        /// </summary>
        [JsonProperty(PropertyName = "attention")]
        public string? Attention { get; set; }
        /// <summary>
        /// Resource type to use as profile type
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsProfileResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Timeout the connection when kept idle. Default is 90 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "idle_connection_timeout")]
        public int? IdleConnectionTimeout { get; set; }
    }
}
