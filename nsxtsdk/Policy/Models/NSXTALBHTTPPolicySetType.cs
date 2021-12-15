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
    public class NSXTALBHTTPPolicySetType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Checksum of cloud configuration for Pool.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        [NSXTProperty(IsRequired: false, Description: @"Checksum of cloud configuration for Pool.Internally set by cloud connector.")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        [NSXTProperty(IsRequired: false, Description: @"Creator name.")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// HTTP request policy for the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "http_request_policy")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP request policy for the virtual service.")]
        public NSXTALBHTTPRequestPolicyType HttpRequestPolicy { get; set; }
        /// <summary>
        /// HTTP response policy for the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "http_response_policy")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP response policy for the virtual service.")]
        public NSXTALBHTTPResponsePolicyType HttpResponsePolicy { get; set; }
        /// <summary>
        /// HTTP security policy for the virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "http_security_policy")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP security policy for the virtual service.")]
        public NSXTALBHTTPSecurityPolicyType HttpSecurityPolicy { get; set; }
        /// <summary>
        /// Placeholder for description of property is_internal_policy
        /// of obj type HTTPPolicySet field type str  type boolean.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_internal_policy")]
        [NSXTProperty(IsRequired: false, Description: @"Placeholder for description of property is_internal_policyof obj type HTTPPolicySet field type str  type boolean.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? IsInternalPolicy { get; set; }
    }
}
