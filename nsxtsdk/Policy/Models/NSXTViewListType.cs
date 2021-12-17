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
    /// Represents a list of views.
    /// </summary>
    [NSXTProperty(Description: @"Represents a list of views.")]
    public class NSXTViewListType 
    {
        public NSXTViewListType()
        {
        }
        /// <summary>
        /// Array of views
        /// </summary>
        [JsonProperty(PropertyName = "views")]
        [NSXTProperty(IsRequired: false, Description: @"Array of views")]
        public IList<NSXTViewType> Views { get; set; }
    }
}
