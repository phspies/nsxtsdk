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
    /// Advanced load balancer SamlSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SamlSettings object")]
    public class NSXTALBSamlSettingsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sp", Required = Required.AllowNull)]
        public NSXTALBSamlServiceProviderSettingsType Sp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "idp")]
        public NSXTALBSamlIdentityProviderSettingsType Idp { get; set; }
    }
}
