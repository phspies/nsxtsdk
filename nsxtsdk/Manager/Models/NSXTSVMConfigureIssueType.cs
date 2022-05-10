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
    /// Type of issue and detailed description of the issues in case of post-VM  deployment configuration failure.
    /// </summary>
    [NSXTProperty(Description: @"Type of issue and detailed description of the issues in case of post-VM  deployment configuration failure.")]
    public class NSXTSVMConfigureIssueType 
    {
        /// <summary>
        /// List of errors along with details like errorId and error messages.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<NSXTSIErrorClassType> Errors { get; set; }
        /// <summary>
        /// The ID of service instance which was deployed.
        /// </summary>
        [JsonProperty(PropertyName = "service_instance_id")]
        public string? ServiceInstanceId { get; set; }
    }
}
