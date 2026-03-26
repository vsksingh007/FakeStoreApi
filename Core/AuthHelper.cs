using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Core
{
    internal class AuthHelper:BaseClient
    {
        public async Task<string> GetToken()
        {
            var request = new RestRequest("auth/login", Method.Post);

            request.AddJsonBody(new LoginRequest
            {
                username = "mor_2314",
                password = "83r5^_"
            });

            var response = await client.ExecuteAsync(request);

            dynamic result = JsonConvert.DeserializeObject(response.Content);
            return result.token;
        }
    }
}
