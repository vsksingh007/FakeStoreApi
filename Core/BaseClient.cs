using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace FakeStoreApi.Core
{
    public class BaseClient
    {
        protected RestClient client;

        public BaseClient()
        {
            client = new RestClient("https://fakestoreapi.com/");
        }
    }
}
