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
    public class NSXTPolicyServiceProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The vendor template key property of actual vendor template. This should be used when multiple templates with same name
        /// exist.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_template_key")]
        public string? VendorTemplateKey { get; set; }
        /// <summary>
        /// List of attributes specific to a partner for which the service is created. These attributes are passed on to the partner
        /// appliance and are opaque to NSX. If a vendor template exposes configurable parameters, then their values are specified
        /// here.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IList<NSXTAttributeType> Attributes { get; set; }
        /// <summary>
        /// The redirection action represents if the packet is exclusively redirected to the service, or if a copy is forwarded to
        /// the service. Redirection action is not applicable to guest introspection service.
        /// </summary>
        [JsonProperty(PropertyName = "redirection_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyServiceProfileRedirectionActionEnumType? RedirectionAction { get; set; }
        /// <summary>
        /// Name of the vendor template for which this Service Profile is being created.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_template_name")]
        public string? VendorTemplateName { get; set; }
    }
}
