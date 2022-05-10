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
        public IList<NSXTSiteFederationConfigType> SiteConfig { get; set; }
    }
}
