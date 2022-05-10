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
    /// Each revoked certificate is identified in a CRL by its certificate serial number.
    /// </summary>
    [NSXTProperty(Description: @"Each revoked certificate is identified in a CRL by its certificate serial number.")]
    public class NSXTX509CrlEntryType 
    {
        /// <summary>
        /// Revocation date.
        /// </summary>
        [JsonProperty(PropertyName = "revocation_date")]
        public string? RevocationDate { get; set; }
        /// <summary>
        /// The revoked certificate's serial number.
        /// </summary>
        [JsonProperty(PropertyName = "serial_number")]
        public string? SerialNumber { get; set; }
    }
}
