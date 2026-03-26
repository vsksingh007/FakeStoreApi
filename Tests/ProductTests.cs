using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FakeStoreApi.Core
{
    internal class ProductTests: TestBase
    {
        [Test]
        public async Task GetProducts()
        {
            var response = await apiHelper.SendRequest("products", Method.Get);

            Logger.Log(response.Content);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
