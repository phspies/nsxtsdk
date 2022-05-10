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
    /// List of detailed feedback response for the migration tool.
    /// </summary>
    [NSXTProperty(Description: @"List of detailed feedback response for the migration tool.")]
    public class NSXTMigrationFeedbackResponseListType 
    {
        /// <summary>
        /// List of feedback responses.
        /// </summary>
        [JsonProperty(PropertyName = "response_list", Required = Required.AllowNull)]
        public IList<NSXTMigrationFeedbackResponseType> ResponseList { get; set; }
    }
}
