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
    public class NSXTVirtualMachineTagUpdateType 
    {
        /// <summary>
        /// External id of the virtual machine to which tags are to be applied
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// List of tags to be applied to the virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "tags", Required = Required.AllowNull)]
        public IList<NSXTTagType> Tags { get; set; }
    }
}
