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
    /// An instance of a datasource configuration.
    /// </summary>
    [NSXTProperty(Description: @"An instance of a datasource configuration.")]
    public class NSXTDatasourceType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "keystore_info")]
        public NSXTKeyStoreInfoType KeystoreInfo { get; set; }
        /// <summary>
        /// Name of a datasource instance.
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Array of urls relative to the datasource configuration. For example, api/v1/fabric/nodes is a relative url of
        /// nsx-manager instance.
        /// </summary>
        [JsonProperty(PropertyName = "urls", Required = Required.AllowNull)]
        public IList<NSXTUrlAliasType> Urls { get; set; }
    }
}
