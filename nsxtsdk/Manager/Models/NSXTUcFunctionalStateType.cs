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
    /// Upgrade coordinator Uc functional State.
    /// </summary>
    [NSXTProperty(Description: @"Upgrade coordinator Uc functional State.")]
    public class NSXTUcFunctionalStateType 
    {
        /// <summary>
        /// function state of the upgrade coordinator
        /// </summary>
        public NSXTUcFunctionalStateStateEnumType? State { get; set; }
        /// <summary>
        /// error message that explains why UC is on standby mode.
        /// </summary>
        public string? ErrorMessage { get; set; }
    }
}
