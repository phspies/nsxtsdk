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
    public class NSXTApiErrorType : NSXTRelatedApiErrorType
    {
        /// <summary>
        /// Other errors related to this error
        /// </summary>
        [JsonProperty(PropertyName = "related_errors")]
        public IList<NSXTRelatedApiErrorType> RelatedErrors { get; set; }
    }
}
