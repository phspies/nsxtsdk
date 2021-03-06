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
    public class NSXTVendorTemplateType : NSXTManagedResourceType
    {
        /// <summary>
        /// Different VMs in data center can have Different protection levels as specified by administrator in the policy. The
        /// identifier for the policy with which the partner appliance identifies this policy. This identifier will be passed to the
        /// partner appliance at runtime to specify which protection level is applicable for the VM being protected.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_template_key")]
        public string? VendorTemplateKey { get; set; }
        /// <summary>
        /// List of attributes specific to a partner for which the vendor template is created. There attributes are passed on to the
        /// partner appliance and is opaque to the NSX Manager. Attributes are not supported by guest introspection service.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IList<NSXTAttributeType> Attributes { get; set; }
        /// <summary>
        /// The redirection action represents if the packet is exclusively redirected to the service, or if a copy is forwarded to
        /// the service. Service profile inherits the redirection action specified at the vendor template and cannot override the
        /// action specified at the vendor template. Redirection action is not applicable to guest introspection service.
        /// </summary>
        [JsonProperty(PropertyName = "redirection_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVendorTemplateRedirectionActionEnumType? RedirectionAction { get; set; }
        /// <summary>
        /// The capabilities provided by the services. Needs to be one of the following | NG_FW - Next Generation Firewall | IDS_IPS
        /// - Intrusion detection System / Intrusion Prevention System | NET_MON - Network Monitoring | HCX - Hybrid Cloud Exchange
        /// | BYOD - Bring Your Own Device | EPP - Endpoint Protection.(Third party AntiVirus partners using NXGI should use this
        /// functionality for the service) | MPS - Malware Prevention Solution
        /// </summary>
        [JsonProperty(PropertyName = "functionality")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVendorTemplateFunctionalityEnumType? Functionality { get; set; }
        /// <summary>
        /// The service to which the vendor template belongs.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
    }
}
