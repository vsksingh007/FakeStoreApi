using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Core
{

    public class ApiHelper : BaseClient
    {
        public async Task<RestResponse> SendRequest(string endpoint, Method method, object body = null)
        {
            var request = new RestRequest(endpoint, method);

            request.AddHeader("Content-Type", "application/json");

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return await client.ExecuteAsync(request);
        }
    }
}
