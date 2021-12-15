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
    /// Filtering parameters to get only a subset of intrusion events.
    /// </summary>
    [NSXTProperty(Description: @"Filtering parameters to get only a subset of intrusion events.")]
    public class NSXTIDSEventDataRequestType 
    {
        /// <summary>
        /// An array of filter conditions.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        [NSXTProperty(IsRequired: false, Description: @"An array of filter conditions.")]
        public IList<NSXTFilterRequestType> Filters { get; set; }
    }
}
