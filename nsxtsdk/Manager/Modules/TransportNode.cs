// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class TransportNode
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public TransportNode(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void UpdateTransportNodeMaintenanceMode(string TransportnodeId, string? Action = null)
        {
            if (TransportnodeId == null) { throw new System.ArgumentNullException("TransportnodeId cannot be null"); }
            
            StringBuilder UpdateTransportNodeMaintenanceModeServiceURL = new StringBuilder("/transport-nodes/{transportnode-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            UpdateTransportNodeMaintenanceModeServiceURL.Replace("{transportnode-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportnodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = UpdateTransportNodeMaintenanceModeServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + UpdateTransportNodeMaintenanceModeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
    }
}
