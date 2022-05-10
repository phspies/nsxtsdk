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
    /// Local site with federation id and epoch.
    /// </summary>
    [NSXTProperty(Description: @"Local site with federation id and epoch.")]
    public class NSXTLocalSiteConfigurationType 
    {
        /// <summary>
        /// Epoch
        /// </summary>
        [JsonProperty(PropertyName = "epoch", Required = Required.AllowNull)]
        public long Epoch { get; set; }
        /// <summary>
        /// Federation id
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "site", Required = Required.AllowNull)]
        public NSXTFederationSiteType Site { get; set; }
    }
}
