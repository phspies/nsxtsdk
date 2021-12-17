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
    public class NSXTMandatoryAccessControlPropertiesType : NSXTResourceType
    {
        public NSXTMandatoryAccessControlPropertiesType()
        {
        }
        /// <summary>
        /// current status of Mandatory Access Control
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"current status of Mandatory Access Control")]
        public NSXTMandatoryAccessControlPropertiesStatusEnumType? Status { get; set; }
        /// <summary>
        /// Enabled can be True/False
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enabled can be True/False")]
        public bool? Enabled { get; set; }
    }
}
