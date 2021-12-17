// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The status of a Livetrace request.SUCCESS_DELIVERED - The request is delivered successfully.LCP_FAILURE - LCP agent fails to realize the request.INVALID_FILTER - Filter is invalid.DATAPATH_FAILURE - Dataplane fails to realize the request.TIMEOUT - The response to the request is not received within timeout.CONNECTION_ERROR - There is connection error between host components.UNKNOWN - The status of request cannot be determined.
    /// </summary>
    [NSXTProperty(Description: @"The status of a Livetrace request.SUCCESS_DELIVERED - The request is delivered successfully.LCP_FAILURE - LCP agent fails to realize the request.INVALID_FILTER - Filter is invalid.DATAPATH_FAILURE - Dataplane fails to realize the request.TIMEOUT - The response to the request is not received within timeout.CONNECTION_ERROR - There is connection error between host components.UNKNOWN - The status of request cannot be determined.")]
    public enum NSXTLiveTraceStatusRequestStatusEnumType
    {
        [EnumMember(Value = "SUCCESS_DELIVERED")]
        SUCCESSDELIVERED = 1,
        [EnumMember(Value = "LCP_FAILURE")]
        LCPFAILURE = 2,
        [EnumMember(Value = "INVALID_FILTER")]
        INVALIDFILTER = 3,
        [EnumMember(Value = "DATAPATH_FAILURE")]
        DATAPATHFAILURE = 4,
        [EnumMember(Value = "CONNECTION_ERROR")]
        CONNECTIONERROR = 5,
        [EnumMember(Value = "TIMEOUT")]
        TIMEOUT = 6,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 7,
    }
}
