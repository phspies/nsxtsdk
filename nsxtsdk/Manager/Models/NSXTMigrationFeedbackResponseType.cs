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
    /// Detailed feedback requests from the migration tool where user input is required.
    /// </summary>
    [NSXTProperty(Description: @"Detailed feedback requests from the migration tool where user input is required.")]
    public class NSXTMigrationFeedbackResponseType 
    {
        /// <summary>
        /// Action selected in response to the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Action selected in response to the feedback request.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Action { get; set; }
        /// <summary>
        /// User input provided in the form of a list of values in response to the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        [NSXTProperty(IsRequired: false, Description: @"User input provided in the form of a list of values in response to the feedback request.")]
        public IList<string> Values { get; set; }
        /// <summary>
        /// Identifier of the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Identifier of the feedback request.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Id { get; set; }
        /// <summary>
        /// User input provided in response to the feedback request.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [NSXTProperty(IsRequired: false, Description: @"User input provided in response to the feedback request.")]
        public string? Value { get; set; }
    }
}