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
    public class NSXTNvdsUpgradeConfigIssueType : NSXTManagedResourceType
    {
        /// <summary>
        /// Recommendation to resolve the error returned for component
        /// </summary>
        [JsonProperty(PropertyName = "recommendation")]
        public string? Recommendation { get; set; }
        /// <summary>
        /// Name of the component/object
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string? Component { get; set; }
        /// <summary>
        /// Id of the object that generated error
        /// </summary>
        [JsonProperty(PropertyName = "objid")]
        public string? Objid { get; set; }
        /// <summary>
        /// Error for the component describing precheck failure
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
    }
}
