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
    /// Federation configuration.
    /// </summary>
    [NSXTProperty(Description: @"Federation configuration.")]
    public class NSXTFederationConfigurationType 
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
        /// Sites
        /// </summary>
        [JsonProperty(PropertyName = "sites", Required = Required.AllowNull)]
        public IList<NSXTFederationSiteType> Sites { get; set; }
    }
}
