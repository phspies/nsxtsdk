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
    public class NSXTDSRuleStateType : NSXTConfigurationStateType
    {
        /// <summary>
        /// This attribute represents revision number of rule's desired state.
        /// </summary>
        [JsonProperty(PropertyName = "revision_desired")]
        public long? RevisionDesired { get; set; }
    }
}
