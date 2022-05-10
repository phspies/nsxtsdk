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
    public class NSXTTaskPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Current status of the task
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTaskPropertiesStatusEnumType? Status { get; set; }
        /// <summary>
        /// True if response for asynchronous request is available
        /// </summary>
        [JsonProperty(PropertyName = "async_response_available")]
        public bool? AsyncResponseAvailable { get; set; }
        /// <summary>
        /// Description of the task
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The start time of the task in epoch milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }
        /// <summary>
        /// True if this task can be canceled
        /// </summary>
        [JsonProperty(PropertyName = "cancelable")]
        public bool? Cancelable { get; set; }
        /// <summary>
        /// HTTP request method
        /// </summary>
        [JsonProperty(PropertyName = "request_method")]
        public string? RequestMethod { get; set; }
        /// <summary>
        /// Name of the user who created this task
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
        /// <summary>
        /// Task progress if known, from 0 to 100
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public long? Progress { get; set; }
        /// <summary>
        /// A message describing the disposition of the task
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// URI of the method invocation that spawned this task
        /// </summary>
        [JsonProperty(PropertyName = "request_uri")]
        public string? RequestUri { get; set; }
        /// <summary>
        /// Identifier for this task
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// The end time of the task in epoch milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public long? EndTime { get; set; }
    }
}
