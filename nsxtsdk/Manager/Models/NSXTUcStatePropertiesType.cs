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
    /// Upgrade Coordinator state properties
    /// </summary>
    [NSXTProperty(Description: @"Upgrade Coordinator state properties")]
    public class NSXTUcStatePropertiesType 
    {
        /// <summary>
        /// Flag for updating upgrade-coodinator state properties to database
        /// </summary>
        [JsonProperty(PropertyName = "update_uc_state_properties")]
        public bool? UpdateUcStateProperties { get; set; }
    }
}
