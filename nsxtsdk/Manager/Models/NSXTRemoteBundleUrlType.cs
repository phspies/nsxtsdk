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
    /// URL of remote bundle which needs to be uploaded.
    /// </summary>
    [NSXTProperty(Description: @"URL of remote bundle which needs to be uploaded.")]
    public class NSXTRemoteBundleUrlType 
    {
        /// <summary>
        /// URL for uploading remote bundle
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
    }
}
