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
    /// URL and other fetch requests of upgrade bundle
    /// </summary>
    [NSXTProperty(Description: @"URL and other fetch requests of upgrade bundle")]
    public class NSXTUpgradeBundleFetchRequestType 
    {
        /// <summary>
        /// URL for uploading upgrade bundle
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
    }
}
