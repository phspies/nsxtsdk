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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLiveTraceRequestType : NSXTManagedResourceType
    {
        public NSXTLiveTraceRequestType()
        {
            Timeout = test
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTLiveTraceFilterDataType Filter { get; set; }
        /// <summary>
        /// Timeout in seconds for livetrace session
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        [NSXTProperty(IsRequired: false, Description: @"Timeout in seconds for livetrace session")]
        //[System.ComponentModel.DataAnnotations.MinLength(5)]
        //[System.ComponentModel.DataAnnotations.MaxLength(300)]
        public long? Timeout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTLiveTraceActionConfigType Actions { get; set; }
        /// <summary>
        /// Source logical port
        /// </summary>
        [JsonProperty(PropertyName = "source_lport")]
        [NSXTProperty(IsRequired: false, Description: @"Source logical port")]
        public string? SourceLport { get; set; }
    }
}
