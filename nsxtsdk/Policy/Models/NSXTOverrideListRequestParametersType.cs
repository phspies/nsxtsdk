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
    /// Parameter to filter overridden resource list by intent path or site path or both.
    /// </summary>
    [NSXTProperty(Description: @"Parameter to filter overridden resource list by intent path or site path or both.")]
    public class NSXTOverrideListRequestParametersType 
    {
        /// <summary>
        /// Site path
        /// </summary>
        public string? SitePath { get; set; }
        /// <summary>
        /// Global resource path
        /// </summary>
        public string? IntentPath { get; set; }
    }
}
