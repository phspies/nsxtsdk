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
    /// Advanced load balancer SamlIdentityProviderSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SamlIdentityProviderSettings object")]
    public class NSXTALBSamlIdentityProviderSettingsType 
    {
        /// <summary>
        /// SAML IDP metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string? Metadata { get; set; }
    }
}
