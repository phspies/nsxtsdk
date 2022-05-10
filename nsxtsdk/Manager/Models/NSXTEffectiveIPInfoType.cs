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
    /// List of effective ip address along with site id
    /// </summary>
    [NSXTProperty(Description: @"List of effective ip address along with site id")]
    public class NSXTEffectiveIPInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "effective_ips", Required = Required.AllowNull)]
        public IList<string> EffectiveIps { get; set; }
        /// <summary>
        /// Id of the site to which the effective IPs belong to
        /// </summary>
        [JsonProperty(PropertyName = "site_id", Required = Required.AllowNull)]
        public string SiteId { get; set; }
    }
}
