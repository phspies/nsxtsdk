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
    /// Provide details of error_id and error description for errors occurred during collection
        /// ,translation and apply phase in MP to Policy promotion.
    /// </summary>
    [NSXTProperty(Description: @"Provide details of error_id and error description for errors occurred during collection,translation and apply phase in MP to Policy promotion.")]
    public class NSXTFeedBackErrorMessageType 
    {
        /// <summary>
        /// Error description due to which promotion is not successful.
        /// </summary>
        [JsonProperty(PropertyName = "error_desc", Required = Required.AllowNull)]
        public string ErrorDesc { get; set; }
        /// <summary>
        /// Error Id due to which promotion is not successful.
        /// </summary>
        [JsonProperty(PropertyName = "error_id", Required = Required.AllowNull)]
        public string ErrorId { get; set; }
    }
}
