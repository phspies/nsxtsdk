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
    /// Information on the Network interfaces present on the partner appliance that needs to be configured by the NSX Manager.
    /// </summary>
    [NSXTProperty(Description: @"Information on the Network interfaces present on the partner appliance that needs to be configured by the NSX Manager.")]
    public class NSXTNicMetadataType 
    {
        /// <summary>
        /// Network Interface label.
        /// </summary>
        [JsonProperty(PropertyName = "interface_label", Required = Required.AllowNull)]
        public string InterfaceLabel { get; set; }
        /// <summary>
        /// Interface that needs to be configured on the partner appliance. Ex. MANAGEMENT, DATA1, DATA2, HA1, HA2, CONTROL.
        /// </summary>
        [JsonProperty(PropertyName = "interface_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNicMetadataInterfaceTypeEnumType InterfaceType { get; set; }
        /// <summary>
        /// Transport Type of the service, which is the mechanism of redirecting the traffic to the the partner appliance. Transport
        /// type is required if Service caters to any functionality other than EPP and MPS. Here, the transports array specifies the
        /// kinds of transport where this particular NIC is user configurable. If nothing is specified, and the "user_configurable"
        /// flag is true, then user configuration will be allowed for all transports. If any transport is/are specified, then it
        /// will be considered as user configurable for the specified transports only."
        /// </summary>
        [JsonProperty(PropertyName = "transports")]
        public IList<string> Transports { get; set; }
        /// <summary>
        /// Used to specify if the given interface needs configuration. Management nics will always need the configuration, for
        /// others it will be use case specific. For example, a DATA NIC may be user configurable if the appliance is deployed in
        /// certain mode, such as L3_ROUTED.
        /// </summary>
        [JsonProperty(PropertyName = "user_configurable")]
        public bool? UserConfigurable { get; set; }
        /// <summary>
        /// Network Interface index.
        /// </summary>
        [JsonProperty(PropertyName = "interface_index", Required = Required.AllowNull)]
        public long InterfaceIndex { get; set; }
    }
}
