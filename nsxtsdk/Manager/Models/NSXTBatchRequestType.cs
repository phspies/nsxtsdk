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
    /// A set of operations to be performed in a single batch
    /// </summary>
    [NSXTProperty(Description: @"A set of operations to be performed in a single batch")]
    public class NSXTBatchRequestType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "requests")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTBatchRequestItemType> Requests { get; set; }
        /// <summary>
        /// Flag to decide if we will continue processing subsequent requests in case of current error for atomic = false.
        /// </summary>
        [JsonProperty(PropertyName = "continue_on_error")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to decide if we will continue processing subsequent requests in case of current error for atomic = false.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? ContinueOnError { get; set; }
    }
}