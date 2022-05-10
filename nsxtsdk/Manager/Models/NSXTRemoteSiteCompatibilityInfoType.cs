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
    public class NSXTRemoteSiteCompatibilityInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_site")]
        public NSXTSiteCompatibilityInfoType RemoteSite { get; set; }
        /// <summary>
        /// are the 2 sites compatible
        /// </summary>
        [JsonProperty(PropertyName = "is_compatible")]
        public bool? IsCompatible { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "local_site")]
        public NSXTSiteCompatibilityInfoType LocalSite { get; set; }
    }
}
