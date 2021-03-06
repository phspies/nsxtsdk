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
    /// Provide details of validation/errors occurred during collection
        /// ,translation and apply phase in MP to Policy promotion.
    /// </summary>
    [NSXTProperty(Description: @"Provide details of validation/errors occurred during collection,translation and apply phase in MP to Policy promotion.")]
    public class NSXTFeedBackType 
    {
        /// <summary>
        /// Manager resource display name
        /// </summary>
        [JsonProperty(PropertyName = "mp_display_name", Required = Required.AllowNull)]
        public string MpDisplayName { get; set; }
        /// <summary>
        /// Error array list
        /// </summary>
        [JsonProperty(PropertyName = "error_list", Required = Required.AllowNull)]
        public IList<NSXTFeedBackErrorMessageType> ErrorList { get; set; }
        /// <summary>
        /// Manager resource id
        /// </summary>
        [JsonProperty(PropertyName = "mp_id", Required = Required.AllowNull)]
        public string MpId { get; set; }
        /// <summary>
        /// Manager resource type
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
    }
}
