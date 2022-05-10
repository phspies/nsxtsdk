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
    /// Guest virtual machine details include OS name and computer name of guest VM.
    /// </summary>
    [NSXTProperty(Description: @"Guest virtual machine details include OS name and computer name of guest VM.")]
    public class NSXTGuestInfoType 
    {
        /// <summary>
        /// OS name of guest virtual machine. Currently this is supported for guests
        /// on ESXi that have VMware Tools installed.
        /// </summary>
        [JsonProperty(PropertyName = "os_name")]
        public string? OsName { get; set; }
        /// <summary>
        /// Computer name of guest virtual machine, which is set inside guest OS.
        /// Currently this is supported for guests on ESXi that have VMware Tools installed.
        /// </summary>
        [JsonProperty(PropertyName = "computer_name")]
        public string? ComputerName { get; set; }
    }
}
