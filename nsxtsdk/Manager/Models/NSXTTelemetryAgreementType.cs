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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTelemetryAgreementType : NSXTManagedResourceType
    {
        /// <summary>
        /// Determine if telemetry agreement has been displayed. If false,
        /// the agreement text will be displayed at login time.
        /// </summary>
        [JsonProperty(PropertyName = "telemetry_agreement_displayed", Required = Required.AllowNull)]
        public bool TelemetryAgreementDisplayed { get; set; }
    }
}
