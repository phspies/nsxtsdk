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
    /// Details of the instructions displayed during restore process
    /// </summary>
    [NSXTProperty(Description: @"Details of the instructions displayed during restore process")]
    public class NSXTInstructionInfoType 
    {
        /// <summary>
        /// A list of fields that are displayable to users in a table
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public IList<string> Fields { get; set; }
        /// <summary>
        /// UUID of the instruction
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// A list of actions that are to be applied to resources
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<string> Actions { get; set; }
        /// <summary>
        /// Instruction name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
