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
    /// Upgrade Coordinator state properties
    /// </summary>
    [NSXTProperty(Description: @"Upgrade Coordinator state properties")]
    public class NSXTUcStatePropertiesType 
    {
        /// <summary>
        /// Flag for updating upgrade-coodinator state properties to database
        /// </summary>
        public bool? UpdateUcStateProperties { get; set; }
    }
}
