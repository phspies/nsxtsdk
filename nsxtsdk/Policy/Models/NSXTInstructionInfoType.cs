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
    /// Details of the instructions displayed during restore process
    /// </summary>
    [NSXTProperty(Description: @"Details of the instructions displayed during restore process")]
    public class NSXTInstructionInfoType 
    {
        public NSXTInstructionInfoType()
        {
        }
        /// <summary>
        /// A list of fields that are displayable to users in a table
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        [NSXTProperty(IsRequired: false, Description: @"A list of fields that are displayable to users in a table")]
        public IList<string> Fields { get; set; }
        /// <summary>
        /// UUID of the instruction
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"UUID of the instruction")]
        public string? Id { get; set; }
        /// <summary>
        /// A list of actions that are to be applied to resources
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        [NSXTProperty(IsRequired: false, Description: @"A list of actions that are to be applied to resources")]
        public IList<string> Actions { get; set; }
        /// <summary>
        /// Instruction name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Instruction name")]
        public string? Name { get; set; }
    }
}
