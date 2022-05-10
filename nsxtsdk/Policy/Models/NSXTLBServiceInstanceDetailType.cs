using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBServiceInstanceDetailType 
    {
        /// <summary>
        /// The path of the resource which the load balancer instance deploys on.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_path")]
        public string? AttachmentPath { get; set; }
        /// <summary>
        /// The display name of the resource which the load balancer instance
        /// deploys on.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_display_name")]
        public string? AttachmentDisplayName { get; set; }
        /// <summary>
        /// The error message for the load balancer instance. If the instance
        /// status is NOT_READY, error message will be attached.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
    }
}
