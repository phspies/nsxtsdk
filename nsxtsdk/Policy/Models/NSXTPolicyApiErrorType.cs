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
    public class NSXTPolicyApiErrorType : NSXTPolicyRelatedApiErrorType
    {
        /// <summary>
        /// Other errors related to this error
        /// </summary>
        [JsonProperty(PropertyName = "related_errors")]
        public IList<NSXTPolicyRelatedApiErrorType> RelatedErrors { get; set; }
    }
}
