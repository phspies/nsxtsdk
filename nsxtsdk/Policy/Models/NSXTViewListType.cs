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
    /// Represents a list of views.
    /// </summary>
    [NSXTProperty(Description: @"Represents a list of views.")]
    public class NSXTViewListType 
    {
        /// <summary>
        /// Array of views
        /// </summary>
        [JsonProperty(PropertyName = "views")]
        public IList<NSXTViewType> Views { get; set; }
    }
}
