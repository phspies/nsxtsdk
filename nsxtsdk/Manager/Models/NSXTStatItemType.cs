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
    /// Displayed as a single number. It can be used to show the characteristics of entities such as Logical Switches, Firewall
        /// Rules, and so on. For example, number of logical switches and their admin states.
    /// </summary>
    [NSXTProperty(Description: @"Displayed as a single number. It can be used to show the characteristics of entities such as Logical Switches, Firewall Rules, and so on. For example, number of logical switches and their admin states.")]
    public class NSXTStatItemType 
    {
        /// <summary>
        /// Id of drilldown widget, if any. Id should be a valid id of an existing widget.
        /// </summary>
        public string? DrilldownId { get; set; }
        /// <summary>
        /// If expression for total is specified, it evaluates it. Total can be omitted if not needed to be shown.
        /// </summary>
        public string? Total { get; set; }
        /// <summary>
        /// Multi-line text to be shown on tooltip while hovering over the stat.
        /// </summary>
        public IList<NSXTTooltipType> Tooltip { get; set; }
        /// <summary>
        /// Expression for stat to be displayed.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
    }
}
