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
    public class NSXTServiceInsertionServiceProfileType : NSXTBaseServiceProfileType
    {
        /// <summary>
        /// List of attributes specific to a partner for which the service is created. These attributes are passed on to the partner
        /// appliance and are opaque to the NSX Manager. If a vendor template exposes configurables, then the values are specified
        /// here.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IList<NSXTAttributeType> Attributes { get; set; }
        /// <summary>
        /// The service to which the service profile belongs.
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// The redirection action represents if the packet is exclusively redirected to the service, or if a copy is forwarded to
        /// the service. The service insertion profile inherits the redirection action if already specified at the vendor template.
        /// However the service profile cannot overide the action specified at the vendor template.
        /// </summary>
        [JsonProperty(PropertyName = "redirection_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceInsertionServiceProfileRedirectionActionEnumType? RedirectionAction { get; set; }
        /// <summary>
        /// Id of the vendor template to be used by the servive profile.
        /// </summary>
        [JsonProperty(PropertyName = "vendor_template_id", Required = Required.AllowNull)]
        public string VendorTemplateId { get; set; }
    }
}
