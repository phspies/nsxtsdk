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
    public class NSXTPolicyAlarmResourceType : NSXTPolicyResourceType
    {
        /// <summary>
        /// path of the object on which alarm is created
        /// </summary>
        [JsonProperty(PropertyName = "source_reference")]
        public string? SourceReference { get; set; }
        /// <summary>
        /// error message to describe the issue
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "error_details")]
        public NSXTPolicyApiErrorType ErrorDetails { get; set; }
        /// <summary>
        /// This field will refer to the source site on which the alarm is
        /// generated. This field is populated by GM, when it receives
        /// corresponding notification from LM.
        /// </summary>
        [JsonProperty(PropertyName = "source_site_id")]
        public string? SourceSiteId { get; set; }
    }
}
