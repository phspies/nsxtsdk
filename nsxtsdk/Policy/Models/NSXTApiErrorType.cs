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

namespace nsxtsdk.PolicyModels
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
        [NSXTProperty(IsRequired: false, Description: @"Other errors related to this error")]
        public IList<NSXTRelatedApiErrorType> RelatedErrors { get; set; }
    }
}
