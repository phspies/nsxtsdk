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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTaskListResultType : NSXTListResultType
    {
        public NSXTTaskListResultType()
        {
        }
        /// <summary>
        /// Task property results
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Task property results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTTaskPropertiesType> Results { get; set; }
    }
}
