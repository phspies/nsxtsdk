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
    [NSXTProperty(Description: @"")]
    public class NSXTALBHTTPPolicySetType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Placeholder for description of property is_internal_policy
        /// of obj type HTTPPolicySet field type str  type boolean.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_internal_policy")]
        public bool? IsInternalPolicy { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for Pool.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http_request_policy")]
        public NSXTALBHTTPRequestPolicyType HttpRequestPolicy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http_response_policy")]
        public NSXTALBHTTPResponsePolicyType HttpResponsePolicy { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http_security_policy")]
        public NSXTALBHTTPSecurityPolicyType HttpSecurityPolicy { get; set; }
    }
}
