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
    /// Detailed feedback requests from the migration tool where user input is required.
    /// </summary>
    [NSXTProperty(Description: @"Detailed feedback requests from the migration tool where user input is required.")]
    public class NSXTMigrationFeedbackResponseType 
    {
        /// <summary>
        /// Action selected in response to the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public string Action { get; set; }
        /// <summary>
        /// User input provided in the form of a list of values in response to the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }
        /// <summary>
        /// Identifier of the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// User input provided in response to the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
