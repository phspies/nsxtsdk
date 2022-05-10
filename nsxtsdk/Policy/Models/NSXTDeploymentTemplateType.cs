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
    /// Deployment Template holds the attributes specific to partner for which the service is created. These attributes are
        /// opaque to NSX.
    /// </summary>
    [NSXTProperty(Description: @"Deployment Template holds the attributes specific to partner for which the service is created. These attributes are opaque to NSX.")]
    public class NSXTDeploymentTemplateType 
    {
        /// <summary>
        /// List of attributes specific to a partner for which the service is created. There attributes are passed on to the partner
        /// appliance and is opaque to the NSX Manager.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IList<NSXTAttributeType> Attributes { get; set; }
        /// <summary>
        /// Deployment Template name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
