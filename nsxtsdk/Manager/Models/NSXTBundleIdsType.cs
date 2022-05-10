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
    /// Contains a list of bundle-ids.
    /// </summary>
    [NSXTProperty(Description: @"Contains a list of bundle-ids.")]
    public class NSXTBundleIdsType 
    {
        /// <summary>
        /// Id of a bundle whose upload is successful.
        /// </summary>
        [JsonProperty(PropertyName = "successful")]
        public string? Successful { get; set; }
        /// <summary>
        /// Id of a bundle whose upload was failed.
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        public string? Failed { get; set; }
        /// <summary>
        /// Id of a bundle whose upload is in-progress.
        /// </summary>
        [JsonProperty(PropertyName = "in_progress")]
        public string? InProgress { get; set; }
    }
}
