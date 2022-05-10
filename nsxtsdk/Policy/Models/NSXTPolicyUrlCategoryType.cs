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
    public class NSXTPolicyUrlCategoryType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The id of the category.
        /// </summary>
        [JsonProperty(PropertyName = "category_id", Required = Required.AllowNull)]
        public int CategoryId { get; set; }
        /// <summary>
        /// The name of the category.
        /// </summary>
        [JsonProperty(PropertyName = "category_name", Required = Required.AllowNull)]
        public string CategoryName { get; set; }
    }
}
