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
    /// A set of operations to be performed in a single batch
    /// </summary>
    [NSXTProperty(Description: @"A set of operations to be performed in a single batch")]
    public class NSXTBatchRequestType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "requests")]
        public IList<NSXTBatchRequestItemType> Requests { get; set; }
        /// <summary>
        /// Continue even if an error is encountered.
        /// </summary>
        [JsonProperty(PropertyName = "continue_on_error")]
        public bool? ContinueOnError { get; set; }
    }
}
