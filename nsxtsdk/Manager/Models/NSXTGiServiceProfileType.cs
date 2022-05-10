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
    public class NSXTGiServiceProfileType : NSXTBaseServiceProfileType
    {
        /// <summary>
        /// Different VMs in data center can have Different protection levels as specified by administrator in the policy. The
        /// identifier for the policy with which the partner appliance identifies this policy. This identifier will be passed to the
        /// partner appliance at runtime to specify which protection level is applicable for the VM being protected.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_template_key")]
        public string? VendorTemplateKey { get; set; }
        /// <summary>
        /// The service to which the service profile belongs.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// ID of the vendor template, created by partner while registering the service.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_template_id", Required = Required.AllowNull)]
        public string VendorTemplateId { get; set; }
    }
}
