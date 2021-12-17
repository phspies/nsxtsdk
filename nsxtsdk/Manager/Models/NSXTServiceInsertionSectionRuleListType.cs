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
    public class NSXTServiceInsertionSectionRuleListType : NSXTServiceInsertionSectionType
    {
        public NSXTServiceInsertionSectionRuleListType()
        {
        }
        /// <summary>
        /// List of Service Insertion rules in the section. Only homogeneous rules are supported.
        /// </summary>
        [JsonProperty(PropertyName = "rules", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of Service Insertion rules in the section. Only homogeneous rules are supported.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTServiceInsertionRuleType> Rules { get; set; }
    }
}
