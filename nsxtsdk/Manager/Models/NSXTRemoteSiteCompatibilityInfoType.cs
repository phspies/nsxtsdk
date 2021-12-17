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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRemoteSiteCompatibilityInfoType 
    {
        public NSXTRemoteSiteCompatibilityInfoType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_site")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTSiteCompatibilityInfoType RemoteSite { get; set; }
        /// <summary>
        /// are the 2 sites compatible
        /// </summary>
        [JsonProperty(PropertyName = "is_compatible")]
        [NSXTProperty(IsRequired: false, Description: @"are the 2 sites compatible")]
        public bool? IsCompatible { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "local_site")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTSiteCompatibilityInfoType LocalSite { get; set; }
    }
}
