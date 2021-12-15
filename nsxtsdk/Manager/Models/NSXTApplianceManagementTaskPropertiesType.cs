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
    public class NSXTApplianceManagementTaskPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Current status of the task
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Current status of the task")]
        public NSXTApplianceManagementTaskPropertiesStatusEnumType? Status { get; set; }
        /// <summary>
        /// True if response for asynchronous request is available
        /// </summary>
        [JsonProperty(PropertyName = "async_response_available")]
        [NSXTProperty(IsRequired: false, Description: @"True if response for asynchronous request is available")]
        public bool? AsyncResponseAvailable { get; set; }
        /// <summary>
        /// Description of the task
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [NSXTProperty(IsRequired: false, Description: @"Description of the task")]
        public string? Description { get; set; }
        /// <summary>
        /// The start time of the task in epoch milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        [NSXTProperty(IsRequired: false, Description: @"The start time of the task in epoch milliseconds")]
        public long? StartTime { get; set; }
        /// <summary>
        /// Details about the task if known
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        [NSXTProperty(IsRequired: false, Description: @"Details about the task if known")]
        public object? Details { get; set; }
        /// <summary>
        /// True if this task can be canceled
        /// </summary>
        [JsonProperty(PropertyName = "cancelable")]
        [NSXTProperty(IsRequired: false, Description: @"True if this task can be canceled")]
        public bool? Cancelable { get; set; }
        /// <summary>
        /// HTTP request method
        /// </summary>
        [JsonProperty(PropertyName = "request_method")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP request method")]
        public string? RequestMethod { get; set; }
        /// <summary>
        /// The end time of the task in epoch milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        [NSXTProperty(IsRequired: false, Description: @"The end time of the task in epoch milliseconds")]
        public long? EndTime { get; set; }
        /// <summary>
        /// Task progress if known, from 0 to 100
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        [NSXTProperty(IsRequired: false, Description: @"Task progress if known, from 0 to 100")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(100)]
        public long? Progress { get; set; }
        /// <summary>
        /// A message describing the disposition of the task
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        [NSXTProperty(IsRequired: false, Description: @"A message describing the disposition of the task")]
        public string? Message { get; set; }
        /// <summary>
        /// Name of the user who created this task
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the user who created this task")]
        public string? User { get; set; }
        /// <summary>
        /// Identifier for this task
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier for this task")]
        public string? Id { get; set; }
        /// <summary>
        /// URI of the method invocation that spawned this task
        /// </summary>
        [JsonProperty(PropertyName = "request_uri")]
        [NSXTProperty(IsRequired: false, Description: @"URI of the method invocation that spawned this task")]
        public string? RequestUri { get; set; }
    }
}
