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
    public class NSXTSiteStatusType 
    {
        /// <summary>
        /// Connection status
        /// </summary>
        [JsonProperty(PropertyName = "stubs")]
        public IList<NSXTStubStatusType> Stubs { get; set; }
        /// <summary>
        /// Site name
        /// </summary>
        [JsonProperty(PropertyName = "site_name", Required = Required.AllowNull)]
        public string SiteName { get; set; }
    }
}
