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
    /// Global Manager federation configuration. This configuration is distributed
        /// to all Sites participating in federation.
    /// </summary>
    [NSXTProperty(Description: @"Global Manager federation configuration. This configuration is distributedto all Sites participating in federation.")]
    public class NSXTFederationConfigType 
    {
        /// <summary>
        /// Federation configurations of all Sites
        /// </summary>
        [JsonProperty(PropertyName = "site_config")]
        [NSXTProperty(IsRequired: false, Description: @"Federation configurations of all Sites")]
        public IList<NSXTSiteFederationConfigType> SiteConfig { get; set; }
    }
}
