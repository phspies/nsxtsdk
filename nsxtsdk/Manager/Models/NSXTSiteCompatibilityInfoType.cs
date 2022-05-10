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
    public class NSXTSiteCompatibilityInfoType 
    {
        /// <summary>
        /// Compatibility list
        /// </summary>
        [JsonProperty(PropertyName = "compatibility_list")]
        public IList<string> CompatibilityList { get; set; }
        /// <summary>
        /// Site version
        /// </summary>
        [JsonProperty(PropertyName = "site_version")]
        public string? SiteVersion { get; set; }
    }
}
