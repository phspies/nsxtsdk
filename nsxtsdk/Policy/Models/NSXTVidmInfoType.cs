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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Vidm Info
    /// </summary>
    [NSXTProperty(Description: @"Vidm Info")]
    public class NSXTVidmInfoType 
    {
        /// <summary>
        /// User's Full Name Or User Group's Display Name
        /// </summary>
        public string? DisplayName { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        public NSXTVidmInfoTypeEnumType? Type { get; set; }
        /// <summary>
        /// Username Or Groupname
        /// </summary>
        public string? Name { get; set; }
    }
}
