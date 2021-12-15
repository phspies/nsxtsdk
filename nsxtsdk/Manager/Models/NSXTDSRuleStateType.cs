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
    public class NSXTDSRuleStateType : NSXTConfigurationStateType
    {
        /// <summary>
        /// This attribute represents revision number of rule's desired state.
        /// </summary>
        [JsonProperty(PropertyName = "revision_desired")]
        [NSXTProperty(IsRequired: false, Description: @"This attribute represents revision number of rule&apos;s desired state.")]
        public long? RevisionDesired { get; set; }
    }
}
