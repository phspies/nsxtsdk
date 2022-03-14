// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public IList<NSXTFilterRequestType> Filters { get; set; }
    }
}
