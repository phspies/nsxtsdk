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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTagBulkOperationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of resources on which tag needs to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "apply_to")]
        public IList<NSXTResourceInfoType> ApplyTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tag", Required = Required.AllowNull)]
        public NSXTTagType Tag { get; set; }
        /// <summary>
        /// List of resources from which tag needs to be removed.
        /// </summary>
        [JsonProperty(PropertyName = "remove_from")]
        public IList<NSXTResourceInfoType> RemoveFrom { get; set; }
    }
}
